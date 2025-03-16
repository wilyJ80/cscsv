namespace cscsv.lexer;

public sealed record Transition(int nextState, CharTesterCallback charTesterCallback, TokenType tokenType, IsOther isOther);
