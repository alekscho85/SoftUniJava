﻿using System;
namespace _02.bonusScore
{
    class bonusScore
    {
        static void Main()
        {
            Console.Write("Enter your number: ");
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine(number * 10);
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine(number * 100);
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine(number * 1000);
                    break;
                default:
                    Console.WriteLine("invalid score");
                    break;
            }
        }
    }
}