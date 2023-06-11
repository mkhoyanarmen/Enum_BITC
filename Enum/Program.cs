using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    internal class Program
    {
        enum CoffeeSize
        {
            Small,
            Medium,
            Large
        }
        enum MusicGenre
        {
            Rock,
            Pop,
            Jazz
        }
        static void Main(string[] args)
        {
            CoffeeSize size = CoffeeSize.Medium;
            MusicGenre genre = MusicGenre.Pop;
            switch (size)
            {
                case CoffeeSize.Small:
                    Console.WriteLine($"{CoffeeSize.Small} : 100");
                    break;
                case CoffeeSize.Medium:
                    Console.WriteLine($"{CoffeeSize.Medium} : 250");
                    break;
                case CoffeeSize.Large:
                    Console.WriteLine($"{CoffeeSize.Large} : 500");
                    break;
            }
            switch (genre)
            {
                case MusicGenre.Rock:
                    Console.WriteLine("We recommend listening to The Jimi Hendrix Experience - Purple Haze");
                    break;
                case MusicGenre.Pop:
                    Console.WriteLine("We recommend listening to The Weeknd - Blinding Lights");
                    break;
                case MusicGenre.Jazz:
                    Console.WriteLine("We recommend listening to Louis Armstrong, Ella Fitzgerald - Summertime");
                    break;
            }
        }
    }
}
