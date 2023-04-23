namespace TimesTableTester.Services;

public class TimesTableTestService : ITimesTableTestService
{
    private static readonly Random Random = new();
    
    public int GenerateMultiplier(int maxRange = Constants.MaxMultiplier)
    {
        return Random.Next(1, maxRange + 1);
    }

    public void RunSingleTableTest()
    {
        Console.WriteLine("Enter the table for the test: ");
        var tableNumber = int.Parse(Console.ReadLine());

        DisplayTable(tableNumber);
        
        var score = 0;
        var totalQuestions = 20;
        
        for (var questionNumber = 0; questionNumber < totalQuestions; questionNumber++)
        {
            var multiplier = GenerateMultiplier();
            
            var outputQuestion = $"What is {multiplier} x {tableNumber}? ";
            
            Console.WriteLine(outputQuestion);

            var answer = Console.ReadLine();

            var numeric = int.Parse(answer);
            
            if (numeric == multiplier * tableNumber)
            {
                Console.Write("CORRECT! :-)\n");
                score++;
            }
            else
            {
                Console.Write("INCORRECT! :-(\n");
            }
        }
        
        Console.WriteLine($"You scored {score} out of {totalQuestions}!");
    }

    private void DisplayTable(int tableNumber)
    {
        Console.WriteLine($"Read your {tableNumber} times table aloud before starting...");
        
        for (var multiplier = 1; multiplier <= 12; multiplier++)
        {
            Console.WriteLine($"{multiplier} X {tableNumber} is {multiplier * tableNumber}");
            Thread.Sleep(2000);
        }
    }
}
