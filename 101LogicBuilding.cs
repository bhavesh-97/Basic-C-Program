using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace Basic_C__Program
{
    public class _101LogicBuilding
    {
       public _101LogicBuilding()
        {
            //1. Program to Print Integer Numbers Entered by the User
            //this.ReadNumber();

            //2. Write a Program to Find the Size of int, float, double, and char
            //this.FindsizeofDatatype();
            
            //3. Program to Find the Larger Number Among Two Numbers
            //this.FindLargestNumberfromTwoNumbers();
            
            //4. Program to Check Whether the Number is Odd or Even
            //this.FindOddNumber();

            //5. Program to Check Whether the Number is Divisible by 5:
            //this.CheckDivisibleBy5();

            //this.Swapnumber();

            //6. Program to Check Whether the Number is a Multiple of 7:
            //this.CheckMultipleof7();

            //7. Program to Calculate the Square and Cube of a Number:
            this.FindSquereandCube();

            //8.Program to Calculate the Area of a Circle and Triangle
            this.CalculateAreaofcircleandTriangle();
        }
        public void Swapnumber()
        {
            int a = 5; int b = 6;
            Console.WriteLine("Before Swape Value {0},{1}", a, b);
            a = (a + b) - (b = a);
            Console.WriteLine("Swaped Value {0},{1}", a, b);
        }
        public void ReadNumber()
        {
            //1. Program to Print Integer Numbers Entered by the User
            Console.WriteLine("Enter the number and see the magic:- ");
            int value = int.Parse(Console.ReadLine());
            Console.WriteLine("wow you entered {0} magical number", value);
        }
        public void FindsizeofDatatype()
        {
            //2. Write a Program to Find the Size of int, float, double, and char
            Console.WriteLine("Size of Int:- "+ sizeof(int));
            Console.WriteLine("Size of Float:- "+ sizeof(float));
            Console.WriteLine("Size of double:- "+ sizeof(double));
            Console.WriteLine("Size of char:- "+ sizeof(char));
        }

        public void FindLargestNumberfromTwoNumbers() {
            //3. Program to Find the Larger Number Among Two Numbers
            Console.WriteLine("Enter First Number:- ");
            int firstnum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number:- ");
            int secondnum = int.Parse(Console.ReadLine());

            if (firstnum > secondnum)
                   Console.WriteLine("Fisrt Number Is Large Number " + firstnum);
            else
                   Console.WriteLine("Second Number Is Large Number "+ secondnum);
        }
        public void FindOddNumber()
        {
            //4. Program to Check Whether the Number is Odd or Even
            Console.Write("Enter the number:- ");
            int value = int.Parse(Console.ReadLine());
            //if(Convert.ToInt32(value) % 2 == 0)
            if ((value & 1) == 0)
                Console.WriteLine("The number is Even");
            else
                Console.WriteLine("The number is Odd");
        }

        public void CheckDivisibleBy5()
        {
           //5. Program to Check Whether the Number is Divisible by 5:
           Console.Write("Enter the number:- ");
           int value = int.Parse(Console.ReadLine());
            if (value % 5 == 0)
                Console.WriteLine("The number is Divisible by 5");
           else
                Console.WriteLine("The number is Not Divisible by 5");
        }

        public void CheckMultipleof7()
        {
            //6. Program to Check Whether the Number is a Multiple of 7
            Console.Write("Enter a number: ");
            int value = int.Parse(Console.ReadLine());
            if(value % 7 == 0)
                Console.WriteLine("The number is a multiple of 7.");
            else
                Console.WriteLine("The number is NOT a multiple of 7.");
        }

        public void FindSquereandCube()
        {
            //7. Program to Calculate the Square and Cube of a Number:
            Console.Write("Enter a number: ");
            int value = int.Parse(Console.ReadLine());
            Console.WriteLine("Squre  is {0} and Cube is {1} number of {2}", Math.Pow(value, 2), Math.Pow(value, 3), value);
        }
        public void CalculateAreaofcircleandTriangle()
        {
            //8.Program to Calculate the Area of a Circle and Triangle
            Console.Write("Enter a Radius: ");
            int Radius = int.Parse(Console.ReadLine());
            Console.Write("Enter a Base: ");
            int basse = int.Parse(Console.ReadLine());
            Console.Write("Enter a Height: ");
            int height = int.Parse(Console.ReadLine());
            double circle = 3.14 * Radius * Radius;
            double triangle = (basse * height) / 2;
            Console.WriteLine("Area of Circle: " + circle);
            Console.WriteLine("Area of Triangle: " + triangle);
        }
    }
}
