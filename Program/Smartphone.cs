using System;

namespace Sana07
{
    public class Smartphone : Product
    {
        protected string _model;
        protected string _producer;
        protected float _screenSize;
        protected int _refreshRate;
        protected int _storage;

        public string Model
        {
            get { return _model; }
            set
            {
                if (value.Length > 0) _model = value;
                else throw new ArgumentException("Model of monitor can not be empty!");
            }
        }
        public string Producer
        {
            get { return _producer; }
            set
            {
                if (value.Length > 0) _producer = value;
                else throw new ArgumentException("Producer of monitor can not be empty!");
            }
        }
        public float ScreenSize
        {
            get { return _screenSize; }
            set
            {
                if (value > 0) _screenSize = value;
                else throw new ArgumentException("Screen size of monitor can not be negative or equal zero!");
            }
        }
        public int RefreshRate
        {
            get { return _refreshRate; }
            set
            {
                if (value > 0) _refreshRate = value;
                else throw new ArgumentException("Refresh rate of monitor can not be negative or equal zero!");
            }
        }
        public int Storage
        {
            get { return _storage; }
            set
            {
                if (value > 0) _storage = value;
                else throw new ArgumentException("Storage of smartphone can not be negative or equal zero!");
            }
        }

        public Smartphone() : base()
        {
            Model = "Undefined";
            Producer = "Undefined";
            ScreenSize = 1f;
            RefreshRate = 1;
            Storage = 1;
        }
        public Smartphone(string model, string producer, float screenSize, int refreshRate, int storage, string name, float price, int count) : base(name, price, count)
        {
            Model = model;
            Producer = producer;
            ScreenSize = screenSize;
            RefreshRate = refreshRate;
            Storage = storage;
        }
        public Smartphone(Smartphone smartphone) : base(smartphone)
        {
            Model = smartphone.Model;
            Producer = smartphone.Producer;
            ScreenSize = smartphone.ScreenSize;
            RefreshRate = smartphone.RefreshRate;
            Storage = smartphone.Storage;
        }

        public override string Display()
        {
            return $"{Name} " + $"{Producer} " + $"{Model} " + $"{Storage} " + $"{ScreenSize}' " + $"{RefreshRate}Hhz " + $"{Price} UAN " + $"{Count} units left";
        }
    }
}
