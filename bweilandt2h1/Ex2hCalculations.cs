using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bweilandt2h1
{
    public class Ex2hCalculations
    {

        //DateCalc
        public static string DateCalc06(string strYear, string strMonth, string strDay)
        {
            string result = "Invalid Input";
            DateTime date;
            try
            {
                int year = Int32.Parse(strYear);
                int month = Int32.Parse(strMonth);
                int day = Int32.Parse(strDay);
                date = new DateTime(year, month, day);
                result = date.ToShortDateString();
            }
            catch { }

            return result;
        }
        public static string DateCalc07(string strDate)
        {
            string result = "Invalid Input";
            DateTime date;
            try
            {
                date = DateTime.Parse(strDate);
                result = date.ToShortDateString();
            }
            catch { }

            return result;
        }
        public static string DateCalc08(string strDate)
        {
            string result = "Invalid Input";
            DateTime date;
            DateTime.TryParse(strDate, out date);
            result = date.ToShortDateString();

            return result;
        }

        public static string DateCalc09(string strDateA, string strDateB)
        {
            string result = "Invalid Input";
            DateTime date;
            try
            {
                date = DateTime.Parse(strDateA);
                date = DateTime.Parse(strDateB);
                result = date.ToShortDateString();
            }
            catch { }

            return result;
        }

        public static string DateCalc10(string strDateA, string strDateB)
        {
            string result = "Invalid Input";
            DateTime date;
            try
            {
                date = DateTime.Parse(strDateA);
                date = DateTime.Parse(strDateB);
                result = date.ToShortDateString();
            }
            catch { }

            return result;
        }


        //StringCalc
        public static string StringCalc01(string s)
        {
            return "Not Implemented";
        }
        public static string StringCalc02(string s)
        {
            return "Not Implemented";
        }
        public static string StringCalc03(string s)
        {
            return "Not Implemented";
        }
        public static string StringCalc04(string s)
        {
            return "Not Implemented";
        }
        public static string StringCalc05(string s)
        {
            return "Not Implemented";
        }
        public static string StringCalc06(string s)
        {
            return "Not Implemented";
        }
        public static string StringCalc07(string s)
        {
            return "Not Implemented";
        }
        public static string StringCalc08(string s)
        {
            return "Not Implemented";
        }
        public static string StringCalc09(string s)
        {
            return "Not Implemented";
        }
        public static string StringCalc10(string s1, string s2, string s3)
        {
            return "Not Implemented";
        }
    }
}