public class Dog : Mammal
{
    // Overridear Eat() funktionen som ärver från Animal classen så den passar in för hundar
    public override void Eat()
    {
        Console.Clear();
        Console.WriteLine("Dog is eating.");
        Task.Delay(1500).Wait();
    }

    // Overridear Sleep() funktionen som ärver från Animal classen så den passar in för hundar
    public override void Sleep()
    {
        Console.Clear();
        Console.WriteLine("Dog is sleeping.");
        Task.Delay(1500).Wait();
    }

    // Overridear Blink() funktionen som ärver från Mammal classen så den passar in för hundar
    public override void Blink()
    {
        Console.Clear();
        Console.WriteLine("Dog is blinking");
        Task.Delay(1500).Wait();
    }

    // Funktion som säger att hunden säger bark
    public void Bark()
    {
        Console.Clear();
        Console.WriteLine("Dog is barking");
        Task.Delay(1500).Wait();
    }
}