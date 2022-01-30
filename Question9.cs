namespace Chapter11_creating_object;

public class Question9
{
    
    public static void Solution()
    {
        DateTime[] holidays = new DateTime[]
        {
            new DateTime(2022, 01, 01),
            new DateTime(2022, 02, 24),
            new DateTime(2022, 04, 15),
            new DateTime(2022, 04, 18),
            new DateTime(2022, 05, 03),
            new DateTime(2022, 05, 04),
            new DateTime(2022, 05, 27),
            new DateTime(2022, 07, 13),
            new DateTime(2022, 07, 10),
            new DateTime(2022, 07, 31),
            new DateTime(2022, 10, 01),
            new DateTime(2022, 12, 25),
            new DateTime(2022, 12, 26)
        };

        DateTime[] workSaturdays = new DateTime[]
        {
            new DateTime(2022, 02, 08),
            new DateTime(2022, 03, 26),
            new DateTime(2022, 05, 14),
            new DateTime(2022, 11, 27),
        };

        int workingDays = 0;

        Console.Write("Enter end date (YYYY/MM/DD): ");
        DateTime endDate = Convert.ToDateTime(Console.ReadLine());
        DateTime now = DateTime.Now;

        do
        {
            now = now.AddDays(1);

            if((now.DayOfWeek >= DayOfWeek.Monday) && (now.DayOfWeek <= DayOfWeek.Friday))
                workingDays++;

            foreach (var i in holidays)
                if (i.Date == now.Date)
                    workingDays--;

            foreach (var i in workSaturdays)
                if (i.Date == now.Date)
                    workingDays++;

        } while (now.Date != endDate.Date);

        Console.WriteLine($"{workingDays} working days." );
    }
}