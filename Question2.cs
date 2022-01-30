using System;
namespace Chapter11_creating_object;

public class Question2
{
    public static void Solution()
    {
        int counter =1;
        while (counter<11)
        {
            Random random = new Random();
            int number = random.Next(100, 201);
            Console.WriteLine($"{counter}.{number}");
            counter++;
        }
    }
}