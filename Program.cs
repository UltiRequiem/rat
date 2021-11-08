using System;
using System.IO;


namespace rat
{
    internal static class Program
    {
        /// <param name="args">The files to read</param>
        /// <param name="number">Print Numbers?</param>
        /// <param name="showEnds">Put an "$" at the End?</param>
        private static void Main(string[] args, bool number = false, bool showEnds = false)
        {
            if (args.Length == 0)
            {
                while (true)
                {
                    Console.WriteLine(Console.ReadLine());
                }
            }

            string text = "";

            foreach (string file in args)
            {
                try
                {
                    text += File.ReadAllText(file);
                }
                catch (System.IO.FileNotFoundException)
                {
                    Console.WriteLine($"{file} file not found!");
                    return;
                }
            }


            if (number)
            {
                var splitText = text.Split(new[] {Environment.NewLine}, StringSplitOptions.None);
                text = "";

                for (var i = 0; i < splitText.Length - 1; i++)
                {
                    text += $"  {i}   {splitText[i]}\n";
                }
            }

            if (showEnds)
            {
                var splitText = text.Split(new[] {Environment.NewLine}, StringSplitOptions.None);
                text = "";

                for (var i = 0; i < splitText.Length - 1; i++)
                {
                    text += $"{splitText[i]}$ \n";
                }
            }

            Console.Write(text);
        }
    }
}