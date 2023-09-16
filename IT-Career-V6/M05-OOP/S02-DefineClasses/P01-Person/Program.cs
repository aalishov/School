
public class Program
{
    public static void Main(string[] args)
    {
        Person p1 = new Person("Gosho") ;
        Person p2 = new Person("Gosho");
        Person p3 = new Person("Gosho");
        Person p4 = new Person("John",21);
        Person p5 = new Person();
        p1.Age= 30 ;


        p1.Grow();
        p1.Grow(10);
        Console.WriteLine(p1.IntroduceYourself());
        Console.WriteLine(p1);
        Console.WriteLine(Person.Count);

        Console.WriteLine(Person.GetCountAsString());


    }
}
