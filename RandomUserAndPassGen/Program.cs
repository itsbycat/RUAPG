using System;

namespace RandomUserAndPassGen
{
    class Program
    {
        class RandomStringGenerator
        {
            const string LOWER_CASE = "abcdefghijklmnopqursuvwxyz";
            const string UPPER_CAES = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string NUMBERS = "123456789";
            const string SPECIALS = @"!@£$%^&*()#€";

            public string RandomString(bool useLowercase, bool useUppercase, bool useNumbers, bool useSpecial,
                int stringSize)
            {
                char[] _password = new char[stringSize];
                string charSet = ""; // Initialise to blank
                System.Random _random = new Random();
                int counter;

                // Build up the character set to choose from
                if (useLowercase) charSet += LOWER_CASE;

                if (useUppercase) charSet += UPPER_CAES;

                if (useNumbers) charSet += NUMBERS;

                if (useSpecial) charSet += SPECIALS;

                for (counter = 0; counter < stringSize; counter++)
                {
                    _password[counter] = charSet[_random.Next(charSet.Length - 1)];
                }

                return String.Join(null, _password);
            }
        }
        static void Main(string[] args)
        {
            string username;
            string password;

            RandomStringGenerator randomUserGenerator = new RandomStringGenerator();
            RandomStringGenerator randomPasswordGenerator = new RandomStringGenerator();

            username = randomUserGenerator.RandomString(true, true, true, false, 16);
            password = randomPasswordGenerator.RandomString(true, true, true, false, 16);
            Console.WriteLine(username + ":" + password);
            Console.ReadKey();
        }
    }
}
