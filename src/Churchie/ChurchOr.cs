namespace Churchie
{
    public class ChurchOr : IChurchBoolean
    {
        private readonly IChurchBoolean _x;
        private readonly IChurchBoolean _y;

        public ChurchOr(IChurchBoolean x, IChurchBoolean y)
        {
            _x = x;
            _y = y;
        }

        public T Accept<T>(ChurchBooleanVisitor<T> visitor) =>
            _x.Accept(
                new ChurchBooleanVisitor<T>(
                    visitor.VisitTrue,
                    _y.Accept(visitor)));
    }
}