using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaktarkeszletNyilvantarto
{
    public partial class Bejelentkezes : Form
    {
        
        
        public Bejelentkezes()
        {
            InitializeComponent();
            
            
        }

        private void buttonBelepes_Click(object sender, EventArgs e)
        {
            string jelszoCredentialCheck = "";
            string felhasznevCredentialcheck = "";

            string BejelentkezesNev = textBoxFhn.Text;
            string JelszoBejelentkezes = textBoxjelsz.Text;

            jelszoCredentialCheck = $"SELECT jelszo FROM Felhasznalok WHERE Felhasznalonev = '{BejelentkezesNev}'";
            felhasznevCredentialcheck = $"SELECT felhasznalonev FROM Felhasznalok WHERE Felhasznalonev = '{BejelentkezesNev}'";
            // felhasznév, jelszo kivétele sqlből

            SqlConnection kapcsolat = new SqlConnection(Foablak.kapcsolatString);

            kapcsolat.Open();

            SqlDataAdapter data = new SqlDataAdapter();
            //data.

            SqlCommand jelszoBekero = new SqlCommand(jelszoCredentialCheck, kapcsolat);
            string eredmeny = (string)jelszoBekero.ExecuteScalar();

            SqlCommand felhasznevBekero = new SqlCommand(felhasznevCredentialcheck, kapcsolat);
            string eredmeny2 = (string)felhasznevBekero.ExecuteScalar(); 

            kapcsolat.Close();

            SHA256 sha256 = SHA256.Create();
            byte[] szovegnek = Encoding.ASCII.GetBytes(JelszoBejelentkezes);

            byte[] sha256hash = sha256.ComputeHash(szovegnek);
            string ki = "";
            foreach (byte bajtok in sha256hash)
            {
                ki += bajtok.ToString("X2");
            }

            string Sha = ki;

            if (Sha == eredmeny && BejelentkezesNev == eredmeny2)
            {
                Foablak frmFoAblak = new Foablak();
                frmFoAblak.ShowDialog();
                textBoxFhn.Text = "";
                textBoxjelsz.Text = "";
            }
            else
            {
                MessageBox.Show("Hibás felhasználónév vagy jelszó!");
            }

        }


    }
}
