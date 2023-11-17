namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the number guessing game!");
            Console.WriteLine("See if you can guess the right number!");
            Console.WriteLine("What is the answer to Life, The Universe, and Everything?");

            int theAnswer = 42;

            int userInput = int.Parse(Console.ReadLine());

            if(userInput < theAnswer)
            {
                Console.WriteLine("Too Low!");
            }
            else if(userInput > theAnswer)
            {
                Console.WriteLine("Too High!");
            }
            else
            {
                Console.WriteLine("Correct!");
            }
        }
    }
}
