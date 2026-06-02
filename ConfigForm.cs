using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
    // ===== W2周末项目：可保存配置的参数面板 =====
    // 串起 W2 全部知识点：File IO、Stream、JSON、XML

    public partial class ConfigForm : Form
    {
        // --- 控件 ---
        private TextBox tbxName = new TextBox();
        private TextBox tbxIP = new TextBox();
        private TextBox tbxPort = new TextBox();
        private ComboBox cmbBaud = new ComboBox();
        private ComboBox cmbProtocol = new ComboBox();

        private Button btnSaveJson = new Button();
        private Button btnLoadJson = new Button();
        private Button btnExportXml = new Button();

        private Label lblCurrent = new Label();
        private Label lblStatus = new Label();

        // 操作日志路径
        private string logPath = @"E:\VS\WindowsFormsApp1\config_log.txt";

        public ConfigForm()
        {
            this.Text = "设备参数配置面板 — W2周末项目";
            this.ClientSize = new Size(520, 480);
            this.StartPosition = FormStartPosition.CenterScreen;

            int leftX = 20;
            int rightX = 140;
            int y = 20;
            int gap = 35;

            // --- 设备名称 ---
            AddLabel("设备名称：", leftX, y + 3);
            tbxName.Location = new Point(rightX, y);
            tbxName.Size = new Size(200, 25);
            this.Controls.Add(tbxName);
            y += gap;

            // --- IP地址 ---
            AddLabel("IP 地址：", leftX, y + 3);
            tbxIP.Location = new Point(rightX, y);
            tbxIP.Size = new Size(200, 25);
            this.Controls.Add(tbxIP);
            y += gap;

            // --- 端口号 ---
            AddLabel("端口号：", leftX, y + 3);
            tbxPort.Location = new Point(rightX, y);
            tbxPort.Size = new Size(100, 25);
            this.Controls.Add(tbxPort);
            y += gap;

            // --- 波特率 ---
            AddLabel("波特率：", leftX, y + 3);
            cmbBaud.Location = new Point(rightX, y);
            cmbBaud.Size = new Size(120, 25);
            cmbBaud.Items.AddRange(new object[] { "9600", "19200", "38400", "57600", "115200" });
            cmbBaud.SelectedIndex = 0;
            this.Controls.Add(cmbBaud);
            y += gap;

            // --- 通信协议 ---
            AddLabel("通信协议：", leftX, y + 3);
            cmbProtocol.Location = new Point(rightX, y);
            cmbProtocol.Size = new Size(120, 25);
            cmbProtocol.Items.AddRange(new object[] { "TCP", "SerialPort" });
            cmbProtocol.SelectedIndex = 0;
            this.Controls.Add(cmbProtocol);
            y += gap + 10;

            // --- 按钮行 ---
            btnSaveJson.Text = "JSON 保存";
            btnSaveJson.Location = new Point(leftX, y);
            btnSaveJson.Size = new Size(100, 35);
            btnSaveJson.Click += BtnSaveJson_Click;
            this.Controls.Add(btnSaveJson);

            btnLoadJson.Text = "JSON 加载";
            btnLoadJson.Location = new Point(leftX + 115, y);
            btnLoadJson.Size = new Size(100, 35);
            btnLoadJson.Click += BtnLoadJson_Click;
            this.Controls.Add(btnLoadJson);

            btnExportXml.Text = "XML 另存为";
            btnExportXml.Location = new Point(leftX + 230, y);
            btnExportXml.Size = new Size(100, 35);
            btnExportXml.Click += BtnExportXml_Click;
            this.Controls.Add(btnExportXml);
            y += 50;

            // --- 当前配置显示 ---
            lblCurrent.Location = new Point(leftX, y);
            lblCurrent.Size = new Size(480, 100);
            lblCurrent.BorderStyle = BorderStyle.FixedSingle;
            lblCurrent.Text = "当前配置：未加载";
            this.Controls.Add(lblCurrent);
            y += 115;

            // --- 状态栏 ---
            lblStatus.Location = new Point(leftX, y);
            lblStatus.Size = new Size(480, 25);
            lblStatus.ForeColor = Color.Gray;
            lblStatus.Text = "就绪 — W2D1~D5 知识点综合练习";
            this.Controls.Add(lblStatus);

            // 启动时尝试自动加载
            AutoLoad();
        }

        // --- 快捷加 Label ---
        private void AddLabel(string text, int x, int y)
        {
            Label lbl = new Label();
            lbl.Text = text;
            lbl.Location = new Point(x, y);
            lbl.AutoSize = true;
            this.Controls.Add(lbl);
        }

        // --- 构建配置对象 ---
        private DeviceConfig CollectConfig()
        {
            DeviceConfig cfg = new DeviceConfig();
            cfg.DeviceName = tbxName.Text.Trim();
            cfg.IPAddress = tbxIP.Text.Trim();
            int.TryParse(tbxPort.Text.Trim(), out int port);
            cfg.Port = port;
            cfg.BaudRate = Convert.ToInt32(cmbBaud.SelectedItem);
            cfg.Protocol = cmbProtocol.SelectedItem.ToString();
            return cfg;
        }

        // --- 把配置填回界面 ---
        private void ApplyConfig(DeviceConfig cfg)
        {
            tbxName.Text = cfg.DeviceName;
            tbxIP.Text = cfg.IPAddress;
            tbxPort.Text = cfg.Port > 0 ? cfg.Port.ToString() : "";
            cmbBaud.SelectedItem = cfg.BaudRate.ToString();
            // cmbProtocol 用 FindStringExact
            int idx = cmbProtocol.FindStringExact(cfg.Protocol);
            if (idx >= 0) cmbProtocol.SelectedIndex = idx;

            lblCurrent.Text =
                $"当前配置：\r\n" +
                $"  设备名称：{cfg.DeviceName}\r\n" +
                $"  IP 地址：{cfg.IPAddress}\r\n" +
                $"  端口号：{cfg.Port}\r\n" +
                $"  波特率：{cfg.BaudRate}\r\n" +
                $"  通信协议：{cfg.Protocol}";
        }

        // --- W2D3：JSON 保存 ---
        private void BtnSaveJson_Click(object sender, EventArgs e)
        {
            DeviceConfig cfg = CollectConfig();
            string json = JsonConvert.SerializeObject(cfg, Newtonsoft.Json.Formatting.Indented);
            string filePath = @"E:\VS\WindowsFormsApp1\device_config.json";
            File.WriteAllText(filePath, json);   // W2D1：File 静态方法

            Log("JSON 保存成功 → " + filePath);
            lblStatus.Text = "JSON 已保存 → " + filePath;
        }

        // --- W2D3：JSON 加载 ---
        private void BtnLoadJson_Click(object sender, EventArgs e)
        {
            string filePath = @"E:\VS\WindowsFormsApp1\device_config.json";
            if (!File.Exists(filePath))
            {
                lblStatus.Text = "配置文件不存在，请先保存";
                return;
            }

            string json = File.ReadAllText(filePath);
            DeviceConfig cfg = JsonConvert.DeserializeObject<DeviceConfig>(json);
            ApplyConfig(cfg);

            Log("JSON 加载成功 ← " + filePath);
            lblStatus.Text = "JSON 已加载 ← " + filePath;
        }

        // --- W2D4：XML 另存为 ---
        private void BtnExportXml_Click(object sender, EventArgs e)
        {
            DeviceConfig cfg = CollectConfig();

            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement("DeviceConfig");
            doc.AppendChild(root);

            AddXmlNode(doc, root, "DeviceName", cfg.DeviceName);
            AddXmlNode(doc, root, "IPAddress", cfg.IPAddress);
            AddXmlNode(doc, root, "Port", cfg.Port.ToString());
            AddXmlNode(doc, root, "BaudRate", cfg.BaudRate.ToString());
            AddXmlNode(doc, root, "Protocol", cfg.Protocol);

            string filePath = @"E:\VS\WindowsFormsApp1\device_config.xml";
            doc.Save(filePath);

            Log("XML 导出成功 → " + filePath);
            lblStatus.Text = "XML 已导出 → " + filePath;
        }

        private void AddXmlNode(XmlDocument doc, XmlElement parent, string name, string value)
        {
            XmlElement el = doc.CreateElement(name);
            el.InnerText = value;
            parent.AppendChild(el);
        }

        // --- 启动自动加载 ---
        private void AutoLoad()
        {
            string filePath = @"E:\VS\WindowsFormsApp1\device_config.json";
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                DeviceConfig cfg = JsonConvert.DeserializeObject<DeviceConfig>(json);
                ApplyConfig(cfg);
                lblStatus.Text = "自动加载上次配置 ← " + filePath;
            }
        }

        // --- W2D2：StreamWriter 写操作日志 ---
        private void Log(string msg)
        {
            using (StreamWriter sw = new StreamWriter(logPath, true))
            {
                sw.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss}  {msg}");
            }
        }
    }

    // ===== 配置数据类 =====
    public class DeviceConfig
    {
        public string DeviceName { get; set; }
        public string IPAddress { get; set; }
        public int Port { get; set; }
        public int BaudRate { get; set; }
        public string Protocol { get; set; }
    }
}
