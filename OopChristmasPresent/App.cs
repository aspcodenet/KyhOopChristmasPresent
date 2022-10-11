namespace OopChristmasPresent;


public class App
{
    public void Run()
    {
        var person1 = new Person("Stefan");
        var person2 = new Person("Josefine");

        person1.AddPresent( new ChristmasPresent("PS5", 4800) );
        person1.AddPresent(new ChristmasPresent("Mobil", 1300));
        person2.AddPresent(new ChristmasPresent("Dator", 13000));

        var personerList = new List<Person>();
        personerList.Add(person1);
        personerList.Add(person2);

        foreach (var person in personerList)
        {
            Console.WriteLine($"{person.Name} ska få julklappar för {person.GetTotalPrice()} kr");
        }

        

    }
}