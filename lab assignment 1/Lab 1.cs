using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal l, w;
            decimal area;
            decimal peri;

            string willContinue = "y";
            Console.WriteLine("Hello User, welcome to Grand Circus room detail generator!");
            Console.WriteLine("");
            while (willContinue == "y")

            {
                Console.Write("Enter the length of the Rectangle: ");
                l = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Enter the width of the Rectangle: ");
                w = Convert.ToDecimal(Console.ReadLine());
                area = l * w;
                peri = 2 * (l + w);
                Console.WriteLine("The area of the Rectangle is = {0} and the perimeter is ={1}", area, peri);
                Console.WriteLine("Would you like to continue? (y/n) ");
                willContinue = Console.ReadLine();
            }
            Console.WriteLine("Thank you for measuring our Grand Circus Rooms!");
            Console.WriteLine("Good Bye!");
        }
    }
}