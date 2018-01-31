using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetDayInMonth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input year: ");
            string inputYear = Console.ReadLine();
            Console.WriteLine("Please input month: ");
            string inputMonth = Console.ReadLine();

            int year = int.Parse(inputYear);
            int month = int.Parse(inputMonth);
            int numberOfDays = 0;

            if (month > 0 && month <= 12 && year > 0)
            {
                switch (month)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12: numberOfDays = 31; break;
                    case 4:
                    case 6:
                    case 9:
                    case 11: numberOfDays = 30; break;
                    case 100: break;
                    case 2:
                        if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))    // nam nhuan
                            numberOfDays = 29;
                        else
                            numberOfDays = 28;
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Month {0} has {1} days", month, numberOfDays);
            }
            else
            {
                Console.WriteLine("Year or Month not valid");
            }
            Console.ReadLine();
        }
    }
}
