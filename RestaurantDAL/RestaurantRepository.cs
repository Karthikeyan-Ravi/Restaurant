using RestaurantEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDAL
{
    public class RestaurantRepository
    {
        static List<RestaurantFields> restaurantDetails = new List<RestaurantFields>();
        static RestaurantRepository()
        {
            RestaurantFields restaurantFields = new RestaurantFields("HMR", "Soth-Indian, North Indian", "R.S Puram, Cbe");
            restaurantDetails.Add(restaurantFields);
            restaurantFields = new RestaurantFields("AAchis", "Chinese, North Indian", "Race course, Cbe");
            restaurantDetails.Add(restaurantFields);
            restaurantFields = new RestaurantFields("Monkey Restaurant", "South-Indian,North-Indian", "Hopes, Cbe");
            restaurantDetails.Add(restaurantFields);
        }
        public IEnumerable<RestaurantFields> DisplayRestaurantFields()
        {
            return restaurantDetails;
        }
    }
}