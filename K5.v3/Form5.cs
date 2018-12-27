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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'k5_DBDataSet2.ParduotosDetales' table. You can move, or remove it, as needed.
            this.parduotosDetalesTableAdapter.Fill(this.k5_DBDataSet2.ParduotosDetales);
            // TODO: This line of code loads data into the 'k5_DBDataSet2.ParduotosDetales' table. You can move, or remove it, as needed.
            this.parduotosDetalesTableAdapter.Fill(this.k5_DBDataSet2.ParduotosDetales);

        }

        private void uzdaryti_ParduotuDetLentele_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void parduotosDetalesBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
