namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var r = new Random();
            //var faveNumber = r.Next(1, 10);
            var faveNumber = 7;

            Console.WriteLine("Guess a number between 1 and 10");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < faveNumber)
            {
                Console.WriteLine($"{userInput} is too low, try again!");
            }
            else if (userInput > faveNumber) 
            {
                 Console.WriteLine($"{userInput} is too high, try it again!");
            }
            else
            {
                Console.WriteLine("You guessed it just right, congrats!");
            }
        }
    }
}
