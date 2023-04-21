
public enum eShapeType
{
    Rectangle, 
    Circle, 


}

public class ShapeFactory
{
    public static IShape getShape(eShapeType shapeType)
    {
        switch(shapeType)
        {
            case eShapeType.Rectangle:
                return new Rectangle();

            case eShapeType.Circle:
                return new Circle();
        }

        return null;
    }
}