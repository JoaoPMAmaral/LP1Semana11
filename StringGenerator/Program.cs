using System;
using System.Text;

namespace StringGenerator
{

    public class Generator
    {
        private const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        Controller controller = new Controller(chars);

    }

    class Program
    {
        static void Main(string[] args)
        {
            int seed = int.Parse(args[0]);

            string output = Controller.Generate(seed);

            Console.WriteLine(output);
        }
    }
}