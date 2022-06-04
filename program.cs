using System;

namespace NumberGuessingGame {
    class Program {
        static void Main(String[] args) {
            Random r = new Random();

            int winNum = r.Next(1, 100);

            bool win = false;

            do {
                Console.Write("Guess a number inbetween 0 and 100: ");
                string s = Console.ReadLine();
                
                int i = int.Parse(s);

                if (i > winNum) {
                    Console.WriteLine("Too high! Guess lower....");
                } else if (i < winNum) {
                    Console.WriteLine("Too low! Guess higher....");
                } else if (i == winNum) {
                    Console.WriteLine("YOU WIN!");
                    win = true;
                }
            } while (win == false);
        }
    }
}