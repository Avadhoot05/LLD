public class Circle : IShape
{
    public Circle()
    {
        Console.WriteLine("Circle created");
    }

    public void draw()
    {
        Console.WriteLine("Circle drawn");
    } 

    public void getBoundingRect()
    {
        Console.WriteLine("Circle bounding rect");
    }
}