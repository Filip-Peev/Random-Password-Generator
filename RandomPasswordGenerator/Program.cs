using RandomPasswordGenerator;

namespace RandomNumberGenerator
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine();

            Console.WriteLine("How many times to generate: ");
            int times = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("How long of a password to generate: ");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Here are " + times + " random passwords:");
            Console.WriteLine();

            for (int i = 0; i < times; i++)
            {
                // Use the GenerateRandomLetters method
                Console.ForegroundColor = ConsoleColor.DarkRed; // Set color for letters-only output
                string randomLetters = RandomHelper.GenerateRandomLetters(length);
                Console.WriteLine($"Only Letters:\t {randomLetters}");

                // Use the GenerateRandomPassword method
                Console.ForegroundColor = ConsoleColor.Blue; // Set color for letters and numbers output
                string randomLettersAndNumbers = RandomHelper.GenerateRandomLettersAndNumbers(length);
                Console.WriteLine($"And Numbers:\t {randomLettersAndNumbers}");

                // Use the GenerateRandomComplexPassword method
                Console.ForegroundColor = ConsoleColor.Green; // Set color for complex password output
                string randomLettersAndNumbersAndSpecialCharacters = RandomHelper.GenerateRandomLettersAndNumbersAndSpecialCharacters(length);
                Console.WriteLine($"And Specials:\t {randomLettersAndNumbersAndSpecialCharacters}");

                Console.WriteLine();
            }
            Console.ResetColor(); // Reset the color to default
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press Any Key To Close...");
            Console.ReadKey();
        }
    }
}