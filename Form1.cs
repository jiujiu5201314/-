using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Dapper;
using System.Linq;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void dgvDevices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dgvDevices.CurrentRow.Cells[1].Value.ToString();
            txtIP.Text = dgvDevices.CurrentRow.Cells[2].Value.ToString();
            txtProtocol.Text = dgvDevices.CurrentRow.Cells[3].Value.ToString();
            txtPosition.Text = dgvDevices.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e) //新增设备
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("设备名称不能为空");
                return;
            }

            string connStr = @"Server=.\SQLEXPRESS; Database=DeviceManagerDB; Integrated Security=True;";
            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();
                int count = conn.ExecuteScalar<int>(
                    "SELECT COUNT(*) FROM DeviceConfig WHERE DeviceName = @name",
                    new { name = txtName.Text });
                if (count > 0)
                {
                    MessageBox.Show("设备名已存在");
                    return;
                }
                conn.Execute("INSERT INTO DeviceConfig (DeviceName,IP,Protocol,Position) VALUES (@DeviceName,@IP,@Protocol,@Position)",
                    new { DeviceName = txtName.Text, IP = txtIP.Text, Protocol = txtProtocol.Text, Position = txtPosition.Text });
                MessageBox.Show("新增成功");
                btnQuery_Click(null, null);
                txtName.Clear();
                txtIP.Clear();
                txtProtocol.Clear();
                txtPosition.Clear();
            }
        }

        private void btnQuery_Click(object sender, EventArgs e) //查询全部
        {
            string connStr = @"Server=.\SQLEXPRESS; Database=DeviceManagerDB; Integrated Security=True;";
            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();
                var list = conn.Query<DeviceConfig>("SELECT * FROM DeviceConfig").ToList();
                dgvDevices.DataSource = list;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e) //搜索
        {
            string connStr = @"Server=.\SQLEXPRESS; Database=DeviceManagerDB; Integrated Security=True;";
            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();
                var list = conn.Query<DeviceConfig>("SELECT * FROM DeviceConfig WHERE DeviceName LIKE @K", new { k = "%" + txtSearch.Text + "%" }).ToList();
                dgvDevices.DataSource = list;
            }
        }

        private void button1_Click(object sender, EventArgs e) //删除设备
        {
            string connStr = @"Server=.\SQLEXPRESS; Database=DeviceManagerDB; Integrated Security=True;";
            using (var conn = new SqlConnection(connStr))
            {
                DialogResult result = MessageBox.Show("确认删除？", "警告", MessageBoxButtons.YesNo);
                if (result == DialogResult.No) return;
                conn.Open();
                int id = Convert.ToInt32(dgvDevices.CurrentRow.Cells[0].Value);
                conn.Execute("DELETE FROM DeviceConfig WHERE Id = @Id", new { Id = id });
                conn.Execute("INSERT INTO DebugLog (ActionType,Detail) VALUES (@t,@d)",
                    new { t = "删除", d = $"删除了 Id={id} 的设备" });
                MessageBox.Show("删除成功");
                btnQuery_Click(null, null);
            }
        }

        private void button2_Click(object sender, EventArgs e) //修改设备
        {
            string connStr = @"Server=.\SQLEXPRESS; Database=DeviceManagerDB; Integrated Security=True;";
            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();
                int id = Convert.ToInt32(dgvDevices.CurrentRow.Cells[0].Value);
                conn.Execute("UPDATE DeviceConfig SET DeviceName=@n, IP=@ip, Protocol=@pr, Position=@po WHERE Id=@id",
                    new { n = txtName.Text, ip = txtIP.Text, pr = txtProtocol.Text, po = txtPosition.Text, id = id });
                conn.Execute("INSERT INTO DebugLog (ActionType,Detail) VALUES (@t,@d)",
                    new { t = "修改", d = $"修改了 Id={id} 的设备" });
                MessageBox.Show("修改成功");
                btnQuery_Click(null, null);
            }
        }
    }

    public class DeviceConfig
    {
        public int Id { get; set; }
        public string DeviceName { get; set; }
        public string IP { get; set; }
        public string Protocol { get; set; }
        public string Position { get; set; }
    }
}
