using System;

namespace ParseCalcTDD
{
    class Program
    {
        static void Main(string[] args)
        {
            double Val1 = 0;
            double Val2 = 0;

            try
            {
                Console.Write("Enter your first value: ");
                Val1 = double.Parse(Console.ReadLine());
                Console.Write("Enter your second value: ");
                Val2 = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Something went wrong with your inputs. Please press any key to exit.");
                Console.ReadKey();
            }

            double Add = Val1 + Val2;
            double Sub = Val1 - Val2;
            double Mul = Val1 * Val2;
            double Div = Val1 / Val2;

            Console.WriteLine(Val1 + " + " + Val2 + " = " + Add);
            Console.WriteLine(Val1 + " - " + Val2 + " = " + Sub);
            Console.WriteLine(Val1 + " * " + Val2 + " = " + Mul);
            Console.WriteLine(Val1 + " / " + Val2 + " = " + Div);

        }
        
    }
}
