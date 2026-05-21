using System;
using System.Text;

namespace StringGenerator
{

    public class Controller
    {
        private string chars;

        public Controller(string chars)
        {
            this.chars = chars;
        }

        public string Generate(int seed, int length = 16)
        {
            Random rng = new Random(seed);

            StringBuilder result = new StringBuilder(length);

            for (int i = 0; i < length; i++)
            {
                int index = rng.Next(chars.Length);
                result.Append(chars[index]);
            }

            return result.ToString();
        }
    }
}