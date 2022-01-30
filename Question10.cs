namespace Chapter11_creating_object;

public class Question10
{
    public static void Solution()
    {
        int sum = 0;
        string number = "43 68 9 23 318";
        string[] splitedNumber = number.Split(' ');
        foreach (var item in splitedNumber)
        {
            sum += Convert.ToInt32(item);
            Console.Write(" + "+Convert.ToInt32(item));
        }
        Console.WriteLine($" = {sum}");
    }
}