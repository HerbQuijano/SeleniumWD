using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWD.Section_10.Exam_Section_10
{
    class DataList
    {
        public static ArrayList SortData(ArrayList data)
        {
            int intValue;
            string stringData;

            for (int i = 0; i < data.Count; i++)
            {
                stringData = data[i].ToString();
                if (int.TryParse(stringData, out intValue) == false)
                {
                    data.Remove(data[i]);
                }
                else
                    int.Parse(data[i].ToString());
                
                 
            }
            return data;
        }

        public static double TotalNums(ArrayList data)
        {
            double value;
            double sum = 0;

            for (int i = 0; i < data.Count; i++)
            {
                value = double.Parse(data[i].ToString());
                sum += value;
            }

            return sum;
        }


    }
}
