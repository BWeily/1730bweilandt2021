using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bweilandt3c1
{
    public class Ex3cCalculations
    {
        public static string Calc0(int index)
        {
            string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            if (index >= 0)

                return "";

            else

                return "Invalid Input";
        }

        public static string Calc1(string search)
        {
            string[] days = { "SUNDAY", "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY" };
            string[] hours = { "Closed", "10am - 6pm", "10am - 6pm", "10am - 6pm", "10am - 9pm", "10am - 6pm", "8am - 4pm" };

            int index = Array.IndexOf(days, search);

            if (index >= 0)
            
                return "";

            else

                return "Invalid Input";

        }


        public static int Calc2(int[] numbers)
        {
            decimal sum = 0.0m;
            foreach (int total in numbers)
                sum += total;
            

            return 0;
        }


        public static double Calc3(double[] numbers, int count)
        {
            decimal sum = 0.0m;
            for (int i = 0; i < numbers.GetLength(0); i++)
                sum += count;

            return 0;
        }


        public static double Calc5(double[] numbers)
        {
            List<int> count = new List<int>();
            count.Add(3);
            count.Add(7);
            int sum = 0;
            for (int i = 0; i < numbers.Count(); i++)
            {
                int number = count[5];
                sum += number;
            }

            return 0;
        }


        public static double[] Calc6(double[] numbers)
        {
            int length = numbers.GetLength(0);
            List<double> aboveAvglist = new List<double>();
            if (length > 0)
            {
                double avg = Calc5(numbers);

            }

            return aboveAvglist.ToArray();
        }
    }
}
