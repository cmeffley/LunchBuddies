using System;
using System.Collections.Generic;

namespace LunchBuddies
{
    class Program
    {
        static void Main(string[] args)
        {
            var chris = new LunchBuddy("Chris", "Meffley");
            var mike = new LunchBuddy("Mike", "Wazowski");
            var james = new LunchBuddy("James", "Bond");
            var walter = new LunchBuddy("Walter", "Mitty");

            List<LunchBuddy> friends = new List<LunchBuddy>();

            friends.Add(chris);
            friends.Add(mike);
            friends.Add(james);
            friends.Add(walter);


            chris.Eat();
            Console.WriteLine();

            chris.Eat("salmon");
            Console.WriteLine();

            chris.Eat(friends);
            Console.WriteLine();

            chris.Eat("brisket", friends);


        }
    }
}
