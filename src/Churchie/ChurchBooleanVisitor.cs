namespace Churchie
{
    public class ChurchBooleanVisitor<T>
    {
        public ChurchBooleanVisitor(T trueCase, T falseCase)
        {
            VisitTrue = trueCase;
            VisitFalse = falseCase;
        }

        public T VisitTrue { get; }
        public T VisitFalse { get; }
    }
}