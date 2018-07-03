namespace Churchie
{
    public static class ChurchBoolean
    {
        public static bool ToBool(this IChurchBoolean b) =>
            b.Accept(new ChurchBooleanVisitor<bool>(true, false));

        public static IChurchBoolean ToChurchBoolean(this bool b) =>
            b ? (IChurchBoolean) new ChurchTrue() : new ChurchFalse();
    }
}