using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchBuddies
{
    class LunchBuddy
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public LunchBuddy(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string Eat()
        {
            var restaurant = new Restaurant();
            Console.WriteLine($"{FirstName} {LastName} is at {restaurant.RestaurantName}");
            return restaurant.RestaurantName;
        }

        public void Eat(string food)
        {
            Console.WriteLine($"{FirstName} {LastName} ate {food} at the office");
        }

        public void Eat(List<LunchBuddy> companions)
        {
            var restaurant = new Restaurant();
            Console.Write($"{FirstName} {LastName} is at {restaurant.RestaurantName} with ");
            for (var i = 0; i < companions.Count; i++)
            {
                if (FirstName == companions[i].FirstName)
                {
                    Console.Write("");
                }
                else if (i < companions.Count - 1)
                {
                    Console.Write($"{companions[i].FirstName}, ");
                }
                else
                {
                    Console.Write($"and {companions[i].FirstName}.");
                }
            }

        }

        public void Eat(string food, List<LunchBuddy> companions)
        {
            var restaurant = new Restaurant();
            Console.WriteLine($"{FirstName} {LastName} ordered {food} at {restaurant.RestaurantName}");
            for(var i = 0; i < companions.Count; i++)
            {
                if(FirstName == companions[i].FirstName)
                {
                    Console.Write("");
                }
                else
                {
                    Console.WriteLine($"{companions[i].FirstName} is there too");
                }
            }
        }

    }
}
