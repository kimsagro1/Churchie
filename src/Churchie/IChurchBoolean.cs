using System.Diagnostics;

namespace Churchie
{
    public interface IChurchBoolean
    {
        T Accept<T>(ChurchBooleanVisitor<T> visitor);
    }
}