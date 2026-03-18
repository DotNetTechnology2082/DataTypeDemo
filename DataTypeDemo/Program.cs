public class Program
{
    public static void Main()
    {
        int number = 42;
        int number1 = number;

        Console.WriteLine($"number: {number}, number1: {number1}");
        //after number1 is changed, number will not change because they are stored in different memory locations
        number1 = 100;
        Console.WriteLine($"number: {number}, number1: {number1}");

        //Reference type example
        Person person1 = new Person("Ram", 12);
        Person person2 = person1; // person2 references the same object as person1
        Console.WriteLine($"person1: {person1.Name}, {person1.Age}; person2: {person2.Name}, {person2.Age}");
        //after person2 is changed, person1 will also change because they reference the same object in memory
        person2.Name = "Bob";
        person2.Age = 25;
        Console.WriteLine($"person1: {person1.Name}, {person1.Age}; person2: {person2.Name}, {person2.Age}");

    }
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}