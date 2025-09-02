using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace Lesson_2_NCD25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // for loop
            Console.WriteLine("Counting from 1 to 5.");

            for (int i = 1; i <= 5; i++) //startvärde : vilkor : förändring (++ för ökning, -- för minskning)
            {
                Console.WriteLine(i);
            }
            */

            /*
            //while loop
            Console.WriteLine("Counting from 1 to 5.");

            int i = 1;
            while (i <= 5) //tar alltid in en parameter, true eller false
            {
                Console.WriteLine(i);
                i++;
            }
            */

            /*
            //array = en form av lista
            string[] listOfFruits = { "Apple", "Banana", "Orange"};
            int[] favNumber = { 1, 3, 13, 14 };
            Console.WriteLine(listOfFruits[1]);
            Console.WriteLine(favNumber[3]);
            */

            /*
            //foreach loop
            int[] favNum = { 1, 3, 13, 14 };
            string[] fruitList = { "Apple", "Banana", "Orange" };
            foreach(int number in favNum)
            {
                Console.WriteLine(number);
            }

            foreach(string fruit in fruitList)
            {
                Console.WriteLine(fruit);
            }
            */

            /*
            string[] fL = { "Apple", "Banana", "Orange" };
            int[] num = { 3, 13, 14 };

            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }
            */


            //Calculator with if & methods
            Console.WriteLine("Enter first number");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose an operator (+ : - : * : /)");
            string op = Console.ReadLine();

            if (op == "+")
            {
                Add(a, b);
            }
            else if (op == "-")
            {
                Sub(a, b);
            }
            else if (op == "*")
            {
                Mult(a, b);
            }
            else if (op == "/")
            {
                Div(a, b);
            }



        }

        static void Add(int a, int b) 
        {
            int sum = a + b;
            Console.WriteLine($"The sum is {sum}");
        }

        static void Sub(int a, int b)
        {
            int sum = a - b;    
            Console.WriteLine($"The sum is {sum}");
        }

        static void Mult(int a, int b)
        {
            int sum = a * b;
            Console.WriteLine($"The sum is {sum}");
        }

        static void Div(int a, int b)
        {
            int sum = a / b;
            Console.WriteLine($"The sum is {sum}");
        }
    }
}
