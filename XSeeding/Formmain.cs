using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace XSeeding
{
    public partial class Formmain : Form
    {
        public Formmain()
        {
            InitializeComponent();
        }
        public static int parentX, parentY;

        private void btnConfig_Click(object sender, EventArgs e)
        {
            FormConfig f = new FormConfig();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            string Content = Interaction.InputBox("Cài đặt ứng dụng", "Setting", "Đường dẫn trình duyệt");
           
            if (Content != null )
            {
                MessageBox.Show("Đường dẫn của bạn: '" + Content +"'");
            }
            
        }
    }
}
