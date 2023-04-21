public class Rectangle : IShape
{
    public Rectangle()
    {
        Console.WriteLine("Rectangle created");
    }

    public void draw()
    {
        Console.WriteLine("Rectangle drawn");
    } 

    public void getBoundingRect()
    {
        Console.WriteLine("Rectangle bounding rect");
    }
} 