using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW_Shop
{
    public class Tablet : Device
    {
        // планшет раскладушка или нет
        public bool IsClamshell { get; set; }

        public Tablet(string title, string model, int amount, float price, string color, bool isClamshell = false, float discount = 0) :
            base(title, model, amount, price, color, discount)
        {
            TypeDevice = TypeDevice.TABLET;
            IsClamshell = isClamshell;
        }

        public override string ToString()
        {
            return base.ToString() + $"IsClamshell: {(IsClamshell ? "Yes" : "No")}\n";
        }

        public override void ShowInfo()
        {
            Console.WriteLine(this);
        }
    }
}
