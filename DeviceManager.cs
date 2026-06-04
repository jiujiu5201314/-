using System;
using System.Collections.Generic;

namespace WindowsFormsApp1
{
    internal class DeviceManager
    {
        private List<Device> _devices = new List<Device>();
        private Dictionary<string, Device> _deviceDictionary = new Dictionary<string, Device>();

        public void AddDevice(Device d)
        {
            _devices.Add(d);
            _deviceDictionary.Add(d.Name, d);
        }

        public List<Device> GetAllDevices()
        {
            return _devices;
        }

        public Device FindByName(string name)
        {
            Device result = null;
            if (_deviceDictionary.TryGetValue(name, out result))
                return result;
            return null;
        }

        public void RemoveByName(string name)
        {
            Device d = FindByName(name);
            if (d == null) return;

            _devices.Remove(d);
            _deviceDictionary.Remove(name);
        }

        public void Clear()
        {
            _devices.Clear();
            _deviceDictionary.Clear();
        }
    }

    class Device
    {
        public string Name { get; set; }
        public string IP { get; set; }
        public int Temp { get; set; }
    }
}
