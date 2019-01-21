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
    public partial class K5skaiciavimas : Form
    {
        

        public K5skaiciavimas()
        {
            InitializeComponent();
        }

        private void ieskoti_K5DuomenuBazes_Click(object sender, EventArgs e)
        {
            string path = null;
            OpenFileDialog ofd = new OpenFileDialog();

            using (ofd)
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    path = ofd.FileName;
                }
            }

            //textBox2.Text = ofd.FileName;
        }

        private void perziureti_K5DuomenuBaze_Click(object sender, EventArgs e)
        {
            Form3 forma3 = new Form3();
            forma3.Show();
        }

        private void uzdaryti_forma1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void skaiciuoti_K5_Click(object sender, EventArgs e)
        {
            Form8 forma8 = new Form8();
            forma8.Show();
        }

        private void conect_to_as2008_Click(object sender, EventArgs e)
        {
            Form6 forma6 = new Form6();
            forma6.Show();
        }

        private void apieProgramąToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programa skirta suskaičiuoti padaliniuose parduotų komplektų kiekius ir jų procentus.");
        }

        private void autoriusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programos autorius: Vestūras Stanevičius.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 forma7 = new Form7();
            forma7.Show();
        }
    }
}


