using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW_Shop
{
    public class Program
    {
        static void Main(string[] args)
        {
            // создание объектов:
            Shop shop = new Shop("Super Shop");

            MobilePhone phone = new MobilePhone("Iphone", "7", 5, 5600, "White");
            MobilePhone phone2 = new MobilePhone("Iphone", "10", 10, 11500, "Black");
            Laptop laptop = new Laptop("Lenovo", "ThinkPad", 10, 14500, "Gray", "Gamer");
            Laptop laptop2 = new Laptop("Lenovo", "VeryBad", 10, 9745, "Orange", "Classic");
            Tablet tablet = new Tablet("Ipad", "35", 10, 9999, "Black");
            Tablet tablet2 = new Tablet("Ipad", "78", 8, 7885, "Red", true);


            // добавление девайсов:
            shop.AddDevice(phone).AddDevice(phone2).AddDevice(laptop).AddDevice(laptop2).AddDevice(tablet).AddDevice(tablet2);
            Console.WriteLine(shop);


            // возвращается список всех девайсов у которых цена меньше 10000:
            Console.WriteLine("\nSHOW ALL DEVICES WHOSE PRICE IS LESS THAN 1000:");
            List<Device> listDevices = shop.GetDevicesToMaxPrice(10000);
            foreach (var d in listDevices)
            {
                Console.WriteLine(d);
            }


            // возвращается список всех телефонов:
            Console.WriteLine("\nSHOW ALL PHONE:");
            List<Device> listPhones = shop[TypeDevice.PHONE];
            foreach (var d in listPhones)
            {
                Console.WriteLine(d);
            }


            // удаление всех планшетов:
            Console.WriteLine("\nDELETE ALL TABLETS:");
            shop.DelDevicesByType(TypeDevice.TABLET);
            Console.WriteLine(shop);
        }
    }
}
