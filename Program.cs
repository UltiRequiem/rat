internal class Program
{
    /// <param name="args">The files to read</param>
    /// <param name="number">Print Numbers?</param>
    /// <param name="ShowEnds">Put an "$" at the End?</param>
    private static void Main(string[] args, bool number = false, bool ShowEnds = false)
    {
        if (args.Length == 0) PrintFromSTDIN();

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


        if (number) text = AddNumbers(text);

        if (ShowEnds) text = AddEnds(text);

        Console.Write(text);
    }

    public static void PrintFromSTDIN()
    {
        while (true) Console.WriteLine(Console.ReadLine());
    }

    public static string AddEnds(string text)
    {
        var splitText = text.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

        text = "";

        for (var i = 0; i < splitText.Length - 1; i++)
        {
            text += $"{splitText[i]}$ \n";
        }

        return text;
    }

    public static string AddNumbers(string text)
    {
        var splitText = text.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

        text = "";

        for (var i = 0; i < splitText.Length - 1; i++)
        {
            text += $"  {i}   {splitText[i]}\n";
        }

        return text;
    }
}
