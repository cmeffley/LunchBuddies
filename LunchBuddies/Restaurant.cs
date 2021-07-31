using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchBuddies
{
    class Restaurant
    {
        public string RestaurantName { get; set; }

        private List<string> RestaurantNames = new List<string>();
        public Restaurant()
        {
            RestaurantNames.Add("Siam Cafe");
            RestaurantNames.Add("McNamara's");
            RestaurantNames.Add("Loveless Cafe");
            RestaurantNames.Add("Baja Burrito");
            RestaurantNames.Add("Edley's");

            Random rnd = new Random();
            int index = rnd.Next(RestaurantNames.Count);
            RestaurantName = RestaurantNames[index];
        }

    }
}
