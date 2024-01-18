using System;

namespace Sana07
{
    public abstract class Product
    {
        protected string _name;
        protected float _price;
        protected int _count;

        public string Name
        {
            get { return _name; }
            set 
            {
                if (value.Length > 0) _name = value;
                else throw new ArgumentException("Name of product can not be empty!");
            }
        }
        public float Price
        {
            get { return _price; }
            set
            {
                if (value > 0) _price = value;
                else throw new ArgumentException("Price of product can not be negative or equal zero!");
            }
        }
        public int Count
        {
            get { return _count; }
            set
            {
                if (value >= 0) _count = value;
                else throw new ArgumentException("Count of product can not be negative!");
            }
        }

        public Product()
        {
            Name = "Undefined";
            Price = 1f;
            Count = 0;
        }
        public Product(string name, float price, int count)
        {
            Name = name;
            Price = price;
            Count = count;
        }
        public Product(Product product)
        {
            Name = product.Name;
            Price = product.Price;
            Count = product.Count;
        }

        public abstract string Display();
    }
}
