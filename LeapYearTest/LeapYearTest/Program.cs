using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* program determining if the year entered is a leap year
 * If it is divisible by 4 is a leap year
 * If it is divisible by 100 and also 400 then it is a leap year
 **/

namespace LeapYearTest
{
    class leapyear
    {
     
        static void Main(string[] args)
        {
            
            leapyear obj = new leapyear();
             
           
             obj.readdata();
                obj.leap();
                Console.ReadLine();
            
        }
        int y;
        public void readdata()
        {
            Console.WriteLine("Enter the year in four digits: ");
            y = Convert.ToInt32(Console.ReadLine());
        }
        public void leap()
        {
            if((y%4 == 0 && y % 100 != 0) || (y%400 == 0))
            {
                Console.WriteLine("{0} is a leap year", y);
               
            }
            else
            {
                Console.WriteLine("{0} is not a leap year", y);
               
            }
            Console.ReadLine();
        }
    }
}
