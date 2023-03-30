using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW_Shop
{
    public class Laptop : Device
    {
        // тип клавиатуры
        public string KeyboardType { get; set; }

        public Laptop(string title, string model, int amount, float price, string color, string keyboardType, float discount = 0) :
            base(title, model, amount, price, color, discount)
        {
            TypeDevice = TypeDevice.LAPTOP;
            KeyboardType = keyboardType;
        }

        public override string ToString()
        {
            return base.ToString() + $"Keyboard type: {KeyboardType}\n";
        }

        public override void ShowInfo()
        {
            Console.WriteLine(this);
        }
    }
}
