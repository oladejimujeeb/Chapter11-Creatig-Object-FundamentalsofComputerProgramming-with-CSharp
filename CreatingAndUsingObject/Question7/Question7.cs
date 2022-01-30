namespace Chapter11_creating_object.CreatingAndUsingObject.Question7;
using CreatingAndUsingObject;

public class Question7
{
     public static void Solution7 ()
     {
          Cat cat = new Cat("Momi","White");
          cat.SayMiau();
          Console.WriteLine();
     }
     //Question8
     public static void Solution8()
     {
          String name = "Cat";
          for(int i = 1; i <= 10; i++)
          {
               Cat cat = new Cat(name + Sequence.NextValue(), "White");
               cat.SayMiau();
          }
     }
}