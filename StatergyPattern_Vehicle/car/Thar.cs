using System;

public class Thar : Vehicle
{
    public Thar(IDrive mode) : base(mode)
    {
        Console.WriteLine("Thar created");
    }

    public override void drive()
    {
        Console.WriteLine("Thar drive started-");
        base.drive();
    }
}