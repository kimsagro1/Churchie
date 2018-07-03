namespace Churchie
{
    public class ChurchTrue : IChurchBoolean
    {
        public T Accept<T>(ChurchBooleanVisitor<T> visitor) =>
            visitor.VisitTrue;
    }
}