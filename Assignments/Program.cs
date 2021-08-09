﻿using System;

namespace Assginments
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int choice;
                Console.Write("Type 1: For Word Frequency Problem.\n" +
                              "Enter Your Choice: ");

                choice = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n");

                switch (choice)
                {
                    case 1:
                        WordFrequency.WordFrequencyCaller();
                        break;
                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

    }
}