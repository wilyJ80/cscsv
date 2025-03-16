namespace cscsv;

public sealed class CharTester
{
    public static bool isComma(char ch)
    {
        return ch == ',';
    }

    public static bool isCrlf(char ch)
    {
        return ch == '\n';
    }

    public static bool notCommaNotCrlf(char ch)
    {
        return (ch != ',') && (ch != '\n');
    }

    public static bool commaOrCrlf(char ch)
    {
        return !notCommaNotCrlf(ch);
    }
}
