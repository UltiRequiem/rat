using System;
using System.IO;


namespace rat
{
    class Program
    {
        /// <param name="args">The files to read</param>
        /// <param name="number">Print Numbers?</param>
        /// <param name="showEnds">Put an "$" at the End?</param>
        static void Main(string[] args, bool number = false, bool showEnds = false)
        {

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

                string[] splitedText = text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                text = "";

                for (int i = 0; i < splitedText.Length - 1; i++)
                {
                    text += $"  {i}   {splitedText[i]}\n";
                }
            }

            if (showEnds)
            {
                string[] splitedText = text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                text = "";

                for (int i = 0; i < splitedText.Length - 1; i++)
                {
                    text += $"{splitedText[i]}$ \n";
                }
            }

            Console.Write(text);
        }
    }
}
