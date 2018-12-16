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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void perziureti_KomplektuDetaliuLentele_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Close();
            form2.Show();
        }

        private void uzdaryti_forma3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void perziureti_KomplektuLentele_Click(object sender, EventArgs e)
        {
            Form4 forma4 = new Form4();
            this.Close();
            forma4.Show();
        }

        private void ieskoti_KomplektuCsvFailo_Click(object sender, EventArgs e)
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

            textBox1.Text = ofd.FileName;
        }

        private void perrasyti_KomplektuLenteleK5DB_Click(object sender, EventArgs e)
        {
            string prisijungimoEilute = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vesta\source\repos\K5.V3\K5.v3\K5_DB.mdf;Integrated Security=True";

            System.IO.StreamReader reader = new System.IO.StreamReader(textBox1.Text);

            string irasymas = "INSERT INTO Komplektai(Id, KomplektoKodas, Pavadinimas, Det1Kodas, Det1Kiekis, Det2Kodas, Det2Kiekis, Det3Kodas, Det3Kiekis," +
                "Det4Kodas, Det4Kiekis, Det5Kodas, Det5Kiekis, Det6Kodas, Det6Kiekis,Det7Kodas, Det7Kiekis, Det8Kodas, Det8Kiekis, Det9Kodas, Det9Kiekis) " +
                "VALUES(@Id, @KomplektoKodas, @Pavadinimas, @Det1Kodas, @Det1Kiekis, @Det2Kodas, @Det2Kiekis, @Det3Kodas, @Det3Kiekis," +
                "@Det4Kodas, @Det4Kiekis, @Det5Kodas, @Det5Kiekis, @Det6Kodas, @Det6Kiekis, @Det7Kodas, @Det7Kiekis, @Det8Kodas, @Det8Kiekis, @Det9Kodas, @Det9Kiekis)";

            string trynimas = "DELETE FROM Komplektai";

            string line = null;

            SqlConnection sqlPrisijungimas = new SqlConnection(prisijungimoEilute);

            SqlCommand komanadaTrinti = new SqlCommand(trynimas, sqlPrisijungimas);

            using (komanadaTrinti)
            {
                sqlPrisijungimas.Open();
                komanadaTrinti.ExecuteNonQuery();
                sqlPrisijungimas.Close();
            }

            while ((line = reader.ReadLine()) != null)
            {
                var data = line.Split(';');

                SqlCommand komandaIrasymas = new SqlCommand(irasymas, sqlPrisijungimas);

                using (komandaIrasymas)
                {
                    komandaIrasymas.Parameters.AddWithValue("@Id", data[0]);
                    komandaIrasymas.Parameters.AddWithValue("@KomplektoKodas", data[1]);
                    komandaIrasymas.Parameters.AddWithValue("@Pavadinimas", data[2]);
                    komandaIrasymas.Parameters.AddWithValue("@Det1Kodas", data[3]);
                    komandaIrasymas.Parameters.AddWithValue("@Det1Kiekis", data[4]);
                    komandaIrasymas.Parameters.AddWithValue("@Det2Kodas", data[5]);
                    komandaIrasymas.Parameters.AddWithValue("@Det2Kiekis", data[6]);
                    komandaIrasymas.Parameters.AddWithValue("@Det3Kodas", data[7]);
                    komandaIrasymas.Parameters.AddWithValue("@Det3Kiekis", data[8]);
                    komandaIrasymas.Parameters.AddWithValue("@Det4Kodas", data[9]);
                    komandaIrasymas.Parameters.AddWithValue("@Det4Kiekis", data[10]);
                    komandaIrasymas.Parameters.AddWithValue("@Det5Kodas", data[11]);
                    komandaIrasymas.Parameters.AddWithValue("@Det5Kiekis", data[12]);
                    komandaIrasymas.Parameters.AddWithValue("@Det6Kodas", data[13]);
                    komandaIrasymas.Parameters.AddWithValue("@Det6Kiekis", data[14]);
                    komandaIrasymas.Parameters.AddWithValue("@Det7Kodas", data[15]);
                    komandaIrasymas.Parameters.AddWithValue("@Det7Kiekis", data[16]);
                    komandaIrasymas.Parameters.AddWithValue("@Det8Kodas", data[17]);
                    komandaIrasymas.Parameters.AddWithValue("@Det8Kiekis", data[18]);
                    komandaIrasymas.Parameters.AddWithValue("@Det9Kodas", data[19]);
                    komandaIrasymas.Parameters.AddWithValue("@Det9Kiekis", data[20]);

                    sqlPrisijungimas.Open();
                    int rezult = komandaIrasymas.ExecuteNonQuery();
                    if (rezult < 0)
                    {
                        Console.WriteLine("Error inserting data into Database!");
                    }
                    sqlPrisijungimas.Close();
                }
            }
            MessageBox.Show("Komplektu sąrašas įrašytas į K5 duomenu bazę.");
        }

        private void ieskoti_ParduotuDetaliuFailo_Click(object sender, EventArgs e)
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

            textBox2.Text = ofd.FileName;
        }

        private void papildyti_K5DBParduotuDetaliuLentele_Click(object sender, EventArgs e)
        {
            string prisijungimoEilute = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vesta\source\repos\K5.V3\K5.v3\K5_DB.mdf;Integrated Security=True";

            System.IO.StreamReader reader = new System.IO.StreamReader(textBox2.Text);

            string trynimas = "DELETE FROM ParduotosDetales";

            string irasymas = "INSERT INTO ParduotosDetales(Id, PardavimoSaskaitosNr, DetKodas, Pavadinimas, Kiekis, Matas, KiekisSuMatu, Pardavejas, PardavimoSuma)" +
                "VALUES(@Id, @PardavimoSaskaitosNr, @DetKodas, @Pavadinimas, @Kiekis, @Matas, @KiekisSuMatu, @Pardavejas, @PardavimoSuma)";

            string line = null;

            SqlConnection sqlPrisijungimas = new SqlConnection(prisijungimoEilute);

            SqlCommand komanadaTrinti = new SqlCommand(trynimas, sqlPrisijungimas);

            using (komanadaTrinti)
            {
                sqlPrisijungimas.Open();
                komanadaTrinti.ExecuteNonQuery();
                sqlPrisijungimas.Close();
            }


            while ((line = reader.ReadLine()) != null)
            {
                var data = line.Split(';');

                SqlCommand komandaIrasymas = new SqlCommand(irasymas, sqlPrisijungimas);

                using (komandaIrasymas)
                {
                    komandaIrasymas.Parameters.AddWithValue("@Id", data[0]);
                    komandaIrasymas.Parameters.AddWithValue("@PardavimoSaskaitosNr", data[1]);
                    komandaIrasymas.Parameters.AddWithValue("@DetKodas", data[2]);
                    komandaIrasymas.Parameters.AddWithValue("@Pavadinimas", data[3]);
                    komandaIrasymas.Parameters.AddWithValue("@Kiekis", data[4]);
                    komandaIrasymas.Parameters.AddWithValue("@Matas", data[5]);
                    komandaIrasymas.Parameters.AddWithValue("@KiekisSuMatu", data[6]);
                    komandaIrasymas.Parameters.AddWithValue("@Pardavejas", data[7]);
                    komandaIrasymas.Parameters.AddWithValue("@PardavimoSuma", data[8]);

                    sqlPrisijungimas.Open();
                    int rezult = komandaIrasymas.ExecuteNonQuery();
                    if (rezult < 0)
                    {
                        Console.WriteLine("Error inserting data into Database!");
                    }
                    sqlPrisijungimas.Close();
                }
            }
            MessageBox.Show("Parduotų detalių sąrašas įrašytas į K5 duomenu bazę.");
        }
    }
}
