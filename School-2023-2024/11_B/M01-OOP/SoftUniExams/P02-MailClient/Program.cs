public class Program
{
   public static void Main()
    {
        Mail m1 = new Mail("john@abv.bg", "jane@mail.bg", "Hi!");
        Mail m14 = new Mail("john@abv.bg", "jane@mail.bg", "Hi, I'm John!");
        Mail m11 = new Mail("john@abv.bg", "jane@mail.bg", "Hi!1");
        Mail m12 = new Mail("john@abv.bg", "jane@mail.bg", "Hi!2");
        Mail m13 = new Mail("john@abv.bg", "jane@mail.bg", "Hi!3");
        Mail m15 = new Mail("john@abv.bg", "jane@mail.bg", "Hi!5");
        Mail m2 = new Mail("jane@mail.bg", "john@abv.bg", "Hi! :)");
        Mail m3 = new Mail("dave@mail.bg", "john@abv.bg", "Hi! :)");

        MailBox john = new MailBox(5);
        MailBox jane = new MailBox(5);
        jane.IncomingMail(m14);
        jane.IncomingMail(m1);
        jane.IncomingMail(m11);
        jane.IncomingMail(m12);
        jane.IncomingMail(m13);
        jane.IncomingMail(m15);
        john.IncomingMail(m2);
        john.IncomingMail(m3);

        Console.WriteLine(jane);
        Console.WriteLine(jane.GetLongestMessage());
    }
}
