



using System;

namespace First_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome message
            Console.WriteLine("Welcome, This is a Basic Calculator");

            // Input first value
            Console.Write("Enter the first value: ");
            var value1 = Convert.ToDouble(Console.ReadLine());

            // Input operator
            Console.WriteLine("Enter an operator: + (Addition), - (Subtraction), * (Multiplication), / (Division)");
            string op = Console.ReadLine();
            op = op.ToLower();

            // Input second value
            Console.Write("Enter the second value: ");
            var value2 = Convert.ToDouble(Console.ReadLine());

            //If you want you can use IF/ELSE instead of Switch
            ///Calculate based on operator
            // if (op == "+" || op == "add")
            // {
            //     Console.WriteLine("The sum is = " + (value1 + value2));

            // }
            // else if (op == "-" || op == "sub")
            // {
            //     Console.WriteLine("The subtraction is = " + (value1 - value2));
            // }
            // else if (op == "*" || op == "mul")
            // {
            //     Console.WriteLine("The multiplication is = " + (value1 * value2));
            // }
            // else if (op == "/" || op == "div")
            // {
            //     Console.WriteLine("The Division is = " + (value1 / value2));
            // }
            // else {
            //     Console.WriteLine("You enter invalid operator!");
            //     Console.WriteLine("Valid operators (+, -, *, /)");

            // }


            //If you want you can choose switch instead of if else statements


            // Calculate based on operator
            switch (op)
            {
                case "+":
                case "add":
                    Console.WriteLine("The sum is = " + (value1 + value2));
                    break;
                case "-":
                case "sub":
                    Console.WriteLine("The subtraction is = " + (value1 - value2));
                    break;
                case "*":
                case "mul":
                    Console.WriteLine("The multiplication is = " + (value1 * value2));
                    break;
                case "/":
                case "div":
                    Console.WriteLine("The Division is = " + (value1 / value2));
                    break;
                default:
                    Console.WriteLine("You entered an invalid operator!");
                    Console.WriteLine("Valid operators are +, -, *, /");
                    break;
            }

            // Wait for user input before exiting
            Console.ReadLine();
        }
    }
}
