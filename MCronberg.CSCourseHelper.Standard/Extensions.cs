using System;
using System.Collections.Generic;
using System.Text;

namespace MCronberg
{
    using System;
    using System.Linq;
    using System.Reflection;

    public static class Extensions
    {
        public static void Clear()
        {
            Console.Clear();
        }

        public static void Dump(this object o, bool indented = true)
        {
            Console.WriteLine(GetJson(o, indented));
        }

        public static void Dump<T>(this IEnumerable<T> lst, bool indented = true)
        {
            foreach (var i in lst)
            {
                Console.WriteLine(GetJson(i, indented));
            }
        }

        public static void Header(string txt, bool clear = false, char character = '=')
        {
            if (clear)
                System.Console.Clear();
            Console.WriteLine(new string(character, txt.Length + 2));
            Console.WriteLine(" " + txt);
            Console.WriteLine(new string(character, txt.Length + 2));
            Console.WriteLine();
        }

        public static DateTime ReadDate(string txt = null, DateTime? defaultValue = null, bool showDefaultValue = false)
        {
            DateTime dValue = defaultValue ?? DateTime.Now.Date;
            string tmp = WriteAndReadText(txt, dValue, showDefaultValue);
            if (!tmp.Contains("-") && tmp.Length == 6)
            {
                tmp = tmp.Substring(0, 2) + "-" + tmp.Substring(2, 2) + "-" + tmp.Substring(4, 2);
            }
            if (!tmp.Contains("-") && tmp.Length == 8)
            {
                tmp = tmp.Substring(0, 4) + "-" + tmp.Substring(4, 2) + "-" + tmp.Substring(6, 2);
            }
            DateTime v;
            bool res = DateTime.TryParse(tmp, out v);
            if (res)
                return v;
            else
                return dValue;
        }

        public static double ReadDouble(string txt = null, double defaultValue = 0, bool showDefaultValue = false)
        {
            string tmp = WriteAndReadText(txt, defaultValue, showDefaultValue);
            tmp = tmp.Replace(",", ".");
            double v = 0;
            bool res = double.TryParse(tmp, style: System.Globalization.NumberStyles.Any, provider: new System.Globalization.CultureInfo("en-US"), result: out v);
            if (res)
                return v;
            else
                return defaultValue;
        }

        public static int ReadInt(string txt = null, int defaultValue = 0, bool showDefaultValue = false)
        {
            string tmp = WriteAndReadText(txt, defaultValue, showDefaultValue);
            int v = 0;
            bool res = int.TryParse(tmp, out v);
            if (res)
                return v;
            else
                return defaultValue;
        }

        public static int ReadMenu(params string[] items)
        {
            if (items == null || items.Length == 0)
                throw new ApplicationException("Menu items missing");
            if (items.Length > 9)
                throw new ApplicationException("Too many menu items");

            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine((i + 1) + " " + items[i]);
            }
            Console.WriteLine();
            Console.Write("Enter menu # (1-" + (items.Length) + "): ");

            ConsoleKeyInfo input;
            bool c1;
            do
            {
                input = Console.ReadKey(true);
                c1 = ((int)input.KeyChar - 48) >= 1 && ((int)input.KeyChar - 48) <= (items.Length);
            } while (!c1);
            Console.WriteLine();
            return (int)input.KeyChar - 47;
        }

        public static string ReadString(string txt = null, string defaultValue = "", bool showDefaultValue = false)
        {
            string tmp = WriteAndReadText(txt, defaultValue, showDefaultValue);
            if (tmp != "")
                return tmp;
            else
                return defaultValue;
        }

        public static string ToJsonString(this object obj, bool indented = false)
        {
            try
            {
                return GetJson(obj, indented);
            }
            catch (System.Exception ex)
            {
                return ex.Message;
            }
        }

        public static void ToStringEx(this Type type, string filePath, bool showBackingFields = false, bool showGetSetAddMethods = false, bool showObjectMembers = false, bool showFullName = false, int typeStringLength = 25)
        {
            string txt = ToStringEx(type, showBackingFields, showGetSetAddMethods, showObjectMembers, showFullName, typeStringLength);
            System.IO.File.WriteAllText(filePath, txt);
        }

        public static string ToStringEx(this Type type, bool showBackingFields = false, bool showGetSetAddMethods = false, bool showObjectMembers = false, bool showFullName = false, int typeStringLength = 25)
        {
            string non = "none";
            string pre = "  ";
            string pri = "private  ";
            string pub = "public   ";
            string sta = "static   ";
            string ins = "instance ";
            int lengthType = typeStringLength;

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.AppendLine(showFullName ? type.FullName : type.Name);
            sb.AppendLine(new string('-', (showFullName ? type.FullName : type.Name).Length));

            var fields = type.GetFields(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static).OrderBy(i => i.IsStatic).ThenBy(i => i.IsPublic).ThenBy(i => i.Name).ToList();
            if (!showBackingFields)
                fields = fields.Where(i => !i.Name.Contains("<")).ToList();
            sb.AppendLine();
            sb.AppendLine("Fields:");
            sb.AppendLine();
            if (fields.Count == 0)
                sb.AppendLine(non);
            else
            {
                foreach (var i in fields)
                {
                    var p = (i.IsPublic ? pub : "") + (!i.IsPublic ? pri : "") + (i.IsStatic ? sta : "") + (!i.IsStatic ? ins : "");
                    string t = "";
                    if (i.FieldType.IsGenericType)
                        t = getTypeAsString(i.FieldType);
                    else
                        t = showFullName ? i.FieldType.FullName : i.FieldType.Name;

                    sb.AppendLine(pre + p + " " + truncate(t, lengthType) + " " + i.Name);
                }
            }

            sb.AppendLine();
            sb.AppendLine("Properties:");
            sb.AppendLine();
            var propterties = type.GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static).OrderBy(i => i.Name).ToList();
            if (propterties.Count == 0)
                sb.AppendLine(pre + non);
            else
            {
                foreach (var i in type.GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).OrderBy(i => i.Name).ToList())
                {
                    var p = pri + ins;
                    string g = "", s = "", gs = "";
                    if (i.CanRead)
                        g = (i.GetMethod.IsPublic ? pub.Trim() : pri.Trim()) + " " + (i.CanRead ? "get" : "");
                    if (i.CanWrite)
                        s = (i.GetMethod.IsPublic ? pub.Trim() : pri.Trim()) + " " + (i.CanRead ? "set" : "");
                    if (s + g != "")
                        gs = "(" + g + " " + s + ")";
                    sb.AppendLine(propertyString(i));
                }

                foreach (var i in type.GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public).OrderBy(i => i.Name).ToList())
                {
                    var p = pub + ins;
                    string g = "", s = "", gs = "";
                    if (i.CanRead)
                        g = (i.GetMethod.IsPublic ? pub.Trim() : pri.Trim()) + " " + (i.CanRead ? "get" : "");
                    if (i.CanWrite)
                        s = (i.GetMethod.IsPublic ? pub.Trim() : pri.Trim()) + " " + (i.CanRead ? "set" : "");
                    if (s + g != "")
                        gs = "(" + g + " " + s + ")";
                    sb.AppendLine(propertyString(i));
                }
            }

            sb.AppendLine();
            sb.AppendLine("Constructors:");
            sb.AppendLine();
            var constructors = type.GetConstructors(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static).OrderBy(i => i.IsStatic).ThenBy(i => i.IsPublic).ThenBy(i => i.Name).ToList();
            if (constructors.Count == 0)
                sb.AppendLine(pre + non);
            else
            {
                foreach (var i in constructors)
                {
                    List<string> pa = new List<string>();
                    foreach (ParameterInfo para in i.GetParameters())
                        pa.Add(getTypeAsString(para.ParameterType, showFullName) + " " + para.Name);
                    var p = (i.IsPublic ? pub : "") + (!i.IsPublic ? pri : "") + (i.IsStatic ? sta : "") + (!i.IsStatic ? ins : "");
                    sb.AppendLine(pre + p + " " + truncate("", lengthType) + " " + type.Name + "(" + string.Join(',', pa).Replace(",", ", ") + ")");
                }
            }

            sb.AppendLine();
            sb.AppendLine("Methods:");
            sb.AppendLine();
            var methods = type.GetMethods(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static).OrderBy(i => i.IsStatic).ThenBy(i => i.IsPublic).ThenBy(i => i.Name).ToList();
            if (!showGetSetAddMethods)
                methods = methods.Where(i => !i.Name.StartsWith("get_") && !i.Name.StartsWith("set_") && !i.Name.StartsWith("add_")).ToList();

            methods = methods.Where(i => !i.Name.StartsWith("<")).ToList();

            string[] objectM = { "Finalize", "ToString", "MemberwiseClone", "Equals", "GetHashCode", "GetType" };
            if (!showObjectMembers)
                methods = methods.Where(i => !objectM.Contains(i.Name)).ToList();

            if (propterties.Count == 0)
                sb.AppendLine(pre + non);
            else
            {
                foreach (var i in methods)
                {
                    List<string> pa = new List<string>();
                    foreach (ParameterInfo para in i.GetParameters())
                        pa.Add(getTypeAsString(para.ParameterType, showFullName) + " " + para.Name);
                    var p = (i.IsPublic ? pub : "") + (!i.IsPublic ? pri : "") + (i.IsStatic ? sta : "") + (!i.IsStatic ? ins : "");

                    sb.AppendLine(pre + p + " " + truncate(getTypeAsString(i.ReturnType, showFullName), lengthType) + " " + i.Name + "(" + string.Join(',', pa).Replace(",", ", ") + ")");
                }
            }

            sb.AppendLine();
            sb.AppendLine("Events:");
            sb.AppendLine();
            var events = type.GetEvents(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static).OrderBy(i => i.Name).ToList();
            if (events.Count == 0)
                sb.AppendLine(pre + non);
            else
            {
                foreach (var i in events)
                {
                    sb.AppendLine(pre + pub + ins + " " + truncate(getTypeAsString(i.EventHandlerType, showFullName), lengthType) + i.Name);
                }
            }

            return sb.ToString();

            string propertyString(PropertyInfo i)
            {
                var p = pub + ins;
                string g = "", s = "", gs = "";
                if (i.CanRead)
                    g = (i.GetMethod.IsPublic ? pub.Trim() : pri.Trim()) + " " + (i.CanRead ? "get" : "");
                if (i.CanWrite)
                    s = (i.GetMethod.IsPublic ? pub.Trim() : pri.Trim()) + " " + (i.CanRead ? "set" : "");
                if (s + g != "")
                    gs = "(" + g + (s != "" ? " " : "") + s + ")";
                return pre + p + " " + truncate(getTypeAsString(i.PropertyType, showFullName), lengthType) + " " + i.Name + " " + gs;
            }

            string truncate(string txt, int lenght)
            {
                if (txt.Length <= lenght)
                    return txt.PadRight(lenght);
                else
                    return txt.Substring(0, lenght - 3) + "...";
            }

            string getTypeAsString(Type t, bool useFullName = false)
            {
                if (!t.IsGenericType)
                    return useFullName ? t.FullName : t.Name;
                string genericTypeName = t.GetGenericTypeDefinition().Name;
                genericTypeName = genericTypeName.Substring(0,
                    genericTypeName.IndexOf('`'));
                string genericArgs = string.Join(", ",
                    t.GetGenericArguments()
                        .Select(ta => getTypeAsString(ta)).ToArray());
                return genericTypeName + "<" + genericArgs + ">";
            }
        }

        public static string ToStringEx(this object obj, bool showFields = true, bool showProperties = true, bool showMethods = true)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            string types = "(";
            if (showFields)
                types += "fields ";
            if (showProperties)
                types += "properties ";
            if (showMethods)
                types += "methods ";

            types = types.Trim().Replace(" ", ",") + ")";
            if (types.Split(',').Length == 1)
                types = types.Replace(")", " only)");

            if (types.Split(',').Length == 2)
                types = types.Replace(",", " and ");
            else
                types = types.Replace(",", ", ");

            string header = "Showing members " + types + " from object of type " + obj.GetType().ToString() + ":";
            sb.AppendLine(header);
            sb.Append(new string('-', header.Length));
            sb.AppendLine("");
            if (showFields)
            {
                sb.AppendLine("Fields:");
                sb.AppendLine("");
                foreach (var item in obj.GetType().GetFields(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.DeclaredOnly).OrderBy(i => i.Name))
                {
                    string a = "Private ";
                    if (item.IsPublic)
                        a = "Public ";
                    object value = item.GetValue(obj);

                    if (value == null)
                        value = "null";
                    sb.AppendLine(print(a, 10) + " " + print(item.FieldType.ToString(), 25) + " " + print(item.Name, 30) + " " + print(value.ToString(), 20));
                }
                sb.AppendLine("");
            }
            if (showProperties)
            {
                sb.AppendLine("Properties:");
                sb.AppendLine("");
                foreach (var item in obj.GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.DeclaredOnly).OrderBy(i => i.Name))
                {
                    string a = "";
                    if (item.CanRead && item.CanWrite)
                        a = "get/set";
                    if (item.CanRead && !item.CanWrite)
                        a = "get";
                    if (!item.CanRead && item.CanWrite)
                        a = "set";
                    object value = null;
                    try
                    {
                        value = item.GetValue(obj);
                    }
                    catch (System.Exception)
                    {
                    }

                    if (value == null)
                        value = "null";
                    sb.AppendLine("" + print(a, 10) + " " + print(item.PropertyType.ToString(), 25) + " " + print(item.Name, 30) + " " + print(value.ToString(), 20) + "");
                }
                sb.AppendLine("");
            }
            if (showMethods)
            {
                sb.AppendLine("Methods:");
                sb.AppendLine("");
                foreach (var item in obj.GetType().GetMethods(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.DeclaredOnly).OrderBy(i => i.Name))
                {
                    string a = "Private ";
                    if (item.IsPublic)
                        a = "Public ";
                    object value = "";
                    if (value == null)
                        value = "null";
                    sb.AppendLine("" + print(a, 10) + " " + print(item.ReturnType.ToString(), 25) + " " + print(item.Name, 30) + " " + print(value.ToString(), 20));
                }
                sb.AppendLine("");

                sb.AppendLine("More info:");
                sb.AppendLine("");
                sb.AppendLine(print("Primitive", 37) + print(obj.GetType().IsPrimitive.ToString(), 30));
                sb.AppendLine(print("ValueType", 37) + print(obj.GetType().IsValueType.ToString(), 30));
                sb.AppendLine(print("ReferenceType", 37) + print(obj.GetType().IsClass.ToString(), 30));
                sb.AppendLine(print("Array", 37) + print(obj.GetType().IsArray.ToString(), 30));
                sb.AppendLine(print("Abstract", 37) + print(obj.GetType().IsAbstract.ToString(), 30));
                sb.AppendLine(print("Enum", 37) + print(obj.GetType().IsEnum.ToString(), 30));
                if (obj.GetType().IsEnum)
                    sb.AppendLine(print("Enum value", 37) + print(obj.ToString(), 30));
                sb.AppendLine(print("Interface", 37) + print(obj.GetType().IsInterface.ToString(), 30));
                sb.AppendLine(print("Sealed", 37) + print(obj.GetType().IsSealed.ToString(), 30));
            }
            string print(string txt, int length)
            {
                if (txt.Length > length)
                {
                    txt = txt.Substring(0, length - 2) + "..";
                }
                return txt.PadRight(length);
            }

            return sb.ToString();
        }

        public static ConsoleKey Wait(string text = "Press any key to continue ... ")
        {
            Console.WriteLine();
            Console.Write(text);
            var r = Console.ReadKey();
            return r.Key;
        }

        public static void Write(string txt)
        {
            System.Console.Write(txt);
        }

        public static void WriteLine(string txt, bool alert = false)
        {
            var c = Console.ForegroundColor;
            if (alert)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
            }

            System.Console.WriteLine(txt);
            if (alert)
            {
                Console.ForegroundColor = c;
                Console.WriteLine();
            }
        }

        public static void WriteLine(params object[] text)
        {
            foreach (var item in text)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }

        private static string GetJson(object o, bool indented)
        {
            return System.Text.Json.JsonSerializer.Serialize(o, new System.Text.Json.JsonSerializerOptions { WriteIndented = indented });
        }

        private static string WriteAndReadText(string txt, object defaultValue = null, bool showDefaultValue = false)
        {
            if (txt == null)
                txt = "";
            txt = txt.Replace(":", "").Trim();
            if (defaultValue != null && showDefaultValue)
            {
                if (defaultValue.GetType() == typeof(DateTime))
                {
                    txt += " (default value = " + Convert.ToDateTime(defaultValue).ToShortDateString() + ")";
                }
                else if (defaultValue.GetType() == typeof(string))
                {
                    txt += " (default value = \"" + defaultValue + "\")";
                }
                else
                {
                    txt += " (default value = " + defaultValue.ToString() + ")";
                }
            }
            txt += ": ";
            Console.Write(txt);
            string tmp = Console.ReadLine();
            return tmp;
        }
    }
}