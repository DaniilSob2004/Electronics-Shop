using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW_Shop
{
    public class Shop
    {
        private List<Device> devices;

        private void CopyShop(Shop newShop)
        {
            Title = newShop.Title;
            devices = newShop.Devices;
        }


        public Shop() : this("Shop Title") { }

        public Shop(string title)
        {
            Title = title;
            devices = new List<Device>();
        }

        public Shop(List<Device> devices)
        {
            Devices = devices;
        }

        public Shop(Shop shop)
        {
            if (shop == null) throw new Exception("Reference Shop must not be null!");
            CopyShop(shop);
        }


        public string Title { get; set; }

        public List<Device> Devices 
        {
            get { return devices; }
            set
            {
                if (value == null) throw new Exception("Reference Device must not be null!");
                devices = value;
            }
        }


        public Shop AddDevice(Device device)
        {
            // добавление девайса
            if (devices == null) throw new Exception("Reference Device must not be null!");
            devices.Add(device);

            return this;
        }

        public void DelDevicesByType(TypeDevice typeDevice)
        {
            // удаление всех устройств по типу (например удаляем все ноутбуки)
            int count = devices.Count;
            for (int i = 0; i < count; i++)
            {
                if (devices[i].TypeDevice == typeDevice)
                {
                    devices.Remove(devices[i]);
                    // декременты необходимы из-за того что когда удаляем, размер массива меняется
                    // и будем выходить за пределы диапазана списка
                    i--;
                    count--;
                }
            }
        }

        public List<Device> GetDevicesToMaxPrice(int maxPrice)
        {
            // возвращается список всех девайсов у которых цена меньше maxPrice
            List<Device> listDevices = new List<Device>();

            foreach (var d in devices)
            {
                if (d.Price <= maxPrice)
                {
                    listDevices.Add(d);
                }
            }

            return listDevices;
        }

        public List<Device> this[TypeDevice typeDevice]
        {
            get
            {
                // возвращается список девайсов по типу TypeDevice
                List<Device> listDevices = new List<Device>();

                foreach (var d in devices)
                {
                    if (d.TypeDevice == typeDevice)
                    {
                        listDevices.Add(d);
                    }
                }

                return listDevices;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Shop Title: {Title}\n");

            foreach (var d in devices)
            {
                sb.Append(d.ToString() + "\n");
            }

            return sb.ToString();
        }
    }
}
