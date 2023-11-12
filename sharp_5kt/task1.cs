interface IAnimal
{
    string Name { get; set; }
    void MakeSound();
}
public class Dog : IAnimal
{

    public string Name { get; set; }

    public void MakeSound()
    {
        Console.WriteLine($"собака - {Name} сказала гав");
    }
}
public class Cat : IAnimal
{
    public string Name { get; set; }
    public void MakeSound()
    {
        Console.WriteLine($"кошка - {Name} сказала мур");
    }
}
class Program1
{
    public static void Main(string[] args)
    {
        Dog dog = new Dog();
        Cat cat = new Cat();
        dog.Name = "Jack";
        cat.Name = "Jame";
        dog.MakeSound();
        cat.MakeSound();;
    }
}