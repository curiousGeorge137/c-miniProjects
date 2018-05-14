using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayCounter
{
    class Program
    {
        class dayCalculator {



            static void Main(string[] args)
            {
                dayCalculator obj = new dayCalculator();
                obj.startDate();

            }

            int sy, sm, sday, ey, em, eday;
            public void startDate()
            {

                Console.WriteLine("Enter the start date : Year(4 digts) Month(2 digits) day (2 digits)");
                var starting = Console.ReadLine();
                sy = Convert.ToInt32( starting.Split(' ')[0]);
                sm = Convert.ToInt32(starting.Split(' ')[1]);
                sday = Convert.ToInt32(starting.Split(' ')[2]);
                DateTime sd = new DateTime(sy, sm, sday);
                Console.WriteLine(sd);

                Console.WriteLine("Enter the end date : Year(4 digts) Month(2 digits) day (2 digits)");
                var end = Console.ReadLine();
                ey = Convert.ToInt32(end.Split(' ')[0]);
                em = Convert.ToInt32(end.Split(' ')[1]);
                eday = Convert.ToInt32(end.Split(' ')[2]);
                DateTime endDate = new DateTime(ey, em, eday);
                Console.WriteLine(endDate);

                Console.WriteLine("there are {0} days between " + sd + " and " + endDate, 
                    ((endDate - sd) > (sd- endDate) ? endDate-sd : sd-endDate ));
                Console.ReadLine();

            }
        }
    }
}


/* sy = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Enter the start month in 2 digits: ");
 sm = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Enter the start day in 2 digits: ");
 sday = Convert.ToInt32(Console.ReadLine());
 DateTime sd = new DateTime(sy, sm, sday);

 Console.WriteLine("Enter the end year in 4 digits: ");
 sy = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Enter the end month in 2 digits: ");
 sm = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Enter the end day in 2 digits: ");
 sday = Convert.ToInt32(Console.ReadLine());
 DateTime ed = new DateTime(sy, sm, sday);
 */
