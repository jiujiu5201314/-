using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Text;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json;
using System.Xml;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        TextBox tbx = new TextBox();
        ListBox lbx = new ListBox();
        ComboBox cmb = new ComboBox();
        Label lbl = new Label();

        List<(string Name, int Temp)> devices = new List<(string Name, int Temp)>
            {
                ("PLC1", 45),
                ("PLC2", 38),
                ("PLC3", 52),
                ("PLC4", 41),
                ("PLC5", 49),
                ("PLC6", 36)
            };

        ComboBox cmbFilter = new ComboBox();
        ListBox lbxResult = new ListBox();

        public Form1()
        {
            InitializeComponent();

            Panel panel = new Panel();
            panel.Location = new Point(10, 10);
            panel.Size = new Size(350, 300);
            panel.BackColor = Color.LightGray;

            GroupBox group = new GroupBox();
            group.Text = "设备选择";
            group.Location = new Point(370, 10);
            group.Size = new Size(220, 120);

            Button btn = new Button();
            btn.Text = "确定";
            btn.Location = new Point(20, 55);
            btn.Size = new Size(80, 30);
            btn.Click += Btn_Click;
            panel.Controls.Add(btn);

            tbx.Location = new Point(20, 20);
            tbx.Size = new Size(200, 25);
            tbx.Click += tbx_Click;
            panel.Controls.Add(tbx);

            lbx.Location = new Point(20, 160);
            lbx.Size = new Size(200, 130);
            panel.Controls.Add(lbx);

            cmb.Location = new Point(10, 30);
            cmb.Size = new Size(140, 25);
            cmb.Items.Add("设备1");
            cmb.Items.Add("设备2");
            cmb.Items.Add("设备3");
            cmb.SelectedIndex = 0;
            cmb.SelectedIndexChanged += Cmb_Changed;
            group.Controls.Add(cmb);

            lbl.Location = new Point(10, 65);
            lbl.Text = "当前选择：设备1";
            lbl.AutoSize = true;
            group.Controls.Add(lbl);

            this.Controls.Add(panel);
            this.Controls.Add(group);

            cmbFilter.Location = new Point(10, 320);
            cmbFilter.Size = new Size(180, 25);
            cmbFilter.Items.Add("全部");
            cmbFilter.Items.Add("高温（>40℃）");
            cmbFilter.Items.Add("低温（<=40℃）");
            cmbFilter.SelectedIndex = 0;
            cmbFilter.SelectedIndexChanged += CmbFilter_Changed;
            this.Controls.Add(cmbFilter);

            lbxResult.Location = new Point(200, 320);
            lbxResult.Size = new Size(300, 200);
            this.Controls.Add(lbxResult);

            Func<string, string> f = SayHello;
            string result = f("张三");
            MessageBox.Show(result);

            Action<string> a = PrintMsg;
            a("委托学完了");

            Publisher pub = new Publisher();
            pub.OnSomething += (msg) => { MessageBox.Show(msg); };
            pub.DoSomething();

            List<int> number = new List<int> { 5, 12, 3, 8, 21, 7, 15 };
            var w = number.Where(n => n > 10);
            var s = number.Select(n => n * 20);
            var o = number.OrderBy(n => n);
            var g = number.GroupBy(n => n % 2 == 0 ? "偶数" : "奇数");

            MessageBox.Show(
                ">10: " + string.Join(", ", w) + "\n" +
                "乘2: " + string.Join(", ", s) + "\n" +
                "排序: " + string.Join(", ", o));

            var r1 = devices
                .Where(d => d.Temp > 40)
                .OrderByDescending(d => d.Temp)
                .Select(d => d.Name);
            MessageBox.Show("温度>40的设备：\n\n" + string.Join(",", r1));

            Button btnSave = new Button();
            btnSave.Text = "保存";
            btnSave.Location = new Point(110, 55);
            btnSave.Size = new Size(80, 30);
            panel.Controls.Add(btnSave);
            btnSave.Click += btnSave_Click;

            Button btnLoad = new Button();
            btnLoad.Text = "加载";
            btnLoad.Location = new Point(200, 55);
            btnLoad.Size = new Size(80, 30);
            btnLoad.Click += btnLoad_Click;
            panel.Controls.Add(btnLoad);

            Button btnSaveJson = new Button();
            btnSaveJson.Text = "JSON保存";
            btnSaveJson.Location = new Point(110, 90);
            btnSaveJson.Size = new Size(80, 30);
            btnSaveJson.Click += btnSaveJson_Click;
            panel.Controls.Add(btnSaveJson);

            Button btnLoadJson = new Button();
            btnLoadJson.Text = "JSON加载";
            btnLoadJson.Location = new Point(200, 90);
            btnLoadJson.Size = new Size(80, 30);
            btnLoadJson.Click += btnLoadJson_Click;
            panel.Controls.Add(btnLoadJson);

            Button btnSaveXml = new Button();
            btnSaveXml.Text = "XML保存";
            btnSaveXml.Location = new Point(110, 125);
            btnSaveXml.Size = new Size(80, 30);
            btnSaveXml.Click += btnSaveXml_Click;
            panel.Controls.Add(btnSaveXml);

            Button btnLoadXml = new Button();
            btnLoadXml.Text = "XML加载";
            btnLoadXml.Location = new Point(200, 125);
            btnLoadXml.Size = new Size(80, 30);
            btnLoadXml.Click += btnLoadXml_Click;
            panel.Controls.Add(btnLoadXml);

            // ===== W2D5：配置持久化 - 加载 =====
            if (File.Exists(@"E:\VS\WindowsFormsApp1\config.json"))
            {
                string json = File.ReadAllText(@"E:\VS\WindowsFormsApp1\config.json");
                AppConfig config = JsonConvert.DeserializeObject<AppConfig>(json);
                tbx.Text = config.LastText;
                cmb.SelectedIndex = config.SelectedDevice;
                cmbFilter.SelectedIndex = cmbFilter.FindStringExact(config.FilterMode);
            }

            // 绑定窗口关闭事件：关了自动保存
            this.FormClosing += Form1_FormClosing;
        }


        private void Btn_Click(object sender, EventArgs e)
        {
            lbx.Items.Add(tbx.Text);
            tbx.Clear();
        }


        private void tbx_Click(object sender, EventArgs e)
        {

        }


        private void Cmb_Changed(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            lbl.Text = "当前选择:" + cmb.Text;
        }


        private string SayHello(string name)
        {
            return "你好," + name;
        }


        private void PrintMsg(string msg)
        {
            MessageBox.Show(msg);
        }


        private void CmbFilter_Changed(object sender, EventArgs e)
        {
            lbxResult.Items.Clear();
            if (cmbFilter.SelectedIndex == 0)
            {
                foreach (var d in devices)
                {
                    lbxResult.Items.Add($"{d.Name} - {d.Temp}℃");
                }
            }
            else if (cmbFilter.SelectedIndex == 1)
            {
                foreach (var d in devices)
                {
                    if (d.Temp > 40)
                        lbxResult.Items.Add($"{d.Name} - {d.Temp}℃");
                }
            }
            else
            {
                foreach (var d in devices)
                {
                    if (d.Temp <= 40)
                        lbxResult.Items.Add($"{d.Name} - {d.Temp}℃");
                }
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(@"E:\data.txt"))
            {
                foreach (var Items in lbx.Items)
                {
                    sw.WriteLine(Items.ToString());
                }
            }
            MessageBox.Show("保存成功");
        }


        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(@"E:\data.txt"))
            {
                lbx.Items.Clear();
                string line;
                while ((line = sr.ReadLine()) != null)
                    lbx.Items.Add(line);
            }
        }

        private void btnSaveJson_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            foreach (var item in lbx.Items)
            {
                list.Add(item.ToString());
            }
            string json = JsonConvert.SerializeObject(list);
            File.WriteAllText(@"E:\VS\WindowsFormsApp1\data.json", json);
            MessageBox.Show("JSON保存成功");
        }

        private void btnLoadJson_Click(object sender, EventArgs e)
        {
            string json = File.ReadAllText(@"E:\VS\WindowsFormsApp1\data.json");
            dynamic obj = JsonConvert.DeserializeObject<dynamic>(json);
            lbx.Items.Clear();
            foreach (var item in obj)
            {
                lbx.Items.Add(item.ToString());
            }
        }

        private void btnSaveXml_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement("items");
            doc.AppendChild(root);
            foreach (var item in lbx.Items)
            {
                XmlElement xmlItem = doc.CreateElement("item");
                xmlItem.InnerText = item.ToString();
                root.AppendChild(xmlItem);
            }
            doc.Save(@"E:\VS\WindowsFormsApp1\data.xml");
            MessageBox.Show("XML保存成功");
        }

        private void btnLoadXml_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"E:\VS\WindowsFormsApp1\data.xml");
            XmlNodeList itemNodes = doc.GetElementsByTagName("item");
            lbx.Items.Clear();
            foreach (XmlNode node in itemNodes)
            {
                lbx.Items.Add(node.InnerText);
            }
        }

        // ===== W2D5：配置持久化 - 保存（窗口关闭时自动触发） =====
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            AppConfig config = new AppConfig();
            config.LastText = tbx.Text;
            config.SelectedDevice = cmb.SelectedIndex;
            config.FilterMode = cmbFilter.Text;

            string json = JsonConvert.SerializeObject(config);
            File.WriteAllText(@"E:\VS\WindowsFormsApp1\config.json", json);
        }
    }

    // ===== W2D5：配置类 - 一个存数据的袋子 =====
    public class AppConfig
    {
        public string LastText;       // 上次输入的文字
        public int SelectedDevice;    // 上次选了第几个设备
        public string FilterMode;     // 上次选的筛选模式
    }
}
