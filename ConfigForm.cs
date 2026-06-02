using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Xml;

namespace WindowsFormsApp1
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            this.Text = "设备参数配置面板";
            this.ClientSize = new Size(500, 420);
            this.StartPosition = FormStartPosition.CenterScreen;

            // 你来拖——告诉我你要放什么控件、放在哪，我帮你算坐标
        }
    }
}
