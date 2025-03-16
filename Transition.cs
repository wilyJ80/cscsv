namespace cscsv;

public sealed class Transition
{
    private int nextState { get; set; }
    private CharTesterCallback tester { get; set; }
    private TokenType tokenType { get; set; }

    public Transition(int nextState, CharTesterCallback tester, TokenType tokenType)
    {
        this.nextState = nextState;
        this.tester = tester;
        this.tokenType = tokenType;
    }
}
