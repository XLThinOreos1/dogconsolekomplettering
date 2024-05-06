class Game()
{
    public static void GameLoop()
    {
        Dog myDog = new();

        // För varje loop så rensar den konsolen och skriver upp game menu
        Console.Clear();
        Console.WriteLine("What do you want your dog to do?");
        Console.WriteLine("\n[1] to eat\n[2] to sleep\n[3] to blink\n[4] to bark\n[5] to exit game");

        // Hindrar användaren att skriva in massa inputs under cutscenes som sen körs av sig själv när cutscenes är slut
        while (Console.KeyAvailable)
        {
            Console.ReadKey(false);
        }

        // Tar in key input från tangentbordet
        char userInput = Console.ReadKey().KeyChar;

        // Switch case som går användarens key character input och om den matchar med en av alternativen så kör den rätta case
        switch (userInput)
        {
            case '1':
                myDog.Eat();
                break;
            case '2':
                myDog.Sleep();
                break;
            case '3':
                myDog.Blink();
                break;
            case '4':
                myDog.Bark();
                break;
            case '5':
                Console.Clear();
                Console.WriteLine("Goodbye!");
                Task.Delay(1500).Wait();
                Environment.Exit(0);
                break;
            default:
                Console.Clear();
                Console.WriteLine("Invalid input!");
                Task.Delay(1500).Wait();
                break;
        }
    }
}
