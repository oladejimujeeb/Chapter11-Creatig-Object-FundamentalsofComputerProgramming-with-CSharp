namespace Chapter11_creating_object;

public class Question4
{
    public static void Solution4()
    {
        double milisecondSinceOn = Environment.TickCount;
        Console.WriteLine($"Time since the computer is on in Millisecond:{milisecondSinceOn}");
        int convertionToMintune = 1000 * 60;
        int convertionToHour = 1000 * 60 * 60;
        int convertionToDay = 1000 * 60 * 60 * 24;
        double minutes = milisecondSinceOn / convertionToMintune;
        double hours = milisecondSinceOn / convertionToHour;
        double days = milisecondSinceOn / convertionToDay;
        Console.WriteLine($"Time since the computer is on  in Mintues:{minutes}mins\nTime in Hours:{hours}hrs\nTime in Days:{days}days");
    }
}