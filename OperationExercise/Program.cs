using System;

namespace OperationExercise
{
    class Program { 

    public static double AreaOfCircle(double r)
    {
            return Math.PI * Math.Pow(r, 2);
        }


        static void Main(string[] args)
        {
            //Exercise 1//

            int a;
            int b;
            string one = "Choose a number: ";
            string two = "Choose another number: ";

            //addition block
            try
            {
                Console.Write(one);
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write(two);
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{a}+{b} is {a + b}.");
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            //subtraction block
            try
            {
                Console.Write("\n" + one);
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write(two);
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{a}-{b} is {a - b}.");
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            //multiplication block
            try
            {
                Console.Write("\n" + one);
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write(two);
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{a}*{b} is {a * b}.");
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            //division with remainder block
            try
            {
                Console.Write("\n" + one);
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write(two);
                b = Convert.ToInt32(Console.ReadLine());
                int quotient = a / b;
                int remainder = a % b;

                Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}.");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        
            Console.ReadLine();

            //----------------------------------------------------//

            //Exercise 2
        
            Console.Write("What is the radius of your circle? ");
            var radius = double.Parse(Console.ReadLine());
            var area = AreaOfCircle(radius);

            Console.WriteLine($"The area of your circle with a radius of {radius} is {area}");

            Console.ReadLine();


        }
    }
}

