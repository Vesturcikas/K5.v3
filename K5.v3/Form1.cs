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

        private void Ieskoti_KomplektoDetaliu_Click(object sender, EventArgs e)
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

        /*
        private void atnaujinti_KomplektuDetaliuLentele_Click(object sender, EventArgs e)
        {
            string prisijungimoEilute = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = "+textBox2.Text+"; Integrated Security = True";

            System.IO.StreamReader reader = new System.IO.StreamReader(textBox1.Text);

            string line = null;
            string naujasAnalog1=null;
            string naujasAnalog2=null;
            string naujasAnalog3=null;
            string detKodas=null;

            string atnaujinimas = "UPDATE Komplektu_Detales SET DetAnalog1 ="+naujasAnalog1+" , DetAnalog2 ="+naujasAnalog2+", DetAnalog3 = "+naujasAnalog3+"WHERE DetKodas ="+detKodas;
            
            string isrinkimas = "SELECT * FROM Komlektu_Detales WHERE DetKodas =" + detKodas;

            while ((line = reader.ReadLine()) != null)
            {
                var data = line.Split(';');

                detKodas = data[0];
                naujasAnalog1 = data[1];
                naujasAnalog2 = data[2];
                naujasAnalog3 = data[3];

                SqlConnection sqlPrisijungimas = new SqlConnection(prisijungimoEilute);
                SqlCommand komndaIsrinkimas = new SqlCommand(isrinkimas, sqlPrisijungimas);
                SqlDataReader nuskaitymas = null;
                sqlPrisijungimas.Open();
                nuskaitymas = komndaIsrinkimas.ExecuteReader();

                
                sqlPrisijungimas.Close();
                
            }

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

            textBox2.Text = ofd.FileName;
        }

        private void irasyti_KomplektuDetaliuLentele_Click(object sender, EventArgs e)
        {
            string prisijungimoEilute = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " + textBox2.Text + "; Integrated Security = True";
            System.IO.StreamReader reader = new System.IO.StreamReader(textBox1.Text);
            string irasymas = "INSERT INTO Komplektu_Detales(DetKodas, DetAnalog1, DetAnalog2, DetAnalog3) VALUES(@DetKodas, @DetAnalog1, @DetAnalog2, @DetAnalog3)";
            string trynimas = "DELETE FROM Komplektu_Detales";
            string line = null;
            SqlConnection sqlPrisijungimas = new SqlConnection(prisijungimoEilute);

            SqlCommand komanadaTrinti =new SqlCommand(trynimas, sqlPrisijungimas);

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
                   komandaIrasymas.Parameters.AddWithValue("@DetKodas", data[0]);
                   komandaIrasymas.Parameters.AddWithValue("@DetAnalog1", data[1]);
                   komandaIrasymas.Parameters.AddWithValue("@DetAnalog2", data[2]);
                   komandaIrasymas.Parameters.AddWithValue("@DetAnalog3", data[3]);
                   sqlPrisijungimas.Open();
                   int rezult = komandaIrasymas.ExecuteNonQuery();
                   if (rezult < 0)
                   {
                      Console.WriteLine("Error inserting data into Database!");
                   }     
                   sqlPrisijungimas.Close();
                }   
            }
            MessageBox.Show("Komplektu detalių sąrašas įrašytas į K5 duomenu bazę.");
        }
    }
}


