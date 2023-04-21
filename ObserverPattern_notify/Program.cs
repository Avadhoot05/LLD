using System;
namespace ObserverPattern_notify;
class Program
{
    static void Main(string[] args)
    {
        User user1 = new User("Avadhoot", "avadhoot@gmail.com");
        User user2 = new User("Pravin", "Pravin@gmail.com"); 
        User user3 = new User("Pranita", "Pranita@gmail.com"); 

        Iphone iphone = new Iphone();
        iphone.AddObserver(user1);
        iphone.AddObserver(user2);
        iphone.AddObserver(user3);

        iphone.SetData(0);
        iphone.SetData(10);
    }
}