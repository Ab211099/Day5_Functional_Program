﻿namespace Basic_core_programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello welcome to Basic Core Programs");
            Console.WriteLine("Enter the program number \n 1.Flip coin \n 2.Leap year" +
                "\n 3. Find Power Of Two");
            int proramCheck = Convert.ToInt32(Console.ReadLine());

            switch (proramCheck)
            {
                case 1:
                    Flip_Coin.GetFlipCoin();
                    break;   
                case 2:
                    Leap_year.FindleapYear();
                    break;
                case 3:
                    Power_of_two.FindPowertwo();
                    break;
            }
            
        }
    }
}