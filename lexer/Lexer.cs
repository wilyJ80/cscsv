namespace cscsv.lexer;

public sealed class Lexer
{
    private StreamReader reader { get; set; }
    private int lineCount { get; set; }
    private int currentState { get; set; }

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

    public bool fileStillHasCharactersLeft()
    {
        return reader.Peek() >= 0;
    }

    public Token getNextToken()
    {
        var token = new Token();

        return token;
    }
}
