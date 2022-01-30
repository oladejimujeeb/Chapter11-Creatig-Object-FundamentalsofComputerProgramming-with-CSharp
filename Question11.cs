namespace Chapter11_creating_object;

public class Question11
{
    public static void Solution()
    {
        Random rand = new Random();
        string[] reviews1 = new string[] { "This product is excelent.", "This is a great product.", "I use this product all the time.", "This is the best product of this category." };
        string[] reviews2 = new string[] { "Now I feel better.", "I changed.", "It was a miracle.", "I can't believe it. Now I feel better.", "Try it yourself. I'm very greatful." };
        string[] firstNames = new string[] { "Diana", "Petia", "Stela", "Elena", "Katia" };
        string[] secondNames = new string[] { "Ivanova", "Petrova", "Kirova", "Popova" };
        string[] cities = new string[] { "Sofia", "Plovdiv", "Varna", "Ruse", "Dolno konare" };
        Console.WriteLine($"{reviews1[rand.Next(reviews1.Length)]} {reviews2[rand.Next(reviews2.Length)]} {firstNames[rand.Next(firstNames.Length)]}" +
                          $" {secondNames[rand.Next(secondNames.Length)]} {cities[rand.Next(cities.Length)]}");
        
    }
    }