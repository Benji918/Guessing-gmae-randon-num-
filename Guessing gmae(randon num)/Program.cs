namespace Guessing_gmae_randon_num_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 11);

            Console.WriteLine("Guess a number pls");
            string userInput = Console.ReadLine();
            int num;

            bool isNumber = int.TryParse(userInput, out num);
      

            if(isNumber)
            {
                if (num == randomNumber)
                {
                    Console.WriteLine("You guessed correctly");
                }
                else
                {
                    Console.WriteLine("Try again!!!");
                }
            }
            else
            {
                Console.WriteLine("You didn\'t enter an integer");
            }
        }
    }
}
