namespace Animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("eric", 12);
            Console.WriteLine(animal.Age);
            Mammal mammal = new Mammal("cow");
            Console.WriteLine(mammal.Name);
            mammal.Speak();;
            Eagle eagle = new Eagle("Orel");
            eagle.Speak();
            Shark shark = new Shark("Tedy");
            shark.Speak();
        }
    }
}