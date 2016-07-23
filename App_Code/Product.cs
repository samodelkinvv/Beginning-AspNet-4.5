using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    
    public delegate void PriceChangedEventHandler();

    public class Product
    {
        private string name;
        private decimal price;
        private string imageUrl;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string ImageUrl
        {
            get { return imageUrl; }
            set { imageUrl = value; }
        }

        public decimal Price
        {
            get { return price; }
            set
            {
                price = value;
                if (PriceChanged != null)
                {
                    PriceChanged();
                }
            }
        }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public event PriceChangedEventHandler PriceChanged;

    }
}
