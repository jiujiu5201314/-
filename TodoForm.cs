using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class TodoForm : Form
    {
        private TextBox tbx = new TextBox();
        private Button but = new Button();
        private CheckedListBox clb = new CheckedListBox();
        private Button btnDel = new Button();


        public TodoForm()
        {
            this.Text = "TODO 列表";
            this.ClientSize = new Size(450, 420);

            //输入框
            tbx.Location = new Point(20, 20);
            tbx.Size = new Size(300, 25);
            this.Controls.Add(tbx);

            //添加按钮
            but.Text = "添加";
            but.Location = new Point(330, 18);
            but.Size = new Size(80, 30);
            this.Controls.Add(but);
            but.Click += But_Click;

            //代办列表
            clb.Location = new Point(20, 60);
            clb.Size = new Size(390, 300);
            this.Controls.Add(clb);

            btnDel.Text = "删除已完成";
            btnDel.Location = new Point(20, 370);
            btnDel.Size = new Size(120, 30);
            btnDel.Click += BtnDel_Click;
            this.Controls.Add (btnDel);


        }

        private void But_Click(object sender, EventArgs e)
        {
            clb.Items.Add(tbx.Text);
            tbx.Clear();
        }
        private void BtnDel_Click(object sender,EventArgs e)
        {
            for (int i = clb.Items.Count - 1; i >= 0; i--)
            {
                if (clb.GetItemChecked(i))
                {
                    clb.Items.RemoveAt(i);
                }
            }
        }
    }
}
