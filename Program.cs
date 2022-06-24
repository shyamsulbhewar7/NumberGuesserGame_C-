using NumberGuesserApp.Model;
using System;

namespace NumberGuesserApp
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberGuessGame player = new NumberGuessGame();
            player.Play();
        }
    }
}
