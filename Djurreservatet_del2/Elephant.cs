using System;

namespace Djurreservatet
{
    public class Elephant : Animal
    {
        ConsoleKeyInfo feed;

        public Elephant(string type, string name, int hungerLevel) : base(type, name, hungerLevel)
        {

        }

        public override void FeedAnimal()
        {
            Console.WriteLine($"Ska {type} {name} matas?");
            Console.WriteLine("Om ja välj [y] eller valfri tangent för att gå vidare.");
            feed = Console.ReadKey();
            switch(feed.Key)
            {
                case ConsoleKey.Y:
                    hungerLevel -= 10;
                    break;
                default:
                    break;
            }
        }
    }
}