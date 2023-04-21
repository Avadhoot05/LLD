class Program
{
    static void Main(string[] args)
    {
        IShape rectangle = ShapeFactory.getShape(eShapeType.Rectangle);
        rectangle.draw();

        IShape circle = ShapeFactory.getShape(eShapeType.Circle);
        circle.draw();
    }
}
