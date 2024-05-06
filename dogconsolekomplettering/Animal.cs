public class Animal
{
    // Funktionen är virtual så den kan senare overrideas för funktioner som ärver från den här
    public virtual void Eat()
    {
        Console.WriteLine("Animal is eating.");
    }

    public virtual void Sleep()
    {
        Console.WriteLine("Animal is sleeping.");
    }
}