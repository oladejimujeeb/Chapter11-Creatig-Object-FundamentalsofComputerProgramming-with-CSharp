namespace Chapter11_creating_object;

public class Question6
{
    public static void AreaByThreeSides()
    {
        Console.WriteLine("Area of Triangle Using Heron's Formula");
        Console.Write("\nEnter side 1: ");
        float side1 = float.Parse(Console.ReadLine());
        Console.Write("Enter side 2: ");
        float side2 = float.Parse(Console.ReadLine());
        Console.Write("Enter side 3: ");
        float side3 = float.Parse(Console.ReadLine());
        Question6.AreaOfTriangle(side1, side2, side3);
    }

    public static void AreaBySideAltitude()
    {
        Console.WriteLine();
        Console.WriteLine("Area of Triangle with side and the altitude to it;");
        Console.Write("\nEnter a: ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Enter h(a): ");
        float b = float.Parse(Console.ReadLine());
        Question6.AreaOfTriangle(a,b);
        
    }
    private static void AreaOfTriangle(float side1, float side2, float side3)
    {
        float sPerimeter = (side1 + side2 + side3) / 2;
        Console.WriteLine($"The area of the triangle with the three side is length is {Math.Sqrt(sPerimeter * (sPerimeter - side1) * (sPerimeter - side2) * (sPerimeter - side3) )}");;
    }

    private static void AreaOfTriangle(float side1, float side2)
    {
        Console.WriteLine("The area of the triangle with length of one side and it's altitude: {0}", (side1 * side2) / 2);
    }

    public static void AreaBySideAndAngle()
    {
        Console.Write("Area of Triangle with two side and the angle between them");
        Console.Write("\nEnter side1: ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Enter side 2: ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("Enter the side angle: ");
        float c = float.Parse(Console.ReadLine());
        Console.WriteLine($"Area of Triangle with length of two sides and the angle between them is : {(a * b * Math.Sin(c)) / 2 } ") ;
     }
}
