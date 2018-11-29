using System;
using System.Collections.Generic;

namespace Starcraft2MapPicker
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var maps = new List<string>()
            {
                "Automaton LE",
                "Blueshift LE",
                "Cerulean Fall LE",
                "Kairos Junction LE",
                "Para Site LE",
                "Port Aleksander LE",
                "Stasis LE"
            };

            var rand = new Random();

            var random = rand.Next(0, maps.Count);

            Console.WriteLine(maps[random]);
        }
    }
}