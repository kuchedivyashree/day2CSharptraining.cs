using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class myapplication
    {
        static void Main(string[] args)
        {
            // find the greatest of three numbers
            int num1, num2, num3;
            //set the value of three numbers
            num1 = 10;
            num2 = 20;
            num3 = 50;
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("num1 is the largest!");

                }
                else
                {
                    Console.Write("num3 is the largest!");
                }
            }
            else if (num2 > num3)
                Console.Write("num2 is the largest!");
            else
                Console.Write("num3 is the largest!");
            Console.ReadLine();



            //program to  swap 2numbers without 3rd variable
            int a = 5, b = 10;
            Console.Write("before swap a=" + a + "b=" + b);
            a = a * b;
            b = a / b;
            a = a / b;
            Console.Write("After swap a=" + a + "b=" + b);
            Console.ReadLine();


            //program to get emp details and display them
            string name, add, city;
            int empID, age;
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("employee ID: ");
            empID = int.Parse(Console.ReadLine());
            Console.Write("address: ");
            add = Console.ReadLine();
            Console.Write("city: ");
            city = Console.ReadLine();
            Console.Write("age: ");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("below are the details of{0}:", name);
            Console.WriteLine("employee id: " + empID);
            Console.WriteLine("age: " + age);
            Console.WriteLine("address: "   +add);
            Console.WriteLine("city: " + city);
            Console.ReadLine();



            //switchcase:calculator program
            int n1;
            int n2;
            string operand;
            float answer;

            Console.WriteLine("please enter the first integer: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter an operand(+,-,/,*): ");
            operand = Console.ReadLine();
            Console.WriteLine("please enter the second integer: ");
            n2 = int.Parse(Console.ReadLine());

            switch (operand)
            {
                case "-":
                    answer = n1 - n2;
                    break;
                case "+":
                    answer = n1 + n2;
                    break;
                case "/":
                    answer = n1 / n2;
                    break;
                case "*":
                    answer = n1 * n2;
                    break;
                default:
                    answer = 0;
                    break;
            }
            Console.WriteLine(n1.ToString() + " " + operand + " " + n2.ToString() + " = " + answer.ToString());
            Console.ReadLine();

            ////looping:calculate the sum of n natural number

            int j, sum = 0;

            Console.Write("\n\n");
            Console.Write("find the sum of n natural numbers \n:");
            Console.Write("_________________________________ ");
            Console.Write("\n\n");

            Console.Write("the n natural numbers are:\n");
            for (j = 1; j <= 10; j++)
            {
                sum = sum + j;
                Console.Write("{0} ", j);
            }
            Console.Write("\n the sum is: {0}\n", sum);
            Console.ReadLine();


        }
    }
}

       
        
        
    



