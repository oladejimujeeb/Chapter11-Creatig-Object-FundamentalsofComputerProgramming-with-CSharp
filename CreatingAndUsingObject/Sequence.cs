namespace Chapter11_creating_object.CreatingAndUsingObject;

public class Sequence
{
    private static int CurrentValue = 1;

    private Sequence()
    {
    }

    public static int NextValue() => CurrentValue++;

}