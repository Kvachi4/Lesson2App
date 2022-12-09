using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2App
{
  
    internal class Program
    {
             public static int MyArray()
             {
                int[] arrays = new int[10] { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };

                int arraySum = arrays[0] + arrays[9];
                 return arraySum;

             }

          public static void PlusNumbers()
        {
            int x = 10;
            int y = 15;
            int sum = x + y;
            Console.WriteLine($"ori ricxvis jam aris : {sum}");
        }

        public static double AddDouble()
        {
             Console.WriteLine("Choose your first double");
             double a = Convert.ToDouble(Console.ReadLine());

             Console.WriteLine("Choose your second double");
             double b = Convert.ToDouble(Console.ReadLine());
             double c = a + b;
            return c;
        }

        static void Main(string[] args)
        {
             PlusNumbers(); //სავარჯიშო 1
            
            Console.Beep();
            Console.Title = "Lesson2App";
            Console.WriteLine("-----------------------------------------------\n");

            
            Console.WriteLine( "Sum of arrays first and last index is " + Program.MyArray()); //სავარჯიშო 2
            Console.WriteLine("----------------------------------------------- \n");

            
            Console.WriteLine($"Double Sum is : {AddDouble()}");  //სავარჯიშო 3
            Console.WriteLine("-----------------------------------------------\n");


            BodyMassIndex.BmiCalculate();//სავარჯიშო 4
            Console.WriteLine("-----------------------------------------------\n");

            Console.ReadKey();
        }
    }
}
