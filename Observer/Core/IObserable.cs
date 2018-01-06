namespace Observer.Core
{
    public interface IObserable
    {
        void Add(IObserver observer);
        void Remove(IObserver observer);
        void Notify();
    }
}