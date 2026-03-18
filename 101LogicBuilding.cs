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
            #region Maths 
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

            //14 Write a Program to Check Whether a Character is a Vowel or Consonant
            //this.CheckVowel();

            //15. Write a Program to Find the ASCII Value of a Character
            //this.CharToANSCI();

            //22. Write a Program to Find the Largest Number Among Three Numbers
            //this.Largestnumber();

            //23. Write a Program to Check Whether a Year Entered by the User is a Leap Year:
            //this.LeapYear();

            // 24 Write a Program to Calculate the Sum of the First N Natural Numbers
            //this.SumofNNaturalnumber();

            //25. Factorial of a Number Using a For Loop
            //this.FactorialNumber();

            //26. Print Fibonacci Series
            //this.Fibonacciseries();

            //27. Write a Program to Find the GCD or HCF of Two Numbers
            //this.Find_GCD_HCF();

            //28. Amstrong Number or Not
            //this.AmstrongNumber();

            //29. Check Whether a Number is Prime or Not:
            this.PrimeNumber();

            #endregion Maths

            #region Star Patterns
            //16. Pattern 1: Sqaure
            //this.Pattern_Sqaure();

            //17. Pattern 2: Right-angled trinagle
            //this.Pattern_Right_angled_trinagle();

            //18. Pattern 3: Hallow Rectangle
            //this.Pattern_Hallow_Rectangle();

            //19. Pattern 4: Inverted Right-angled triangle
            //this.Pattern_Inverted_Right_angled_trinagle();

            //20. Pattern 5: traingle
            //this.Pattern_trinagle();

            //21. Pattern 6:  Inverted traingle
            //this.Pattern_Inverted_trinagle();
            #endregion Star Patterns
        }
        #region Maths 
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
        public void CharToANSCI()
        {
            //15. Write a Program to Find the ASCII Value of a Character
            Console.Write("Enter a character: ");
            char inputChar = Console.ReadKey().KeyChar;
            Console.WriteLine();

            // LOGIC: Subtracting the 'null' character ('\0') which has a value of 0.
            // This forces an implicit conversion to a numeric result.
            var asciiValue = inputChar - '\0';

            Console.WriteLine($"The ASCII value of '{inputChar}' is: {asciiValue}");
        }

        public void Largestnumber()
        {
            //22. Write a Program to Find the Largest Number Among Three Numbers
            Console.Write("Enter a first  number: ");
            int firstnumber = int.Parse(Console.ReadLine());
            Console.Write("Enter a Second number: ");
            int secondnumber = int.Parse(Console.ReadLine());
            Console.Write("Enter a Third number: ");
            int Thirdnumber = int.Parse(Console.ReadLine());
            
            if (firstnumber > secondnumber && firstnumber > Thirdnumber)
                Console.WriteLine($"{firstnumber} is largest number");
            else if (firstnumber < secondnumber && secondnumber > Thirdnumber)
                Console.WriteLine($"{secondnumber} is largest number");
            else
                Console.WriteLine($"{Thirdnumber} is largest number");
        }
        public void LeapYear()
        {
            //23. Write a Program to Check Whether a Year Entered by the User is a Leap Year:
            Console.Write("Enter a Year: ");
            int Year = int.Parse(Console.ReadLine());

            if ((Year % 4 == 0 && Year % 100 != 0) || (Year % 400 == 0))
                Console.WriteLine($"{Year} is Leap year");
            else
                Console.WriteLine($"{Year} is not Leap year");
        }
     
        public void SumofNNaturalnumber()
        {
            //24. Write a Program to Calculate the Sum of the First N Natural Numbers
            Console.Write("Enter a Number: ");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i <= num; i++)
            {
                sum += i;
            }

            Console.WriteLine($"The sum of the first {num} natural numbers is {sum}");
        }

        public void FactorialNumber()
        {
            //25. Factorial of a Number Using a For Loop
            Console.Write("Enter a Number: ");
            int num = int.Parse(Console.ReadLine());
            int fact = 1;

            for (int i = 1; i <= num; i++)
            {
                fact *= i;
            }

            Console.WriteLine($"Factorial oft {num} is {fact}");
        }

        public void Fibonacciseries()
        {
            //26. Print Fibonacci Series
            Console.Write("Enter a Number: ");
            int num = int.Parse(Console.ReadLine());
            int first = 0;
            int second = 1;

            Console.Write("Fibonacci series are ");
            for (int i = 1; i <= num; i++)
            {
                Console.Write(first + " ");
                int next = first + second;
                first = second;
                second = next;

            }
        }
        public void Find_GCD_HCF()
        {
            //27. Write a Program to Find the GCD or HCF of Two Numbers
            Console.Write("Enter a first  number: ");
            int firstnumber = int.Parse(Console.ReadLine());
            Console.Write("Enter a Second number: ");
            int secondnumber = int.Parse(Console.ReadLine());

            while(secondnumber != 0)
            {
                int temp = secondnumber;
                secondnumber = firstnumber % secondnumber;
                firstnumber = temp;
            }

            Console.WriteLine($"The GCD is {firstnumber}.");

        }

        public void AmstrongNumber()
        {
            //28. Amstrong Number or Not
            Console.Write("Enter a Number: ");
            string s = Console.ReadLine();
            int num = int.Parse(s);
            int n = s.Length;
            int sum = 0;
            int temp = num;

            while (temp > 0)
            {
                int digit = temp % 10;

                // withot pow method
                int power = 1;
                for(int i = 0; i < n; i++)
                {
                    power *= digit;
                }
                sum += power;

                //with pow method
                //sum += Math.Pow(digit, power);
                temp /= 10;
            }
            if (sum == num)
                Console.WriteLine("Armstrong Number");
            else
                Console.WriteLine("Not Armstrong");
        }

        public void PrimeNumber()
        {
            //29. Check Whether a Number is Prime or Not:
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            bool isPrime = true;
            if (num <= 1) isPrime = false;
            else if (num == 2) isPrime = true;
            else if (num % 2 == 0) isPrime = false;
            else
            {
                for (int i = 3; i * i <= num; i += 2)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            if (isPrime)
                Console.WriteLine($"{num} is Prime Number");
            else
                Console.WriteLine($"{num} is not Prime Number");
        }
        public void PrimeNumberSeries()
        {
            //30. Print Prime Numbers Within a Range
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            bool isPrime = true;
            if (num <= 1) isPrime = false;
            else if (num == 2) isPrime = true;
            else if (num % 2 == 0) isPrime = false;
            else
            {
                for (int i = 3; i * i <= num; i += 2)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            if (isPrime)
                Console.WriteLine($"{num} is Prime Number");
            else
                Console.WriteLine($"{num} is not Prime Number");
        }

        #endregion Maths

        #region Star Patterns
        public void Pattern_Sqaure()
        {
            //16. Pattern 1: Sqaure
            int n = 5;
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                    Console.Write('*');
                Console.WriteLine();
            }
        }
        public void Pattern_Right_angled_trinagle()
        {
            //17. Pattern 2: Right-angled trinagle
            int n = 5;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                    Console.Write('*');
                Console.WriteLine();
            }
        }
        public void Pattern_Hallow_Rectangle()
        {
            //18. Pattern 3: Hallow Rectangle
            int rows = 10;
            int cols = 20;

            for (int i = 1; i <= rows; i++)
            {
                for(int j = 1;  j <= cols; j++)
                {
                    if(i == 1 || i == rows ||  j == 1  ||  j == cols)
                        Console.Write('*');
                    else
                        Console.Write(' ');
                }
                Console.WriteLine();
            }
        }

        public void Pattern_Inverted_Right_angled_trinagle()
        {
            //19. Pattern 4: Inverted Right-angled triangle
            int n = 5;
            for (int i = 0; i <= n; i++)
            {
                for (int j = n; j > i; j--)
                    Console.Write("* ");
                Console.WriteLine();
            }
        }

        public void Pattern_trinagle()
        {
            //20. Pattern 5: traingle
            int n = 9;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                    Console.Write(" ");

                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");

                Console.WriteLine();
            }
        }

        public void Pattern_Inverted_trinagle()
        {
            //21. Pattern 6:  Inverted traingle
            int n = 9;
            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= n - i; j++)
                    Console.Write(" ");

                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");

                Console.WriteLine();
            }
        }

        #endregion Star Patterns
    }
}
