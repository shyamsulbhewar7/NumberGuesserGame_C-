using System;
using System.Collections.Generic;
using System.Text;

namespace NumberGuesserApp.Model
{
    public class NumberGuessGame
    {
        public void Play()
        {
            Console.WriteLine("Welcome to Guess Number Game");
            Random rnd = new Random();
            bool flag = true;
            do
            {
                int number = rnd.Next(0, 101);
                // this function includes first range value and excludes
                // end range value that why i gave 101 so it can generate from 1 to 100

                Console.WriteLine("You will be asked to Guess A Number To win The Game");

                int[] arr = new int[1000];
                int i = 0;
                while (true)
                {
                    Console.WriteLine("Enter a guess number between 1 to 100");
                    int inputNo = Convert.ToInt32(Console.ReadLine());
                    if (inputNo == number)
                    {
                        Console.WriteLine("Yayy! Your Guessed Number is Correct");
                        Console.WriteLine("The different tries you made during the game are : ");
                        int j = 0;
                        for (; j < i; j++)
                        {
                            Console.Write("{0}  ", arr[j]);
                        }

                        Console.WriteLine("\n Do you want to play again (Yes/No): enter y or n ");
                        string play = Console.ReadLine();
                        char v = play[0];
                        if (v == 'n')
                        {
                            flag = false;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("New game Started , All the best ");
                            break;
                        }
                    }
                    else if (inputNo > number)
                    {
                        Console.WriteLine("oops Sorry , Too high ");
                        arr[i++] = inputNo;
                    }
                    else
                    {
                        Console.WriteLine("oops Sorry , Too low");
                        arr[i++] = inputNo;
                    }
                }

            } while (flag);
        }

    }
}
