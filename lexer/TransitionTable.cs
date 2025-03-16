namespace cscsv.lexer;

public sealed class TransitionTable
{
    public Transition[][] table { get; }

    public TransitionTable()
    {
        this.table = [
            // State 0
            [
                new Transition(1, CharTester.isComma, TokenType.COMMA, IsOther.NOT_OTHER),
                    new Transition(2, CharTester.isCrlf, TokenType.CRLF, IsOther.NOT_OTHER),
                    new Transition(3, CharTester.notCommaNotCrlf, TokenType.NON_ACCEPTING, IsOther.NOT_OTHER)
            ],
            // State 1: accepting
            [],
            // State 2: accepting
            [],
            // State 3
            [
                new Transition(3, CharTester.notCommaNotCrlf, TokenType.NON_ACCEPTING, IsOther.NOT_OTHER),
            new Transition(4, CharTester.commaOrCrlf, TokenType.TEXTDATA, IsOther.IS_OTHER)
            ],
            // State 4: accepting
            []
        ];
    }
}
