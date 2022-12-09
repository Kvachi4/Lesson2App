using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2App
{
    public static class BodyMassIndex
    {
        static float height;
        static float weight;

        public static void BmiCalculate()
        {
            Console.WriteLine("What is your name?");
            string myName = Console.ReadLine();

            Console.WriteLine("What is your lastname?");
            string mylastName = Console.ReadLine();

            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Please Write What is your Height in Metric?");
            float myHeight = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Please Write What is your Weight in kilogram?");
            float myWeight = Convert.ToSingle(Console.ReadLine());

            
            float bmi = myWeight/(myHeight * myHeight);
         

            height = myHeight;
            weight = myWeight;

            Console.WriteLine("your name is : "  + myName + " " + mylastName );
            Console.WriteLine($"Your age is {age}");
            Console.WriteLine($"Your Body Mass index is : {Math.Round(bmi)} \n");

            if (bmi <25)
            {
                Console.WriteLine("You have Normal weight");
            }
            else if(bmi >=25 && bmi <= 30)
            {
                Console.WriteLine("You have overweight");
            }
            else if (bmi > 30 && bmi <= 40)
            {
                Console.WriteLine("You have Obesity");
            }
            else if (bmi > 40)
            {
                Console.WriteLine("You have Morbid Obesity");
            }
            else
            {
                Console.WriteLine("something went wrong");  
            }
        }
    }
}
