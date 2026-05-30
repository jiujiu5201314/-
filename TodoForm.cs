using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class TodoForm : Form
    {
        public TodoForm()
        {
            this.Text = "TODO 列表";
            this.ClientSize = new Size(450, 420);

            TextBox tbx = new TextBox();
            tbx.Location = new Point(20, 20);
            tbx.Size = new Size(300, 25);
            this.Controls.Add (tbx);

            Button but = new Button();
            but.Text = "添加";
            but.Location = new Point(330, 18);
            but.Size = new Size(80, 30);
            this.Controls.Add (but);

            CheckedListBox clb = new CheckedListBox();
            clb.Location = new Point(20, 60);
            clb.Size = new Size(390, 300);
            this.Controls.Add (clb);
        }
    }
}
