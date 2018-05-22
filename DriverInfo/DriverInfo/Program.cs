using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace DriverInform
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] driverslist = DriveInfo.GetDrives();
            foreach(DriveInfo d in driverslist)
            {
                Console.WriteLine("Drive {0}", d.Name);
                Console.WriteLine(" File type: {0}", d.DriveType);
                if(d.IsReady == true)
                {
                    Console.WriteLine(" Total size of drive: {0, 20} bytes ", d.TotalSize);
                    Console.WriteLine(" Remaining size of drive: {0, 15} bytes ", d.TotalFreeSpace);
                    Console.WriteLine(" Total size of drive: {0, 15} GB ", Math.Round(d.TotalSize / Math.Pow(10, 9),2));
                    Console.WriteLine(" Remaining size of drive: {0, 10} GB ", Math.Round(d.TotalFreeSpace / Math.Pow(10, 9),2) );

                  
                    Console.Read();
                }
            }
        }
    }
}
