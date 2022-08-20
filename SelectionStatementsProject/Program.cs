using System;

namespace SelectionStatementsProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var randomNumber = random.Next();

            var userInput = int.Parse(Console.ReadLine());

            if (userInput > randomNumber)
            {
                Console.WriteLine("Too High!");
            }
            else if (userInput < randomNumber)
            {
                Console.WriteLine("Too Low!");
            }
            else
            {
                Console.WriteLine("..nevermind");
            }
        }
    }
}
