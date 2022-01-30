using System;
namespace Chapter11_creating_object;

public class Question1
{
    public static void Solution1()
    {
        Console.Write("Enter Year:");
        int year = Convert.ToInt32(Console.ReadLine());
        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine($"{DateTime.IsLeapYear(year)}, {year} is a leap year");
        }
        else
        {
            Console.WriteLine($"{DateTime.IsLeapYear(year)}, {year} is not a leap year");
        }
    }
}