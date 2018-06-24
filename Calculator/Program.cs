using System;

namespace Calculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool running = true;
            Console.WriteLine("1)Add\n2)Subtract\n3)Multiply\n4)Divide");
            while(running){
                string choice = Console.ReadLine();
                if(choice == ("add") || choice == "1"){
                    Console.WriteLine("Answer: "+add());
                }else if(choice==("subtract")|| choice == "2"){
                    Console.WriteLine("Answer: " +subtract());
                }else if (choice==("multiply")|| choice == "3"){
                    Console.WriteLine("Answer: " +multiply());
                }else if (choice==("divide")|| choice == "4"){
                    Console.WriteLine("Answer: " +divide().ToString("#.###"));
                }else{
                    Console.WriteLine("INVALID CHOICE!");
                }

                Console.WriteLine("Perform another operation y/n?");
                choice = Console.ReadLine();
                if(choice == "y" || choice == "yes" || choice == "yea" || choice == "yeah"){
                    running = true;
                }else{
                    running = false;
                }
            }
        }

        public static int add(){
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            return num1 + num2;
        }
        public static int subtract()
        {
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            return num1 - num2;
        }
        public static int multiply()
        {
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            return num1 * num2;
        }
        public static double divide()
        {
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            return (num1 / num2);
        }
    }
}
