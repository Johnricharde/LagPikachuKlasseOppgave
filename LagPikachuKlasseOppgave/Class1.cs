namespace LagPikachuKlasseOppgave
{
    class Pikachu
    {
        public string name = "Pikachu";
        public int Lvl = 10;
        public int Hp = 25;

        public void showInfo()
        {
            Console.WriteLine($"Name: {name}\nLevel: {Lvl}\nHealth: {Hp}");
        }
    }
}
