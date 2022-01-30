namespace Chapter11_creating_object.CreatingAndUsingObject;

public class Cat
{
    private string Name;
    private string Colour;
    public Cat()
    {
        this.Name = "Unnamed";
        this.Colour = "gray";
    }
    public Cat(string name, string color)
    {
        this.Name = name;
        this.Colour = color;
    }
    public void SayMiau()
    {
        Console.WriteLine($" My cat name is {Name} said: Miauu  and it's colour is {Colour}");
    }
}