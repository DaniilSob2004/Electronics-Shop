using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW_Shop
{
    public enum TypeDevice
    {
        PHONE,
        LAPTOP,
        TABLET
    }

    public abstract class Device
    {
        public TypeDevice TypeDevice { get; set; }
        private int amount;
        private float price;
        private float discount;

        public Device(string title, string model, int amount, float price, string color, float discount = 0)
        {
            Title = title;
            Model = model;
            Amount = amount;
            Price = price;
            Discount = discount;
            Color = color;
        }

        public string Title { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public int Amount
        {
            get { return amount; }
            set
            {
                if (value < 0) throw new Exception("Amount must be >= 0");
                amount = value;
            }
        }

        public float Price
        {
            get { return price - (price * discount); }
            set
            {
                if (value <= 0 || value > 1000000) throw new Exception("Price must be > 0 and <= 1 000 000");
                price = value;
            }
        }

        public float Discount
        {
            get { return discount; }
            set
            {
                if (value < 0 || value > 50) throw new Exception("Discount must be >= 0 and <= 50");
                discount = value;
            }
        }

        public override string ToString()
        {
            return $"Title: {Title}\n" +
                   $"Model: {Model}\n" +
                   $"Color: {Color}\n" +
                   $"Amount: {Amount}\n" + 
                   $"Price: {Price}\n";
        }

        public abstract void ShowInfo();
    }
}
