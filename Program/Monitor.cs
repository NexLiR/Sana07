using System;

namespace Sana07
{
    public class Monitor : Product
    {
        protected string _model;
        protected string _producer;
        protected float _screenSize;
        protected int _refreshRate;

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

        public Monitor() : base()
        {
            Model = "Undefined";
            Producer = "Undefined";
            ScreenSize = 1f;
            RefreshRate = 1;
        }
        public Monitor(string model, string producer, float screenSize, int refreshRate, string name, float price, int count) : base(name, price, count)
        {
            Model = model;
            Producer = producer;
            ScreenSize = screenSize;
            RefreshRate = refreshRate;
        }
        public Monitor(Monitor monitor) : base(monitor)
        {
            Model = monitor.Model;
            Producer = monitor.Producer;
            ScreenSize = monitor.ScreenSize;
            RefreshRate = monitor.RefreshRate;
        }

        public override string Display()
        {
            return $"{Name} " + $"{Producer} " + $"{Model} " + $"{ScreenSize}' " + $"{RefreshRate}Hhz " + $"{Price} UAN " + $"{Count} units left";
        }
    }
}
