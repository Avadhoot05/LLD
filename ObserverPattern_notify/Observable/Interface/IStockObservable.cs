public interface IStockObservable
{
    public void AddObserver(IObserver observer);

    public void RemoveObserver(IObserver observer);

    public void NotifyAll();

    public void SetData(int uNewStockCount);
}