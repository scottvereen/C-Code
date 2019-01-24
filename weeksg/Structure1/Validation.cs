using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure1
{
    class Validation
    {
        public static bool FName(string temp)
        {
            bool result = false;

            if (temp.Length > 1)
            {
                result = true;
            }

            else if (temp.Length < 0)
            {
                result = true;
            }
            return result;
        }

        public static bool LastName(string temp) 
        {
            bool result = true;

            if (temp.Length > 0) 
            {
                result = true;
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

            if (temp.Length >= minlen)
            {
                result = true;
            }

            return result;
        }

        public static bool IsValidEmail(string temp)
        {
            bool result = true;

            int atLocation = temp.IndexOf("@");
            int NextatLocation = temp.IndexOf("@", atLocation+1);


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

        public static bool IsValidLength(string temp, int intMinLen, int intMaxLen)
        {
            bool result = true;
           

            if(temp.Length < 2)
             {
              result = false;
             }
            else if (intMinLen < 0)
            {
                result = false;
            }
            else if (intMaxLen < 2)
            {
                result = false;
            }

            return result;
    
        }

        public static bool isWithinRange(int intTemp, int intMinLen, int intMaxLen)
        {
            bool result = true;

            if (intTemp < 0)
            {
                result = true;
            }

            return result;
        }

        public static bool IsPhoneNumberFilled(string temp)
        {
            bool result = false;

            foreach (Char c in temp)
            {
                if (Char.IsDigit(c) == false)
                {
                    result = false;
                }
            }

            if (temp.Length >= 10)
            {
                result = true;
            }

            return result;
        }
        // validates all digits
        public static bool IsAllDigits(string temp)
        {
            bool result = true;

            foreach (Char c in temp)
            {

                if (Char.IsDigit(c) == false)
                {
                    result = false;
                }
            }

            if (temp.Length < 5 || temp.Length > 5)
            {
                result = false;
            }
            return result;

        }

        public static bool IsFilled(string temp)
        {
            bool result = false;

            if (temp.Length > 1)
            {
                result = true;
            }

            else if (temp.Length < 0)
            {
                result = true;
            }
            return result;
        }
    }
}
