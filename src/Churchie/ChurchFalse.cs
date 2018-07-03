namespace Churchie
{
    public class ChurchFalse : IChurchBoolean
    {
        public T Accept<T>(ChurchBooleanVisitor<T> visitor)=>
            visitor.VisitFalse;
    }
}