using OdeToFood.Core;
using System.Collections.Generic;

namespace OdeToFood.Data
{
    public interface RestaurantData
    {
        IEnumerable<Restaurant> GetAll();

    }

    public class InMemoryRestaurantData : RestaurantData
    {

       readonly List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant{ID=1, Name="name1", Location = "Hitechcity", Cuisine= CuisineType.Indian },
                new Restaurant{ID=1, Name="name2", Location = "Madhapur", Cuisine= CuisineType.Italian },
                new Restaurant{ID=1, Name="name3", Location = "Losangels", Cuisine= CuisineType.American }
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                   orderby r.Name
                   select r;
        }
    }
}
