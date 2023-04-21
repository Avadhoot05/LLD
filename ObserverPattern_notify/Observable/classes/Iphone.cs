class Iphone : IStockObservable
{
    int m_uStockCount = 0;
    List<IObserver> m_lstUser;
    public Iphone()
    {
        m_lstUser = new List<IObserver>();
    }

    public void AddObserver(IObserver user)
    {
        m_lstUser.Add(user);
    }

    public void RemoveObserver(IObserver observer)
    {
        Console.WriteLine("User removed");
    }

    public void NotifyAll()
    {
        for(int i = 0; i < m_lstUser.Count; i++)
            m_lstUser[i].Notify(0);
    }

    public void SetData(int uNewStockCount)
    {
        if(m_uStockCount == uNewStockCount)
            return;

        m_uStockCount = uNewStockCount;
        NotifyAll();
    }
}