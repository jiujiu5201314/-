using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using NLog;

namespace WindowsFormsApp1
{
    public partial class DeviceBookForm : Form
    {
        private const string SAVE_PATH = @"E:\VS\WindowsFormsApp1\device_book.json";

        private DataGridView dgv = new DataGridView();
        private DeviceManager dm = new DeviceManager();
        private Logger logger = LogManager.GetCurrentClassLogger();

        public DeviceBookForm()
        {
            InitializeComponent();

            dgv.Location = new Point(10, 10);
            dgv.Size = new Size(620, 300);
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.Controls.Add(dgv);

            Button btnAdd = new Button();
            btnAdd.Text = "添加";
            btnAdd.Location = new Point(10, 320);
            btnAdd.Size = new Size(90, 30);
            btnAdd.Click += BtnAdd_Click;
            this.Controls.Add(btnAdd);

            Button btnDelete = new Button();
            btnDelete.Text = "删除";
            btnDelete.Location = new Point(110, 320);
            btnDelete.Size = new Size(90, 30);
            btnDelete.Click += BtnDelete_Click;
            this.Controls.Add(btnDelete);

            Button btnSave = new Button();
            btnSave.Text = "保存JSON";
            btnSave.Location = new Point(210, 320);
            btnSave.Size = new Size(90, 30);
            btnSave.Click += BtnSave_Click;
            this.Controls.Add(btnSave);

            Button btnLoad = new Button();
            btnLoad.Text = "加载JSON";
            btnLoad.Location = new Point(310, 320);
            btnLoad.Size = new Size(90, 30);
            btnLoad.Click += BtnLoad_Click;
            this.Controls.Add(btnLoad);

            logger.Info("设备台账管理器启动");
            LoadFromFile();
            if (dm.GetAllDevices().Count == 0)
            {
                InitDefaultDevices();
            }
            RefreshGrid();
        }

        private void InitDefaultDevices()
        {
            dm.AddDevice(new Device { Name = "PLC1", IP = "192.168.1.101", Temp = 45 });
            dm.AddDevice(new Device { Name = "PLC2", IP = "192.168.1.102", Temp = 38 });
            dm.AddDevice(new Device { Name = "PLC3", IP = "192.168.1.103", Temp = 52 });
            dm.AddDevice(new Device { Name = "PLC4", IP = "192.168.1.104", Temp = 41 });
            dm.AddDevice(new Device { Name = "PLC5", IP = "192.168.1.105", Temp = 49 });
            dm.AddDevice(new Device { Name = "PLC6", IP = "192.168.1.106", Temp = 36 });
            logger.Info("首次运行，已加载 6 台默认设备");
        }

        private void LoadFromFile()
        {
            if (!File.Exists(SAVE_PATH))
                return;

            try
            {
                string json = File.ReadAllText(SAVE_PATH);
                List<Device> list = JsonConvert.DeserializeObject<List<Device>>(json);
                if (list == null)
                {
                    logger.Warn("JSON 文件为空或格式损坏，跳过加载");
                    return;
                }

                dm.Clear();
                foreach (Device d in list)
                {
                    dm.AddDevice(d);
                }
                logger.Info("加载成功，共 " + list.Count + " 台设备");
            }
            catch (Exception ex)
            {
                logger.Error("加载失败：" + ex.Message);
                MessageBox.Show("加载失败：" + ex.Message);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox(
                "请输入：名称,IP,温度", "添加设备", "PLC7,192.168.1.107,50");

            if (string.IsNullOrEmpty(input)) return;

            string[] parts = input.Split(',');
            if (parts.Length < 3)
            {
                MessageBox.Show("格式错误，请按：名称,IP,温度 格式输入");
                return;
            }

            Device dev = new Device();
            dev.Name = parts[0].Trim();
            dev.IP = parts[1].Trim();
            int.TryParse(parts[2].Trim(), out int temp);
            dev.Temp = temp;

            if (dm.FindByName(dev.Name) != null)
            {
                MessageBox.Show("设备 " + dev.Name + " 已存在");
                return;
            }

            dm.AddDevice(dev);
            logger.Info("添加设备：" + dev.Name + " (" + dev.IP + ")");
            RefreshGrid();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先在表格里选一行");
                return;
            }

            object cellValue = dgv.SelectedRows[0].Cells["colName"].Value;
            if (cellValue == null)
            {
                MessageBox.Show("该行数据异常，请刷新后重试");
                return;
            }

            string name = cellValue.ToString();
            dm.RemoveByName(name);
            logger.Info("删除设备：" + name);
            RefreshGrid();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                List<Device> all = dm.GetAllDevices();
                string json = JsonConvert.SerializeObject(all, Formatting.Indented);
                File.WriteAllText(SAVE_PATH, json);
                logger.Info("保存成功，共 " + all.Count + " 台设备");
                MessageBox.Show("保存成功！共 " + all.Count + " 台设备");
            }
            catch (Exception ex)
            {
                logger.Error("保存失败：" + ex.Message);
                MessageBox.Show("保存失败：" + ex.Message);
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            LoadFromFile();
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            dgv.Columns.Clear();
            dgv.Rows.Clear();
            dgv.Columns.Add("colName", "设备名称");
            dgv.Columns.Add("colIP", "IP地址");
            dgv.Columns.Add("colTemp", "温度℃");

            List<Device> all = dm.GetAllDevices();
            foreach (Device d in all)
            {
                dgv.Rows.Add(d.Name, d.IP, d.Temp);
            }
        }
    }
}
