using System;

namespace Sana07
{
    public class Laptop : Product
    {
        protected string _model;
        protected float _weight;
        protected string _producer;
        protected float _screenSize;

        public string Model
        {
            get { return _model; }
            set
            {
                if (value.Length > 0) _model = value;
                else throw new ArgumentException("Model of laptop can not be empty!");
            }
        }
        public float Weight
        {
            get { return _weight; }
            set
            {
                if (value > 0) _weight = value;
                else throw new ArgumentException("Weight of laptop can not be negative or equal zero!");
            }
        }
        public string Producer
        {
            get { return _producer; }
            set
            {
                if (value.Length > 0) _producer = value;
                else throw new ArgumentException("Producer of laptop can not be empty!");
            }
        }
        public float ScreenSize
        {
            get { return _screenSize; }
            set
            {
                if (value > 0) _screenSize = value;
                else throw new ArgumentException("Screen size of laptop can not be negative or equal zero!");
            }
        }

        public Laptop() : base()
        {
            Model = "Undefined";
            Weight = 1f;
            Producer = "Undefined";
            ScreenSize = 1f;
        }
        public Laptop(string model, float weight, string producer, float screenSize, string name, float price, int count) : base(name, price, count)
        {
            Model = model;
            Weight = weight;
            Producer = producer;
            ScreenSize = screenSize;
        }
        public Laptop(Laptop laptop) : base(laptop)
        {
            Model = laptop.Model;
            Weight = laptop.Weight;
            Producer = laptop.Producer;
            ScreenSize = laptop.ScreenSize;
        }

        public override string Display()
        {
            return $"{Name} " + $"{Producer} " + $"{Model} " + $"{ScreenSize}' " + $"{Weight}g " + $"{Price} UAN " + $"{Count} units left";
        }
    }
}
