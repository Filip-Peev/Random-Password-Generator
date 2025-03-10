using System.Text;

namespace RandomPasswordGenerator
{
    public static class RandomHelper
    {
        /// <summary>
        /// Generates a random string consisting of letters (uppercase and lowercase).
        /// </summary>
        /// 
        /// <remarks>
        /// This method ensures that the password is randomly generated each time it's called.
        /// </remarks>
        /// 
        /// <param name="length">The length of the random string to generate.</param>
        /// <returns>A random string of letters.</returns>
        public static string GenerateRandomLetters(int length)
        {
            const string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            Random random = new Random();
            StringBuilder result = new StringBuilder(length);

            for (int i = 0; i < length; i++)
            {
                int index = random.Next(letters.Length); // Get a random index from the letters string
                result.Append(letters[index]); // Append the random letter to the result
            }

            return result.ToString(); // Return the generated random string
        }

        /// <summary>
        /// Generates a random password consisting of letters (uppercase and lowercase) and numbers.
        /// </summary>
        /// 
        /// <remarks>
        /// This method ensures that the password is randomly generated each time it's called.
        /// </remarks>
        /// 
        /// <param name="length">The length of the random password to generate.</param>
        /// <returns>A random password with letters and numbers.</returns>
        public static string GenerateRandomLettersAndNumbers(int length)
        {
            const string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            StringBuilder result = new StringBuilder(length);

            for (int i = 0; i < length; i++)
            {
                int index = random.Next(characters.Length); // Get a random index from the characters string (letters + numbers)
                result.Append(characters[index]); // Append the random character to the result
            }

            return result.ToString(); // Return the generated random password
        }

        /// <summary>
        /// Generates a random password consisting of letters (uppercase and lowercase), numbers, and special characters.
        /// </summary>
        /// 
        /// <remarks>
        /// This method ensures that the password is randomly generated each time it's called.
        /// </remarks>
        /// 
        /// <param name="length">The length of the random password to generate.</param>
        /// <returns>A random password with letters, numbers, and special characters.</returns>
        public static string GenerateRandomLettersAndNumbersAndSpecialCharacters(int length)
        {
            const string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+-=[]{}|;:,.<>?";
            Random random = new Random();
            StringBuilder result = new StringBuilder(length);

            for (int i = 0; i < length; i++)
            {
                int index = random.Next(characters.Length); // Get a random index from the characters string (letters + numbers + special characters)
                result.Append(characters[index]); // Append the random character to the result
            }

            return result.ToString(); // Return the generated random password
        }
    }
}