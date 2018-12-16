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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'k5_DBDataSet.Komplektu_Detales' table. You can move, or remove it, as needed.
            this.komplektu_DetalesTableAdapter.Fill(this.k5_DBDataSet.Komplektu_Detales);

        }
    }
}
