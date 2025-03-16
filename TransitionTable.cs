namespace cscsv;

public sealed class TransitionTable
{
    private Transition[][] transitionTable { get; }

    public TransitionTable()
    {
        this.transitionTable = [
            // State 0
            [
                new Transition(1, CharTester.isComma, TokenType.COMMA),
                    new Transition(2, CharTester.isCrlf, TokenType.CRLF),
                    new Transition(3, CharTester.notCommaNotCrlf, TokenType.NON_ACCEPTING)
            ],
            // State 1: accepting
            [],
            // State 2: accepting
            [],
            // State 3
            [
                new Transition(3, CharTester.notCommaNotCrlf, TokenType.NON_ACCEPTING),
            new Transition(4, CharTester.commaOrCrlf, TokenType.TEXTDATA)
            ],
            // State 4
            []
        ];
    }
}
