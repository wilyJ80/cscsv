namespace cscsv.lexer;

public sealed class Lexer
{
    private StreamReader reader { get; set; }
    private int lineCount { get; set; }
    private int currentState { get; set; }
    public Token currentToken { get; private set; }
    private TransitionTable transitionTable;

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
        this.transitionTable = new TransitionTable();
    }

    public bool fileStillHasCharactersLeft()
    {
        return reader.Peek() >= 0;
    }

    public void throwMalformedTokenException(Token token)
    {
        throw new Exception($"Malformed token on line {lineCount}: {token.lexeme}");
    }

    public Token getNextToken()
    {
        Int32 ch = this.reader.Peek();

        if ((char)ch == '\n')
        {
            this.lineCount++;
        }

        bool foundTransition = false;

        for (int possibleTransition = 0; possibleTransition < transitionTable.table[currentState].Length; possibleTransition++)
        {
            if (transitionTable.table[currentState][possibleTransition].charTesterCallback((char)ch))
            {
                foundTransition = true;
                currentToken.tokenType = transitionTable.table[currentState][possibleTransition].tokenType;

                bool tokenWasBuilt = false;

                if (currentToken.tokenType == TokenType.NON_ACCEPTING)
                {
                    currentToken.lexeme += (char)ch;
                }
                else if (transitionTable.table[currentState][possibleTransition].isOther == IsOther.IS_OTHER && (char)ch != '\n')
                {
                    // unread character back to stream: not possible with current logic. needs peeking instead of reading
                    tokenWasBuilt = true;
                }

                if (tokenWasBuilt)
                {
                    return currentToken;
                }

                currentState = transitionTable.table[currentState][possibleTransition].nextState;
            }
        }

        if (!foundTransition)
        {
            // do i need to create another running token, or can I just use the class property token?
            currentToken.lexeme += (char)ch;
            currentToken.tokenType = TokenType.MALFORMED_TOKEN;
            throwMalformedTokenException(currentToken);
        }
    }
}
