namespace cscsv.lexer;

public sealed class Token
{
    private TokenType tokenType { get; set; }
    private String? lexeme { get; set; }

    public Token(TokenType tokenType, String lexeme)
    {
        this.tokenType = tokenType;
        this.lexeme = lexeme;
    }
}
