using System;

namespace Calculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool running = true;
            Console.WriteLine("1)Add\n2)Subtract\n3)Multiply\n4)Divide");
            while (running)
            {
                int num1, num2;
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "add":
                    case "1":
                        init(out num1, out num2);
                        Console.WriteLine("Answer: " + (num1 + num2));
                        break;
                    case "subtract":
                    case "2":
                        init(out num1, out num2);
                        Console.WriteLine("Answer: " + (num1 + num2));
                        break;
                    case "multiply":
                    case "3":
                        init(out num1, out num2);
                        Console.WriteLine("Answer: " + (num1 + num2));
                        break;
                    case "divide":
                    case "4":
                        init(out num1, out num2);
                        Console.WriteLine("Answer: " + (num1 + num2));
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        continue;
                }

                Console.WriteLine("Perform another operation y/n?");
                choice = Console.ReadLine();
                if (choice == "y" || choice == "yes" || choice == "yea" || choice == "yeah")
                {
                    running = true;
                }
                else
                {
                    running = false;
                }
            }
        }

        public static void init(out int num1, out int num2)
        {
            Console.Write("Enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
        }
    }
}
