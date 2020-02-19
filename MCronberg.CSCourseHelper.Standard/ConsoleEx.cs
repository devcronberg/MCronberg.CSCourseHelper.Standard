namespace MCronberg
{
    using System;
    using System.Linq;

    public static class ConsoleEx
    {

        public static string ToJsonString(this object obj, bool indented = false)
        {
            try
            {
                return Newtonsoft.Json.JsonConvert.SerializeObject(obj, indented ? Newtonsoft.Json.Formatting.Indented : Newtonsoft.Json.Formatting.None);
            }
            catch (System.Exception ex)
            {
                return ex.Message;
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

        public static void Write(string txt)
        {
            System.Console.Write(txt);

        }

        public static ConsoleKey Wait(string text = "Press any key to continue ... ")
        {
            Console.WriteLine();
            Console.Write(text);
            var r = Console.ReadKey();
            return r.Key;
        }

        public static void Clear()
        {
            Console.Clear();
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

        public static string ReadString(string txt = null, string defaultValue = "", bool showDefaultValue = false)
        {
            string tmp = WriteAndReadText(txt, defaultValue, showDefaultValue);
            if (tmp != "")
                return tmp;
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