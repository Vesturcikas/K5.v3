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

        private void atnaujinti_KomplektuDetaliuLentele_Click(object sender, EventArgs e)
        {
            string prisijungimoEilute = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = "+textBox2.Text+"; Integrated Security = True";
            

            System.IO.StreamReader reader = new System.IO.StreamReader(textBox1.Text);

            string line = null;
            string irasymas = "INSERT INTO Komplektu_Detales(DetKodas, DetAnalog1, DetAnalog2, DetAnalog3) VALUES(@DetKodas, @DetAnalog1, @DetAnalog2, @DetAnalog3)";

            while ((line = reader.ReadLine()) != null)
            {
                var data = line.Split(';');
                SqlConnection sqlPrisijungimas = new SqlConnection(prisijungimoEilute);
                SqlCommand komanda = new SqlCommand(irasymas, sqlPrisijungimas);

                using (komanda)
                {
                    
                    komanda.Parameters.AddWithValue("@DetKodas", data[0]);
                    komanda.Parameters.AddWithValue("@DetAnalog1", data[1]);
                    komanda.Parameters.AddWithValue("@DetAnalog2", data[2]);
                    komanda.Parameters.AddWithValue("@DetAnalog3", data[3]);
                    sqlPrisijungimas.Open();
                    int rezult = komanda.ExecuteNonQuery();
                    if (rezult < 0)
                    {
                        Console.WriteLine("Error inserting data into Database!");
                    }
                    sqlPrisijungimas.Close();
                }
            }

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

            textBox2.Text = ofd.FileName;
        }
    }
}


