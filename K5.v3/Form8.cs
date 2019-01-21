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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void close_forma8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calcul_K5_Click(object sender, EventArgs e)
        {
            string prisijungimoEilute = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\vesta\source\repos\K5.v3\K5.v3\K5_DB.mdf; Integrated Security = True";

            SqlConnection sqlPrisijungimas = new SqlConnection(prisijungimoEilute);
           
            string sumuotiKN_Serv_Vid = "SELECT SUM(Kiekis) FROM ParduotosDetales INNER JOIN Komplektai ON ParduotosDetales.DetKodas=Komplektai.KomplektoKodas WHERE Pardavejas='Kauno servisas'";
            string sumuotiKN_Real_Vid = "SELECT SUM(Kiekis) FROM ParduotosDetales INNER JOIN Komplektai ON ParduotosDetales.DetKodas=Komplektai.KomplektoKodas WHERE Pardavejas='Kauno realizacija'";

            string sumuotiKL_Serv_Vid = "SELECT SUM(Kiekis) FROM ParduotosDetales INNER JOIN Komplektai ON ParduotosDetales.DetKodas=Komplektai.KomplektoKodas WHERE Pardavejas='Klaipedos servisas'";
            string sumuotiKL_Real_Vid = "SELECT SUM(Kiekis) FROM ParduotosDetales INNER JOIN Komplektai ON ParduotosDetales.DetKodas=Komplektai.KomplektoKodas WHERE Pardavejas='Klaipedos realizacija'";



            SqlCommand sumavimas_KNserv = new SqlCommand(sumuotiKN_Serv_Vid, sqlPrisijungimas);

            using (sumavimas_KNserv)
            {
                sqlPrisijungimas.Open();
                SqlDataReader reader = sumavimas_KNserv.ExecuteReader();
                while (reader.Read())
                {
                    textBox_KN_serv_kompl_vnt.Text = String.Format("{0}, vnt.", reader[0]);
                    Console.WriteLine(String.Format("{0}, vnt.", reader[0]));
                }
                reader.Close();
                sqlPrisijungimas.Close();
            }

            SqlCommand sumavimas_KNreal = new SqlCommand(sumuotiKN_Real_Vid, sqlPrisijungimas);
            using (sumavimas_KNreal)
            {
                sqlPrisijungimas.Open();
                SqlDataReader reader1 = sumavimas_KNreal.ExecuteReader();
                while (reader1.Read())
                {
                    textBox_KN_real_kompl_vnt.Text = String.Format("{0}, vnt.", reader1[0]);
                    Console.WriteLine(String.Format("{0}, vnt.", reader1[0]));
                }
                reader1.Close();
                sqlPrisijungimas.Close();
            }
        }
    }
}
