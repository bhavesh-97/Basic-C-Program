using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace Basic_C__Program
{
    public class _101LogicBuilding
    {
       public _101LogicBuilding(){
            //this.ReadNumber();
            //this.FindsizeofDatatype();
            this.FindLargestNumberfromTwoNumbers();
        }
        public void ReadNumber()
        {
            //1. Program to Print Integer Numbers Entered by the User
            Console.WriteLine("Enter the number and see the magic:- ");
            string value = Console.ReadLine();
            Console.WriteLine("wow you entered {0} magical number", Convert.ToInt32(value));
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
            string firstnum = Console.ReadLine();
            Console.WriteLine("Enter Second Number:- ");
            string secondnum = Console.ReadLine();
            
            if (Convert.ToInt32(firstnum) > Convert.ToInt32(secondnum))
                   Console.WriteLine("Fisrt Number Is Large Number " + firstnum);
            else
                   Console.WriteLine("Second Number Is Large Number "+ secondnum);
        }
        public void FindOddNumber()
        {
            //4. Program to Check Whether the Number is Odd or Even
            Console.WriteLine("Enter the number:- ");
            string value = Console.ReadLine();

        }
    }
}
