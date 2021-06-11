# MCronberg.CSCourseHelper.Standard

> Please note that 1.0.10 has moved 'MCronberg.CSCourseHelper.Standard' to 'MCronberg'.

This is a simple package to help in C# training. It contains:

- Extensions methods (remember to include MCronberg in using-statement)
  - instance.ToStringEx() 
    - Reflection info
  - Type.ToStringEx() (overloaded to save in file)
    - Reflection info
  - instance.ToJsonString() (obsolete - use Dump)
  - instance.Dump()
    - returns JSON    
  - IEnumerable<T>.Dump()
    - returns JSON
- ConsoleEx (Exstra Console methods)
  - String WriteAndReadText(String txt, Object defaultValue, Boolean showDefaultValue)
  - Void Clear()   
  - Void Header(String txt, Boolean clear, Char character)
  - DateTime ReadDate(String txt, Nullable<DateTime> defaultValue, Boolean showDefaultValue)
  - Double ReadDouble(String txt, Double defaultValue, Boolean showDefaultValue)
  - Int32 ReadInt(String txt, Int32 defaultValue, Boolean showDefaultValue) 
  - Int32 ReadMenu(String[] items)
  - String ReadString(String txt, String defaultValue, Boolean showDefaultValue)
  - ConsoleKey Wait(String text)
  - Void Write(String txt)
  - Void WriteLine(String txt, Boolean alert)
  - Void WriteLine(Object[] text)

## Random people

This is the model provided for using random people

![](/Person.png)

![](/repository.png)
