using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_Message
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Timebutton_Click(object sender, EventArgs e)
        {
            Showlabel.Text = DateTime.Now.ToString("你好現在時間 yyyy/MM/dd' 'HH:mm:ss");
            MessageBox.Show(Showlabel.Text);
        }

        private void Hibutton_Click(object sender, EventArgs e)
        {
            Hilabel.Text = DateTime.Now.ToString("你好現在時間 \r\n yyyy/MM/dd' 'HH:mm:ss");
        }
    }
}
