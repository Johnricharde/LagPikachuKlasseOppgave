namespace LagPikachuKlasseOppgave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pikachu myPokemon = new Pikachu();
            Console.WriteLine($"Name: {myPokemon.name}\nLevel: {myPokemon.Lvl}\nHealth: {myPokemon.Hp}");
        }
    }
}
