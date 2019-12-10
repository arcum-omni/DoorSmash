using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorSmash
{
    public class Product
    {
        #region Properties
        private string name;
        private double price;

        public int ProductID { get; set; }

        /// <summary>
        /// The name of the product
        /// </summary>
        /// <exception cref="ArgumentException">
        /// Thrown when <see cref="Name"/> > 50 char, null, or whitespace
        /// </exception>
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"{nameof(Product.Name)} cannot be null or whitespace");
                }
                else if (value.Length > 50)
                {
                    throw new ArgumentException($"{nameof(Product.Name)} cannot be more than 50 characters.");
                }
                name = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                // valule is the value coming in (getting set)
                if (value < 0)
                {
                    string msg = $"{nameof(Price)} must be a positive value";
                    throw new ArgumentOutOfRangeException(msg);
                }
                price = value;
            }
        }

        public string Description { get; set; }
        #endregion

        /// <summary>
        /// Product Single Arg Constructor
        /// </summary>
        /// <param name="productName"></param>
        public Product(string productName)
        {
            Name = productName;
        }




    }
}
