using System;

namespace EqualPlayer
{
    public class Program
    {
        private static void Main(string[] args)
        {
            HashSet<Player> setOfPlayers = new HashSet<Player>();
            setOfPlayers.add(Tank,"Ana");
            setOfPlayers.add(Slayer,"Paulo");
            setOfPlayers.add(Tank,"Ana");
            foreach( Player p in setOfPlayers)
            {
                Console.WriteLine($"{p.Name} is a {p.PClass}" );
            }
        }
    }
}
