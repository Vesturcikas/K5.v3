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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
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

        private void perziureti_K5DBParduotuDetaliuLentele_Click(object sender, EventArgs e)
        {
            Form5 forma5 = new Form5();
            this.Close();
            forma5.Show();
        }

        private void papildyti_K5DBParduotuDetaliuLentele_Click(object sender, EventArgs e)
        {
            string prisijungimoEilute = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vesta\source\repos\K5.V3\K5.v3\K5_DB.mdf;Integrated Security=True";

            System.IO.StreamReader reader = new System.IO.StreamReader(textBox2.Text);

            //string trynimas = "DELETE FROM ParduotosDetales";

            string irasymas = "INSERT INTO ParduotosDetales(Id, Data, PardavimoSaskaitosNr, DetKodas, Pavadinimas, Kiekis, Matas, KiekisSuMatu, Pardavejas, PardavimoSuma)" +
                "VALUES(@Id, @Data, @PardavimoSaskaitosNr, @DetKodas, @Pavadinimas, @Kiekis, @Matas, @KiekisSuMatu, @Pardavejas, @PardavimoSuma)";

            string line = null;

            SqlConnection sqlPrisijungimas = new SqlConnection(prisijungimoEilute);

            /*
            SqlCommand komanadaTrinti = new SqlCommand(trynimas, sqlPrisijungimas);

            using (komanadaTrinti)
            {
                sqlPrisijungimas.Open();
                komanadaTrinti.ExecuteNonQuery();
                sqlPrisijungimas.Close();
            }
            */

            while ((line = reader.ReadLine()) != null)
            {
                var data = line.Split(',');

                SqlCommand komandaIrasymas = new SqlCommand(irasymas, sqlPrisijungimas);

                using (komandaIrasymas)
                {
                    komandaIrasymas.Parameters.AddWithValue("@Id", data[0]);
                    komandaIrasymas.Parameters.AddWithValue("@Data", data[1]);
                    komandaIrasymas.Parameters.AddWithValue("@PardavimoSaskaitosNr", data[2]);
                    komandaIrasymas.Parameters.AddWithValue("@DetKodas", data[3]);
                    komandaIrasymas.Parameters.AddWithValue("@Pavadinimas", data[4]);
                    komandaIrasymas.Parameters.AddWithValue("@Kiekis", data[5]);
                    komandaIrasymas.Parameters.AddWithValue("@Matas", data[6]);
                    komandaIrasymas.Parameters.AddWithValue("@KiekisSuMatu", data[7]);
                    komandaIrasymas.Parameters.AddWithValue("@Pardavejas", data[8]);
                    komandaIrasymas.Parameters.AddWithValue("@PardavimoSuma", data[9]);

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

        private void close_forma7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
