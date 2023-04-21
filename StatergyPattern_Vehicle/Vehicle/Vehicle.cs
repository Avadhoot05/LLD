
public class Vehicle
{
    IDrive driveMode;

    public Vehicle(IDrive mode)
    {
        driveMode = mode;
    }
    
    public virtual void drive()
    {
        driveMode.drive();
    }
}
