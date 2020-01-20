using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OdeToFood.Data.Models;

namespace OdeToFood.Data.Services
{
    public interface IRestaurantData
    {
        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { Id = 1, Name = "Scott's Pizza", Cuisine = CuisineType.Italian},
                new Restaurant { Id = 2, Name = "Tersigeuls", Cuisine = CuisineType.French},
                new Restaurant { Id = 3, Name = "Mango Grove", Cuisine = CuisineType.Indian}
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);
        }
    }
}
