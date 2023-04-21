using System;

public class Nano : Vehicle
{
    public Nano(IDrive mode) : base(mode)
    {
        Console.WriteLine("Nano created");
    }

    public override void drive()
    {
        Console.WriteLine("Nano drive started-");
        base.drive();
    }
}