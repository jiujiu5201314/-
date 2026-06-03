using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            try
            {
                string content = File.ReadAllText(@"F:\data.txt");
                MessageBox.Show(content);
            }
            catch (Exception)
            {
                MessageBox.Show("文件读取失败sb");
            }
            InitializeComponent();
            List<Device> lis = new List<Device>();
            lis.Add(new Device { Name = "PLC1", IP = "192.168.1.101", Temp = 45 });
            lis.Add(new Device { Name = "PLC2", IP = "192.168.1.102", Temp = 38 });
            lis.Add(new Device { Name = "PLC3", IP = "192.168.1.103", Temp = 52 });
            lis.Add(new Device { Name = "PLC4", IP = "192.168.1.104", Temp = 41 });
            lis.Add(new Device { Name = "PLC5", IP = "192.168.1.105", Temp = 49 });
            lis.Add(new Device { Name = "PLC6", IP = "192.168.1.106", Temp = 36 });

            string result = "";
            foreach (Device d in lis)
            {
                result += d.Name + " " + d.Temp + "°C\n";
            }
            MessageBox.Show(result);

            Dictionary<string, Device> dic = new Dictionary<string, Device>();
            dic.Add("PLC1", new Device { Name = "PLC1", IP = "192.168.1.101", Temp = 45 });
            dic.Add("PLC2", new Device { Name = "PLC2", IP = "192.168.1.102", Temp = 38 });
            dic.Add("PLC3", new Device { Name = "PLC3", IP = "192.168.1.103", Temp = 52 });
            dic.Add("PLC4", new Device { Name = "PLC4", IP = "192.168.1.104", Temp = 41 });
            dic.Add("PLC5", new Device { Name = "PLC5", IP = "192.168.1.105", Temp = 49 });
            dic.Add("PLC6", new Device { Name = "PLC6", IP = "192.168.1.106", Temp = 36 });

            Device dev;
            if (dic.TryGetValue("PLC3", out dev))
            {
                MessageBox.Show(dev.Name + " " + dev.Temp + "°C");
            }
            Queue<Device> q = new Queue<Device>();
            q.Enqueue(new Device { Name = "PLC1", IP = "192.168.1.101", Temp = 45 });
            q.Enqueue(new Device { Name = "PLC2", IP = "192.168.1.102", Temp = 38 });
            q.Enqueue(new Device { Name = "PLC3", IP = "192.168.1.103", Temp = 52 });
            q.Enqueue(new Device { Name = "PLC4", IP = "192.168.1.104", Temp = 41 });
            q.Enqueue(new Device { Name = "PLC5", IP = "192.168.1.105", Temp = 49 });
            q.Enqueue(new Device { Name = "PLC6", IP = "192.168.1.106", Temp = 36 });

            Device first = q.Dequeue();
            Device second = q.Dequeue();
            Device third = q.Dequeue();
            MessageBox.Show("First: " + first.Name + " " + first.Temp + "°C\nSecond: " + second.Name + " " + second.Temp + "°C\nThird: " + third.Name + " " + third.Temp + "°C");

            using (StreamReader sr = new StreamReader(@"E:\VS\WindowsFormsApp1\config_log.txt"))
            {
                string line = sr.ReadLine();
                MessageBox.Show("读到了" + line);
            }
        }
    }
    class Device
    {
        public string Name { get; set; }
        public string IP { get; set; }
        public int Temp { get; set; }
    }


}
