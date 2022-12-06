namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject?");
            var favSubject = Console.ReadLine();

            switch (favSubject.ToLower())
            {
              case "math":
                    Console.WriteLine("Math - Numbers are fun!");
                    break;
              case "writing":
                    Console.WriteLine("Writing - Don't turn into a grammar police!");
                    break;
              case "history":
                    Console.WriteLine("History - We're bound to repeat it if we don't learn it!");
                    break;
              case "science":
                    Console.WriteLine("Science - Will you be the next Enstein?");
                    break;
              case "reading":
                    Console.WriteLine("Reading - Everyone loves a good book!");
                    break;
              default:
                    Console.WriteLine($"Well that's a new one! I'm sure {favSubject} is fun!");
                    break;
            }
        }
    }
}