using System;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        TextBox tbx = new TextBox();
        ListBox lbx = new ListBox();
        ComboBox cmb = new ComboBox();
        Label lbl = new Label();
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
            btn.Text = "添加";
            btn.Location = new Point(20, 55);
            btn.Size = new Size(80, 30);
            btn.Click += Btn_Click;
            panel.Controls.Add(btn);
            
            tbx.Location = new Point(20, 20);
            tbx.Size = new Size(200, 25);
            tbx.Click += tbx_Click;
            panel.Controls.Add(tbx);
            
            lbx.Location = new Point(20, 95);
            lbx.Size = new Size(200, 200);
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
            lbl.Text = "你选中了：设备1";
            lbl.AutoSize = true;
            group.Controls.Add(lbl);

            this.Controls.Add(panel);
            this.Controls.Add(group);

            var config = new { 设备名 = "PLC1", IP = "192.168.1.1", 端口 = 582};
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(config);
            MessageBox.Show(json);
        }

        private void Btn_Click(object sender,EventArgs e)
        {
            lbx.Items.Add(tbx.Text);
            tbx.Clear();
        }

        private void tbx_Click(object sender,EventArgs e)
        {

        }

        private void Cmb_Changed(object sender,EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            lbl.Text = "你选中:" + cmb.Text;
        }
    }
}
