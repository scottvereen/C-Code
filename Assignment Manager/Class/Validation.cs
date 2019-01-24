using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Class
{
    
    public class Validation
    {
        public static bool IsStringClean(string temp)
        {

           bool result = true;

            string[] bw = { "Hillary Clinton", "Obama" };

            for (int ctr = 0; ctr < bw.Count(); ctr++)
            {
                if (temp.ToUpper().Contains(bw[ctr]))
                {
                    result = false;

                }

            }

            return result;

        }

        

        public static bool IsItFilledIn(string temp)
        {
            bool result = false;
            if (temp.Length > 0)
            {
                result = true;
            }
            return result;
        }
        

        
        public static bool IsItFilledIn(string temp, int minlen)
        {
            bool result = false;

            if (temp.Length > minlen)
            {
                result = true;
            }
            return result;
        }

        


        public static bool IsNumeric(string  temp)
        {

            bool result = temp.All(char.IsDigit);

            return result;

       }
        

        
        public static bool IsValidEmail(string temp)
        {
            

            bool result = true;

            int atLocation = temp.IndexOf("@");
            int NextatLocation = temp.IndexOf("@", atLocation + 1);

            

            int periodLocation = temp.LastIndexOf(".");

           
            if (temp.Length < 8)
            {
                result = false;
            }
            else if (atLocation < 2) 
            {
                result = false;
            }
            else if (periodLocation + 2 > (temp.Length))
            {
                result = false;
            }
            return result;
        }
    }
}
