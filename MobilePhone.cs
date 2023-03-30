using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW_Shop
{
    public class MobilePhone : Device
    {
        // сенсорный телефон или нет
        private bool isSensor;

        public MobilePhone(string title, string model, int amount, float price, string color, float discount = 0, bool isSensor = true) :
            base(title, model, amount, price, color, discount)
        {
            TYPE_DEVICE = "MobilePhone";
            IsSensor = isSensor;
        }

        public bool IsSensor { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"IsSensor: {(isSensor ? "Yes" : "No")}\n";
        }

        public override void ShowInfo()
        {
            Console.WriteLine(this);
        }
    }
}
