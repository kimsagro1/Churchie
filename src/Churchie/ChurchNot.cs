namespace Churchie
{
    public class ChurchNot : IChurchBoolean
    {
        private readonly IChurchBoolean _b;

        public ChurchNot(IChurchBoolean b) => _b = b;

        public T Accept<T>(ChurchBooleanVisitor<T> visitor) =>
            _b.Accept(
                new ChurchBooleanVisitor<T>(
                    trueCase: visitor.VisitFalse,
                    falseCase: visitor.VisitTrue));
    }
}