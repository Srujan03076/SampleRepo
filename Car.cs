using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp059
{
    class Car
    {

 public void Drive()
        {
            Console.WriteLine("Driving");
        }
        public static void Brake()
        {
            Console.WriteLine("new message added");
        }
        static void Main(string[]args)
        {
            Car myobj = new Car();
            myobj.Drive();
            Brake();
            Console.Read();
        }
    }
}





  

