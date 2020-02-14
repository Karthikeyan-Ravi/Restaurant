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
            RestaurantFields restaurantFields = new RestaurantFields(1,"HMR", "Soth-Indian, North Indian", "R.S Puram, Cbe");
            restaurantDetails.Add(restaurantFields);
            restaurantFields = new RestaurantFields(2,"AAchis", "Chinese, North Indian", "Race course, Cbe");
            restaurantDetails.Add(restaurantFields);
            restaurantFields = new RestaurantFields(3,"Monkey Restaurant", "South-Indian,North-Indian", "Hopes, Cbe");
            restaurantDetails.Add(restaurantFields);
        }
        public IEnumerable<RestaurantFields> DisplayRestaurantFields()
        {
            return restaurantDetails;
        }
        public void Add(RestaurantFields restaurantFields)
        {
            restaurantDetails.Add(restaurantFields);
        }
        public void Delete(int id)
        {
            RestaurantFields restaurantFields = GetRestaurantById(id);
            if(restaurantFields!=null)
                restaurantDetails.Remove(restaurantFields);
        }
        public void Update(RestaurantFields restaurantFields)
        {
            RestaurantFields restaurantField = restaurantDetails.Find(id => id.RestaurantId == restaurantFields.RestaurantId);
            restaurantField.RestaurantId = restaurantFields.RestaurantId;
            restaurantField.RestaurantName = restaurantFields.RestaurantName;
            restaurantField.RestaurantType = restaurantFields.RestaurantType;
            restaurantField.Location = restaurantFields.Location;
        }
        public RestaurantFields GetRestaurantById(int resId)
        {
            return restaurantDetails.Find(id => id.RestaurantId == resId);
        }
    }
}