using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantEntity
{
    public class RestaurantFields
    {
        public int RestaurantId
        {
            get;
            set;
        }
        public string RestaurantName
        {
            get;
            set;
        }
        public string RestaurantType
        {
            get;
            set;
        }
        public string Location
        {
            get;
            set;
        }
        public RestaurantFields()
        { }
        public RestaurantFields(int restaurantId, string restaurantName, string restaurantType, string location)
        {
            this.RestaurantId = restaurantId;
            this.RestaurantName = restaurantName;
            this.RestaurantType = restaurantType;
            this.Location = location;
        }
    }
}
