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
        public bool IsSensor { get; set; }

        public MobilePhone(string title, string model, int amount, float price, string color, bool isSensor = true, float discount = 0) :
            base(title, model, amount, price, color, discount)
        {
            TypeDevice = TypeDevice.PHONE;
            IsSensor = isSensor;
        }

        public override string ToString()
        {
            return base.ToString() + $"IsSensor: {(IsSensor ? "Yes" : "No")}\n";
        }

        public override void ShowInfo()
        {
            Console.WriteLine(this);
        }
    }
}
