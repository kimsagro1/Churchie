namespace Churchie
{
    public class ChurchAnd : IChurchBoolean
    {
        private readonly IChurchBoolean _x;
        private readonly IChurchBoolean _y;

        public ChurchAnd(IChurchBoolean x, IChurchBoolean y)
        {
            _x = x;
            _y = y;
        }

        public T Accept<T>(ChurchBooleanVisitor<T> visitor) =>
            _x.Accept(
                new ChurchBooleanVisitor<T>(
                    _y.Accept(visitor),
                    visitor.VisitFalse));
    }
}