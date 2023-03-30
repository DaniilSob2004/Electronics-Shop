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
        private bool isClamshell;

        public Tablet(string title, string model, int amount, float price, string color, float discount = 0, bool isClamshell = false) :
            base(title, model, amount, price, color, discount)
        {
            TYPE_DEVICE = "Tablet";
            IsClamshell = isClamshell;
        }

        public bool IsClamshell { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"IsClamshell: {(isClamshell ? "Yes" : "No")}\n";
        }

        public override void ShowInfo()
        {
            Console.WriteLine(this);
        }
    }
}
