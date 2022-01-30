namespace Chapter11_creating_object;

public class Question5
{
    public static void Solution()
    {
        Console.WriteLine("finds the hypotenuse of a right triangle");
        Console.Write("Enter the length of the first side: ");
        int side1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the length of the second side: ");
        int side2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"The hypotenuse is {Question5.GetHypotenuse(side1,side2)} ");
    }

    public static double GetHypotenuse(int a, int b)
    {
        double c = Math.Sqrt((a * a) + (b * b));
        return c;
    }
}