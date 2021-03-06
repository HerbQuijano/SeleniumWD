using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section13
{
    static class ExceptionHelper
    {
        public static void DivisionTest()
        {
            try
            {
                int totalScores = 10;
                int countOfScores = 0;

                double average = totalScores / countOfScores;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Division Operation");
            }
         
        }

        public static string state;

        public static void CheckState(string st)
        {
            switch (st.ToUpper())
            {
                case "FL":
                case "GA":
                case "NC":
                case "SC":
                case "VA":
                    state = st.ToUpper();
                    break;
                default:
                    Exception ex = new Exception("State not part" + " of Atlantic ICW");
                    throw ex;

            }
        }
        public static void CheckStateCustom(string st)
        {
            switch (st.ToUpper())
            {
                case "FL":
                case "GA":
                case "NC":
                case "SC":
                case "VA":
                    state = st.ToUpper();
                    break;
                default:
                    CustomException ex = new CustomException("State not part" + " of Atlantic ICW");
                    throw ex;

            }
        }
    }
}
