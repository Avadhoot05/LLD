using System;
namespace c;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Vehicle v = new Vehicle(new FourWheelDrive());
        v.drive();

        Thar t = new Thar(new FourWheelDrive());
        t.drive();

        Nano n = new Nano(new TwoWheelDrive());
        n.drive();
    }
}
