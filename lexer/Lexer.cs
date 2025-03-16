namespace cscsv.lexer;

public sealed class Lexer
{
    private StreamReader reader;
    private int lineCount;
    private int currentState;

    public Lexer(String filepath)
    {
        if (!File.Exists(filepath))
        {
            throw new FileNotFoundException($"Error: file not found = {filepath}");
        }

        this.reader = new StreamReader(filepath);
        this.lineCount = 0;
        this.currentState = 0;
    }

    public Token getNextToken()
    {
        var token = new Token();

        while (reader.Peek() >= 0)
        {
            Console.Write((char)reader.Read());
        }

        return token;
    }
}
