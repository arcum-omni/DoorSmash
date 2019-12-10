using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorSmash
{
    class Restaurant
    {
        private string _category;

        public int RestaurantID { get; set; }

        public string Name { get; set; }

        public string Category
        {
            get
            {
                return _category;
            }
            set
            {
                if (!IsValidCategory(value))
                {
                    throw new ArgumentException("Invalid Category");
                }
                _category = value;
            }
        }

        private bool IsValidCategory(string input)
        {
            switch (input)
            {
                case "steakhouse":
                case "chicken":
                case "breakfast":
                case "mexican":
                case "pizza":
                case "chinese":
                case "asian":
                    return true;

                default:
                    return false;
            }
        }

        /// <summary>
        /// The products sold by THIS restaurant
        /// </summary>
        public List<Product> Products { get; set; }
    }
}
