namespace cscsv.lexer;

public sealed class Lexer
{
    private StreamReader reader;
    private int lineCount;
    private int currentState;
    private String currentLexeme;

    public Lexer(String filepath)
    {
        this.reader = new StreamReader(filepath);
        this.lineCount = 0;
        this.currentState = 0;
        this.currentLexeme = "";
    }

    /*public Token getNextToken()*/
    /*{*/
    /**/
    /*}*/
}
