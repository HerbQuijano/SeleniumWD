using System;
delegate void Procedure();

namespace section14
{
  

    public class DelegateDemo
    {
        public static void Method1()
        {
            Console.WriteLine("Method 1");
        }

        public static void Method2()
        {
            Console.WriteLine("Method 2");
        }

        public void Method3()
        {
            Console.WriteLine("Method 3");
        }

        public static void Main()
        {
            Procedure procedure = null;

            procedure += new Procedure(DelegateDemo.Method1);
            procedure += new Procedure(Method2);

            DelegateDemo demo = new DelegateDemo();

            procedure += new Procedure(demo.Method3);
            procedure();
        }
    }
}