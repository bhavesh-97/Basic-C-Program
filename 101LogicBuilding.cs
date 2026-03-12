using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            //this.FindSquereandCube();

            //8.Program to Calculate the Area of a Circle and Triangle
            //this.CalculateAreaofcircleandTriangle();

            //9. Write a Program to Find the Quotient and Remainder of Two Integers:
            //this.FindQuotientandRemainder();

            //10. Print the Multiplication Table of a Given Number
            //this.GenerateMultiplicationTable();

            //11.Write a Program to Make a Simple Calculator Using a Switch Case
            //this.Calculator();

            //12. Print a Number in Reverse Order
            //this.ReverseInt();

            //13. Calculate the Sum of Digits of a Given Number
            //this.SumofDigits();

            // 14 Write a Program to Check Whether a Character is a Vowel or Consonant
            this.CheckVowel();
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

        public void FindQuotientandRemainder()
        {
            // 9. Write a Program to Find the Quotient and Remainder of Two Integers:
            Console.Write("Enter a Dividend: ");
            int Dividend = int.Parse(Console.ReadLine());
            Console.Write("Enter a Divisor: ");
            int Divisor = int.Parse(Console.ReadLine());
            int quotient = Dividend / Divisor;  
            int remainder = Dividend % Divisor;
            Console.WriteLine("Quotient: " + quotient);
            Console.WriteLine("Remainder: " + remainder);
        }
        public void GenerateMultiplicationTable()
        {
            //10. Print the Multiplication Table of a Given Number
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} * {i} = {number * i}");
            }
        }
        public void Calculator()
        {
            //11.Write a Program to Make a Simple Calculator Using a Switch Case
            Console.Write("Enter a first  number: ");
            int firstnumber = int.Parse(Console.ReadLine()); 
            Console.Write("Enter a Operator: ");
            string operatoor = Console.ReadLine();
            Console.Write("Enter a Second number: ");
            int secondnumber = int.Parse(Console.ReadLine());

            switch (operatoor)
            {
                case "+":
                    Console.WriteLine($"{firstnumber} + {secondnumber} = {firstnumber + secondnumber}");
                    break;
                case "-":
                    Console.WriteLine($"{firstnumber} - {secondnumber} = {firstnumber - secondnumber}");
                    break;
                case "*":
                    Console.WriteLine($"{firstnumber} * {secondnumber} = {firstnumber * secondnumber}");
                    break;
                case "/":
                    Console.WriteLine($"{firstnumber} / {secondnumber} = {firstnumber / secondnumber}");
                    break;
                default:
                    Console.WriteLine("Please Enter Valid Operator (+,-,*,/)");
                    break;
            }
          }

        public void ReverseInt()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int reverse = 0;
            int sign = number > 0 ? 1 : -1;
            while (number > 0)
            {
                int d = number % 10;
                reverse = reverse * 10 + d;
                number /= 10;
            }
            Console.WriteLine("Reverse Number is " + reverse*sign);
        }
        public void SumofDigits()
        {
            //13. Calculate the Sum of Digits of a Given Number
            Console.Write("Enter a number at least 2 digits: ");
            int number = int.Parse(Console.ReadLine());
            int sumofDigits = 0;
            while(number > 0)  {
                int d = number % 10;
                sumofDigits += d;
                number /= 10;
            }
            Console.WriteLine("Sum of Digits: "+ sumofDigits);
        }
        public void CheckVowel() 
        {
            // 14 Write a Program to Check Whether a Character is a Vowel or Consonant
            Console.Write("Enter a single character: ");
            string value = Console.ReadLine();
            char chr = value[0];
            Console.WriteLine($"You entered: {chr}");
            var vowelvalue = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
            if (vowelvalue.Contains(chr))
                Console.WriteLine("Vowel");
            else
                Console.WriteLine("Not a vowel");
        }
    }
}
