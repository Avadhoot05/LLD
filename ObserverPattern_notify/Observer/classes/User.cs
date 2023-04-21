using System;
class User : IObserver
{
    protected string m_strName;
    protected string m_strEmail;
    public User(string name, string email)
    {
        m_strName = name;
        m_strEmail = email;
    }

    public void Notify(int data)
    {
        Console.WriteLine("notify to "+ m_strEmail);
    }
}