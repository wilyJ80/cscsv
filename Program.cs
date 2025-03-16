namespace cscsv;

public sealed class Program
{
    public static void Main(String[] args)
    {

        if (args.Length == 0)
        {
            Console.Error.WriteLine("Usage: dotnet run filename.csv");
            return;
        }

        try
        {
            using var reader = new StreamReader(args[0]);

            while (reader.Peek() >= 0)
            {
                Console.Write((char)reader.Read());
            }
        }
        catch (IOException e)
        {
            Console.Error.WriteLine("Error: " + e.ToString());
        }
    }
}
