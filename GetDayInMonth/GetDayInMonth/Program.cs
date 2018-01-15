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
            var y = Console.ReadLine();
            Console.WriteLine("Please input month: ");
            var m = Console.ReadLine();

            var isNumberMonth = int.TryParse(m, out int month);
            var isNumberYear = int.TryParse(m, out int year);
            int day = 0;
            if (isNumberMonth && isNumberYear && month >= 1 && month <= 12)
            {
                switch (month)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12: day = 31; break;
                    case 4:
                    case 6:
                    case 9:
                    case 11: day = 30; break;
                    case 100: break;
                    case 2:
                        if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))    // nam nhuan
                            day = 29;
                        else
                            day = 28;
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Month {0} has {1} days", month, day);
            }
            else
            {
                Console.WriteLine("Year or Month not valid");
            }
            Console.ReadLine();
        }
    }
}
