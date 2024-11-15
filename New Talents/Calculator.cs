using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace New_Talents
{
    public class Calculator
    {
        private List<string> ListHistoric;
        private string date;

        public Calculator(string date)
        {
            ListHistoric = new();
            this.date = date;
        }

        public int Add(int val1, int val2)
        {
            int res = val1 + val2;
            ListHistoric.Insert(0, $"Res: " + res + " - data: " + date);
            return res;
        } 


        public int Subtract(int val1, int val2)
         {
            int res = val1 - val2;
            ListHistoric.Insert(0, $"Res: " + res + " - data: " + date);
            return res;
        } 

        public int Multiply(int val1, int val2)
         {
            int res = val1 * val2;
            ListHistoric.Insert(0, $"Res: " + res + " - data: " + date);
            return res;
        } 

        public int Divide(int val1, int val2)
        {
            if (val2 == 0)
            {
                throw new DivideByZeroException("Not's possible by zero");
            }

            int res = val1 / val2;
            ListHistoric.Insert(0, $"Res: " + res + " - data: " + date);
            return res;
        } 

        public List<string> Historic()
        {   
            if (ListHistoric.Count > 3)
            {
                ListHistoric.RemoveRange(3, ListHistoric.Count - 3);
            }
            return ListHistoric;
        }
    }
}