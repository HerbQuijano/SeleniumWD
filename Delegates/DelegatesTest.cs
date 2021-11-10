using System;

namespace Delegates
{
    internal class DelegatesTest
    {
        private delegate int MyDelegate(int a, int b);

        public static int Sum(int a, int b)
        {
            int result = a + b;
            Console.WriteLine(result);
            return result;
        }

        public static int Mult(int a, int b)
        {
            int result = a * b;
            Console.WriteLine(result);
            return result;
        }

        private delegate string ConcatenatedDelegate(string str, string str2);

        public static string Concatenate(string string1, string string2)
        {
            string concatenated = string1 + " " + string2;
            Console.WriteLine(concatenated);
            return concatenated;
        }

        public static string ExtractSubstring(string str1, string str2)
        {
            string mainString = Concatenate(str1, str2);
            string subStr = mainString.Substring(8);
            Console.WriteLine(subStr);
            return subStr;
        }

        public static void Main()
        {
            //MyDelegate myDel = null;

            //Delegado es igual a nuevo delegado, pasandole el metodo que quiero como parametro
            MyDelegate myDelSum = new MyDelegate(Sum);
            //luego, pasarle al objeto delegado, los valores que quiero que use para el metodo que recibio.
            myDelSum(4, 5);

            MyDelegate myDelMult = new MyDelegate(Mult);
            myDelMult(3, 5);

            ConcatenatedDelegate conc = new ConcatenatedDelegate(Concatenate);
            conc("Hola", "Como estas?");

            ConcatenatedDelegate conc2 = new ConcatenatedDelegate(ExtractSubstring);
            conc2("Hola, que pedo", "Esta es una super cadena de texto");
            

         
        }
    }
}