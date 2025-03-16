namespace cscsv.lexer;

public sealed class Lexer
{
    private StreamReader reader { get; set; }
    private int lineCount { get; set; }
    private int currentState { get; set; }
    public Token currentToken { get; private set; }

    public Lexer(String filepath)
    {
        if (!File.Exists(filepath))
        {
            throw new FileNotFoundException($"Error: file not found = {filepath}");
        }

        this.reader = new StreamReader(filepath);
        this.lineCount = 0;
        this.currentState = 0;
        this.currentToken = new Token();
    }

    public bool fileStillHasCharactersLeft()
    {
        return reader.Peek() >= 0;
    }

    public void throwMalformedTokenException(String lexeme)
    {
        throw new Exception($"Malformed token on line {lineCount}: {lexeme}");
    }

    public Token getNextToken()
    {
        return this.currentToken;
    }
}
