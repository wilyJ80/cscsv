namespace cscsv.lexer;

public sealed class Token
{
    public TokenType tokenType { get; set; }
    public String? lexeme { get; set; }

    public Token()
    {
        this.tokenType = TokenType.NON_ACCEPTING;
        this.lexeme = "";
    }
}
