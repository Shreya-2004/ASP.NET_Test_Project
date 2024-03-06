using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_overloading
{
    internal class Program
    {
        public static void Main()
        {
            int Speed;
            string Color;
            

            Speed =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Speed is: " + Speed);
            Color =Console.ReadLine();
            Console.WriteLine("Color is: " + Color);
           
            //TwoWheeler twoWheelerObj = new TwoWheeler();

            //string InputSpeed = null;
            //Console.WriteLine("Enter Speed :");
            //InputSpeed = Console.ReadLine();
            //twoWheelerObj.SetSpeed(InputSpeed);
            //Console.WriteLine("Speed is: " + InputSpeed);

            //string InputColor = null;
            //Console.WriteLine("Enter Color :");
            //InputColor = Console.ReadLine();
            //twoWheelerObj.SetSpeed(InputColor);
            //Console.WriteLine("Color is: " + InputColor);


        }
      
    }
}
