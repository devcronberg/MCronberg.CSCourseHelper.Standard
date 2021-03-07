using System;
using System.Collections.Generic;
using MCronberg;

namespace MCronberg.CSCourseHelper.Standard.Demo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            PersonRepositoryStatic r = new PersonRepositoryStatic();
            //var p = r.GetPerson(1);
            //p.FirstName = "*";
            //r.UpdatePerson(p);
            //p = r.GetPerson(1);

            //Console.WriteLine(p.ToStringEx());
            //Console.WriteLine(p.ToJsonString());

            //p.Dump();
            r.GetPeople().Dump();

            typeof(Test).ToStringEx(@"c:\tmp\m.txt");
        }
    }

    internal class Test
    {
        public static int f_b;
        public static Action<int, bool> T1;
        public int f_a;

        private static int f_d;

        private int f_c;

        static Test()
        {
        }

        public Test()
        {
        }

        public Test(int a)
        {
        }

        private Test(bool a)
        {
        }

        public event Action E1;

        public static int p_c { get; set; }
        public int p_a { get; set; }
        public int p_a2 { get; }
        public int p_a3 { get; private set; }

        private static int p_d { get; set; }
        private int p_b { get; set; }

        public static void A()
        {
        }

        public void B()
        {
        }

        public void C(int a)
        {
        }

        public void C(int a, bool b)
        {
        }
    }
}