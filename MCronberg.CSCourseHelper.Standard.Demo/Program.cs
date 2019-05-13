using System;
using System.Collections.Generic;
using MCronberg;

namespace MCronberg.CSCourseHelper.Standard.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonRepositoryStatic r = new PersonRepositoryStatic();
            var p = r.GetPerson(1);
            p.FirstName = "*";
            r.UpdatePerson(p);
            p = r.GetPerson(1);

            Console.WriteLine(p.ToStringEx());
            Console.WriteLine(p.ToJsonString());
        }
    }
}
