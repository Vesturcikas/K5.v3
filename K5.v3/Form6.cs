using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K5.v3
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void connect_Click(object sender, EventArgs e)
        {
            string server_ip_addres = textBox1.Text;
            string port_number = textBox2.Text;
            string db_name = textBox3.Text;
            string user_name = textBox4.Text;
            string user_password = textBox5.Text;
        }
    }
}
