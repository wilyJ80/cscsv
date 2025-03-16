namespace cscsv;

using cscsv.lexer;

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
            var lexer = new Lexer(args[0]);
        }
        catch (FileNotFoundException e)
        {
            Console.Error.WriteLine(e.Message);
            return;
        }
        catch (Exception e)
        {
            Console.Error.WriteLine(e.Message);
            return;
        }
    }
}
