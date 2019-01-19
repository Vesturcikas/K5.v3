using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace K5.v3
{
    public partial class K5skaiciavimas : Form
    {
        

        public K5skaiciavimas()
        {
            InitializeComponent();
        }

        /*
        private void Prisijungti_Click(object sender, EventArgs e)
        {
            string prisijungimoEilute = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\vesta\source\repos\K5.v3\K5.v3\Database1.mdf; Integrated Security = True";
            SqlConnection sqlPrisijungimas = new SqlConnection(prisijungimoEilute);

            MessageBox.Show("Prisijungta prie K5 skaičivimo duomenu bazės.");

            
            sqlPrisijungimas.Open();
            MessageBox.Show("Prisijungimas atidarytas.");

            sqlPrisijungimas.Close();
            MessageBox.Show("Prisijungimas uždarytas.");
            
        }*/

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
            string prisijungimoEilute = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\vesta\source\repos\K5.v3\K5.v3\K5_DB.mdf; Integrated Security = True";

            SqlConnection sqlPrisijungimas = new SqlConnection(prisijungimoEilute);

            //string sujungti_Vid = "SELECT Komplektai.Id, ParduotosDetales.Id, PardavimoSaskaitosNr, DetKodas, Kiekis, Pardavejas FROM ParduotosDetales INNER JOIN Komplektai ON ParduotosDetales.DetKodas=Komplektai.KomplektoKodas WHERE Pardavejas='KN-Serv'";
            string sumuotiKN_Serv_Vid = "SELECT SUM(Kiekis) FROM ParduotosDetales INNER JOIN Komplektai ON ParduotosDetales.DetKodas=Komplektai.KomplektoKodas WHERE Pardavejas='Kauno servisas'";
            string sumuotiKN_Real_Vid = "SELECT SUM(Kiekis) FROM ParduotosDetales INNER JOIN Komplektai ON ParduotosDetales.DetKodas=Komplektai.KomplektoKodas WHERE Pardavejas='Kauno realizacija'";

            SqlCommand sumavimas_KNserv = new SqlCommand(sumuotiKN_Serv_Vid, sqlPrisijungimas);

            using (sumavimas_KNserv)
            {
                sqlPrisijungimas.Open();
                SqlDataReader reader = sumavimas_KNserv.ExecuteReader();
                while (reader.Read())
                {
                    //textBox_KN_serv_kompl_vnt.Text = String.Format("{0}, vnt.", reader[0]);
                    Console.WriteLine(String.Format("{0}, vnt.", reader[0])); 
                }

                sqlPrisijungimas.Close();
            }

            SqlCommand sumavimas_KNreal = new SqlCommand(sumuotiKN_Real_Vid, sqlPrisijungimas);
            using (sumavimas_KNreal)
            {
                sqlPrisijungimas.Open();

                SqlDataReader reader1 = sumavimas_KNreal.ExecuteReader();
                while (reader1.Read())
                {
                   // textBox_KN_real_kompl_vnt.Text = String.Format("{0}, vnt.", reader1[0]);
                    Console.WriteLine(String.Format("{0}, vnt.", reader1[0]));
                }
                reader1.Close();
                sqlPrisijungimas.Close();
            }
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
    }
}


