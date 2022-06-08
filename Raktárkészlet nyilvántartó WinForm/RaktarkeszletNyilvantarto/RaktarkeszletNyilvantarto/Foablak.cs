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

    public partial class Foablak : Form
    {

        
        public static string kapcsolatString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\adatbazisraktar.mdf;Integrated Security=True;Connect Timeout=30";
         
        string eszkozNev,eszkozAllapot = "", tulajdonos = "",eszkoztipusa = "",gyarto = "",jegyzet = "", serial = "", model = "", computerName = "", mac = "", os = "", cpu = "", gpu = "";        
        int tulajdonosId,ram = 0, hdd = 0;
        DateTime kiadasiIdopont = DateTime.Now;
        DateTime garanciaLejaratiido=DateTime.Now;
        public Foablak()
        {
            InitializeComponent();
            
        }

        private void adatMegjelen()
        {
            
            string sqlAlapLekerdezes = "SELECT Eszkozok.Id as EszkozIndex, Eszkoz_Nev, EszkozAllapot, Eszkoz_Tipus, Serial_szam, Model_szam, Gyarto, Felhasznalonev,Kiadasi_idopont, Garancia_lejarata, Leiras_jegyzet FROM Eszkozok, Felhasznalok WHERE Eszkozok.Tulajdonos_Id = Felhasznalok.FelhasznId ORDER BY Eszkozok.Id";
            //string sqlUpdate = "UPDATE Eszkozok ";
            SqlDataAdapter da = new SqlDataAdapter(sqlAlapLekerdezes, kapcsolatString);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewOsszesito2.DataSource = dt;

            //string idSzam = "SELECT Eszkozok.Id";

            
        }

        private void tabPage8_Enter(object sender, EventArgs e)
        {
            
            DialogResult kerdes = MessageBox.Show("Biztosan kijelentkezik?", "Kijelentkezés", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            
            if (kerdes == DialogResult.Yes)
            {
                Close();
                
            }
            else
            {
                tabControl1.SelectedIndex = 0;

            }
            
        }



        private void Foablak_Load(object sender, EventArgs e)
        {
            adatMegjelen();
        }

        private void buttonTermekhozzaadasa_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void buttonTorles_Click(object sender, EventArgs e)
        {
            /*
            MessageBox.Show("Figyelem, törlési kísérlet, a folytatáshoz, add meg a megjelenő szövegbuborékban a TabIndexet, majd kattints a Törlés gombra.");
            textBoxTorles.Visible = true;
            buttonTorlesBiztos.Visible = true;
            */
            //int sikeresE = 0;
            string torlesId = textBoxTorles.Text;
            int es = 0;
            DialogResult torloGomb = MessageBox.Show("Biztosan törölni szeretnéd a kiválasztott adatsort?", "FIGYELEM: termék törlése", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (torloGomb == DialogResult.Yes)
            {
                try
                {
                    if (int.Parse(textBoxTorles.Text) >= 0)
                    {
                        try
                        {
                            using (SqlConnection connection = new SqlConnection(kapcsolatString))
                            {


                                connection.Open();
                                string sql = $"DELETE FROM Eszkozok where Eszkozok.Id = {torlesId}";
                                using (SqlCommand cmd = new SqlCommand(sql, connection))
                                {

                                    cmd.CommandType = CommandType.Text;
                                    cmd.ExecuteNonQuery();
                                    //sikeresE += 1;

                                }
                                /*

                                connection.Open();
                                string sqlCheck = $"SELECT SELECT Eszkozok.Id FROM Eszkozok WHERE Eszkozok.Id = ANY";
                                SqlCommand cmd2 = new SqlCommand(sql, connection)

                                */




                                

                                textBoxTorles.Clear();
                            }
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Nem megfelelő Index, nem sikerült a törlés!");
                            es++;
                        }

                        adatNullaz();
                        adatMegjelen();
                    }
                    else
                    {
                        MessageBox.Show("Nem lehet minusz szám!");
                        es++;
                        
                    }
                }
                catch (Exception)
                {

                    
                    MessageBox.Show("Nem számot adtál meg!");
                    es++;
                }
                if (es==0)
                {
                    MessageBox.Show("A törlés sikeres!");
                    
                }
                else
                {
                    MessageBox.Show("A törlés nem sikerült!");
                }
                

            }
        }

        private void dataGridViewOsszesito2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int hosszusag = labelsortema.Text.Length;
            int sor = e.RowIndex;
            int oszl = e.ColumnIndex;
            DataGridView dgv = (DataGridView)sender;//

            //dataGridViewOsszesito2 dt = (dataGridViewOsszesito2)sender;
        }

        private void adatNullaz()
        {
            // nem vonhato ossze az adatMegjelennel!
            dataGridViewOsszesito2.DataSource = null;
        }

        // combobox adat
        #region
        private void comboBoxEszkoztipusaFelvitel_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            eszkoztipusa = comboBoxEszkoztipusaFelvitel.Text;
        }

        private void comboBoxEszkozallapotaFelvitel_SelectedIndexChanged(object sender, EventArgs e)
        {
            eszkozAllapot = comboBoxEszkozallapotaFelvitel.Text;
        }

        private void comboBoxGyarto_SelectedIndexChanged(object sender, EventArgs e)
        {            
            gyarto = comboBoxGyarto.Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            tulajdonos = comboBoxTulajdonos.Text;            
            tulajdonosId = comboBoxTulajdonos.SelectedIndex + 1;
        }

        private void dateTimePickerKiadasiidopont_ValueChanged(object sender, EventArgs e)
        {            
            kiadasiIdopont = dateTimePickerKiadasiidopont.Value.Date;
        }

        private void dateTimePickerGarancialejaratiido_ValueChanged(object sender, EventArgs e)
        {            
            garanciaLejaratiido = dateTimePickerGarancialejaratiido.Value.Date;
        }

        private void comboBoxOperaciosrendszerfelvitel_SelectedIndexChanged(object sender, EventArgs e)
        {            
            os = comboBoxOperaciosrendszerfelvitel.Text;
        }

        private void comboBoxCpuFelvitel_SelectedIndexChanged(object sender, EventArgs e)
        {            
            cpu = comboBoxCpuFelvitel.Text; 
        }

        private void comboBoxRamFelvitel_SelectedIndexChanged(object sender, EventArgs e)
        {            
            ram = int.Parse(comboBoxRamFelvitel.Text);
        }

        private void comboBoxHddFelvitel_SelectedIndexChanged(object sender, EventArgs e)
        {            
            hdd = int.Parse(comboBoxHddFelvitel.Text);
        }

        private void comboBoxGpuFelvitel_SelectedIndexChanged(object sender, EventArgs e)
        {            
            gpu = comboBoxGpuFelvitel.Text;
        }
        #endregion
        
        private void buttonfelvitel_Click(object sender, EventArgs e)
        {
            
            eszkozNev = textBoxEszkozneve.Text;
            jegyzet = textBoxLeirasjegyzet.Text;
            serial = textBoxSeriaszam.Text;
            model = textBoxModelszam.Text;
            computerName = textBoxComputerneve.Text;
            mac = textBoxMac.Text;

            if (textBoxEszkozneve.Text != "" && comboBoxTulajdonos.Text != "")
            {
                using (SqlConnection connection = new SqlConnection(kapcsolatString))
                {
                    connection.Open();
                    string sql = "INSERT INTO Eszkozok(Eszkoz_Nev,Eszkoz_Tipus,EszkozAllapot,Gyarto,Leiras_jegyzet,Tulajdonos_Id,Serial_szam,Model_szam,Os,Computer_name,Cpu,Ram,Hdd,Mac,Gpu,Kiadasi_idopont,Garancia_lejarata) VALUES(@Eszkoz_Nev,@Eszkoz_Tipus,@EszkozAllapot,@Gyarto,@Leiras_jegyzet,@Tulajdonos_Id,@Serial_szam,@Model_szam,@Os,@Computer_name,@Cpu,@Ram,@Hdd,@Mac,@Gpu,@Kiadasi_idopont,@Garancia_lejarata)";
                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.Add("@Eszkoz_Nev", SqlDbType.VarChar, 20).Value = eszkozNev;
                        cmd.Parameters.Add("@Eszkoz_Tipus", SqlDbType.VarChar, 20).Value = eszkoztipusa;
                        cmd.Parameters.Add("@EszkozAllapot", SqlDbType.VarChar, 21).Value = eszkozAllapot;
                        cmd.Parameters.Add("@Gyarto", SqlDbType.VarChar, 10).Value = gyarto;
                        cmd.Parameters.Add("@Leiras_jegyzet", SqlDbType.VarChar, 20).Value = jegyzet;
                        cmd.Parameters.Add("@Serial_szam", SqlDbType.VarChar, 20).Value = serial;
                        cmd.Parameters.Add("@Model_szam", SqlDbType.VarChar, 20).Value = model;
                        cmd.Parameters.Add("@Os", SqlDbType.VarChar, 10).Value = os;
                        cmd.Parameters.Add("@Computer_name", SqlDbType.VarChar, 20).Value = computerName;
                        cmd.Parameters.Add("@Cpu", SqlDbType.VarChar, 6).Value = cpu;
                        cmd.Parameters.Add("@Mac", SqlDbType.VarChar, 20).Value = mac;
                        cmd.Parameters.Add("@Gpu", SqlDbType.VarChar, 10).Value = gpu;
                        cmd.Parameters.Add("@Tulajdonos_Id", SqlDbType.Int).Value = tulajdonosId;
                        cmd.Parameters.Add("@Ram", SqlDbType.Int).Value = ram;
                        cmd.Parameters.Add("@Hdd", SqlDbType.Int).Value = hdd;
                        cmd.Parameters.Add("@Kiadasi_idopont", SqlDbType.Date).Value = kiadasiIdopont;
                        cmd.Parameters.Add("@Garancia_lejarata", SqlDbType.Date).Value = garanciaLejaratiido;

                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();

                        //nullazas

                        comboBoxEszkoztipusaFelvitel.SelectedIndex = -1;
                        comboBoxEszkozallapotaFelvitel.SelectedIndex = -1;
                        comboBoxGyarto.SelectedIndex = -1;
                        comboBoxTulajdonos.SelectedIndex = -1;
                        dateTimePickerKiadasiidopont.ResetText();
                        dateTimePickerGarancialejaratiido.ResetText();
                        comboBoxOperaciosrendszerfelvitel.SelectedIndex = -1;
                        comboBoxCpuFelvitel.SelectedIndex = -1;
                        comboBoxRamFelvitel.SelectedIndex = -1;
                        comboBoxHddFelvitel.SelectedIndex = -1;
                        comboBoxGpuFelvitel.SelectedIndex = -1;
                        textBoxEszkozneve.Text = "";
                        textBoxLeirasjegyzet.Text = "";
                        textBoxSeriaszam.Text = "";
                        textBoxModelszam.Text = "";
                        textBoxComputerneve.Text = "";
                        textBoxMac.Text = "";

                        MessageBox.Show("Sikeres rögzítés");

                        tabControl1.SelectedIndex = 0;

                        adatNullaz();
                        adatMegjelen();

                    }
                }
            }
            else
            {
                MessageBox.Show("Nincs kitöltve a kötelező mező!");

            }





        }
    }


}
