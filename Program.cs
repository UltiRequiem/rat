namespace rat
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var arg in args)
            {
                System.Console.Write(System.IO.File.ReadAllText(arg));
            }
        }
    }
}
