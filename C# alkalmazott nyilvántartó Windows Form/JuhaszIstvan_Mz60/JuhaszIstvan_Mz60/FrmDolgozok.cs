using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuhaszIstvan_Mz60
{
    public partial class FrmDolgozok : Form
    {
        public string Fajl { get;}

        List<Almalmazott> alkalmazottLista;
        
        int lepteto;
        string[] sorok;
        int legidosebb = 0;
        int osszKor = 0;
        string hatEveDolgozo = "";
        string fiukFajlLegidosebb = "";
        string fiukFajlOsszeskor = "";
        string fiukFajlHatvedolgozo = "";
        string lanyokFajlLegidosebb = "";
        string lanyokFajlOsszeskor = "";
        string lanyokFajlHatvedolgozo = "";
        string kiirasDolgozoOsszesito = "";        
        string lany = "Lany";
        string fiu = "Fiu";
        string dolgozokFajl = "dolgozok.txt";
        string kiirasKor = "";
        string kiirasEv = "";
        /*
        public string alkalmazottFiu { get; set; } = "Fiu";
        public string alkalmazottLany { get; set; } = "Lany";
        */
        public FrmDolgozok()
        {
            InitializeComponent();
            Fajl = "emberek.txt";  
        }
        private void DolgozokFrm_Load(object sender, EventArgs e)
        {
            if (File.Exists(Fajl))
            {
                sorok = File.ReadAllLines(Fajl);
                alkalmazottLista = new List<Almalmazott>();
                foreach (string sor in sorok)
                {
                    alkalmazottLista.Add(new Almalmazott(sor));
                }
                
                foreach (Almalmazott alkalmazott in alkalmazottLista)
                {
                    if (alkalmazott.Neme == fiu)
                    {
                        comboBoxFiuk.Items.Add(alkalmazott.Nev);
                    }
                    else
                    {
                         comboBoxLanyok.Items.Add(alkalmazott.Nev);
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Nincs a rendszerben felvitt dolgozó, vigyél fel legalább 1-et!");
                Close();
            }
        }
        private void comboBoxLanyok_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxFiuk.Text = "";
            for (int i = 0; i < alkalmazottLista.Count; i++)
            {
                if (alkalmazottLista[i].Neme == lany) 
                {
                    comboboxAdatSzamitas(i);
                }
            }
            labelKor.Text = $"kor: {kiirasKor} év";
            labelMunkabanToltottEv.Text = $"mióta dolgozik {kiirasEv} éve";
        }
        private void comboBoxFiuk_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxLanyok.Text = "";
            for (int i = 0; i < alkalmazottLista.Count; i++)
            {
                if (alkalmazottLista[i].Neme == fiu)
                {
                    comboboxAdatSzamitas(i);
                }
            }
            labelKor.Text = $"kor: {kiirasKor} év";
            labelMunkabanToltottEv.Text = $"mióta dolgozik {kiirasEv} éve";
        }
        private void comboBoxFiuk_Click(object sender, EventArgs e)
        {
            comboBoxLanyok.Text = "";
            labelAdatokNullazas();
        }
        private void comboBoxLanyok_Click(object sender, EventArgs e)
        {
            comboBoxFiuk.Text = "";
            labelAdatokNullazas();
        }
        private void radioButtonFiu_CheckedChanged(object sender, EventArgs e)
        {
            CiklusAdatNullazas();
            labelOsszesitoNullazas();
            for (int lepteto = 0; lepteto < alkalmazottLista.Count; lepteto++)
            {
                if (alkalmazottLista[lepteto].Neme == fiu)
                {
                    radiogombAdat(lepteto);
                }
            }
            radiogombLabelKiiras();
            fiukFajlLegidosebb = $"legidősebb: {alkalmazottLista[legidosebb].Kor} éves";
            fiukFajlOsszeskor = $"összes kor: {osszKor} év";
            fiukFajlHatvedolgozo = $"6 éve dolgozó: {hatEveDolgozo}";
        }
        private void radioButtonLany_CheckedChanged(object sender, EventArgs e)
        {
            CiklusAdatNullazas();
            labelOsszesitoNullazas();
            for (int lepteto = 0; lepteto < alkalmazottLista.Count; lepteto++)
            {
                if (alkalmazottLista[lepteto].Neme == lany)
                {
                    radiogombAdat(lepteto);
                }
            }
            radiogombLabelKiiras();
            lanyokFajlLegidosebb = $"legidősebb: {alkalmazottLista[legidosebb].Kor} éves";
            lanyokFajlOsszeskor = $"összes kor: {osszKor} év";
            lanyokFajlHatvedolgozo = $"6 éve dolgozó: {hatEveDolgozo}";
        }
        private void buttonMentDolgozok_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rögzítve");
            if (checkBoxMindkettoNem.Checked)
            {
                kiirasDolgozoOsszesitoLanyok();
                kiirasDolgozoOsszesito = $"Fiúk:\n{fiukFajlLegidosebb} \n{fiukFajlOsszeskor}\n{fiukFajlHatvedolgozo}\n";
                File.AppendAllText(dolgozokFajl, kiirasDolgozoOsszesito);
            }
            if (radioButtonFiu.Checked && !checkBoxMindkettoNem.Checked)
            {
                kiirasDolgozoOsszesitoFiuk();
            }
            if (radioButtonLany.Checked && !checkBoxMindkettoNem.Checked)
            {
                kiirasDolgozoOsszesitoLanyok();
            }
        }       
        private void checkBoxMindkettoNem_Click(object sender, EventArgs e)
        {
            labelOsszesitoNullazas();
            if (radioButtonFiu.Checked)
            {
                radiogombLabelKiiras();
            }
            if (radioButtonLany.Checked)
            {
                radiogombLabelKiiras();
            }
        }
        private void comboboxAdatSzamitas(int i)
        {
            if (alkalmazottLista[i].Nev == comboBoxFiuk.Text || alkalmazottLista[i].Nev == comboBoxLanyok.Text)
            {
                kiirasKor = "";
                kiirasEv = "";
                kiirasKor = alkalmazottLista[i].Kor.ToString();
                kiirasEv = alkalmazottLista[i].Dolgozik.ToString();
            }
        }
        private void labelAdatokNullazas()
        {
            labelKor.Text = "kor:";
            labelMunkabanToltottEv.Text = "mióta dolgozik:";
        }
        private void labelOsszesitoNullazas()
        {
            labelLegidosebb.Text = "legidősebb:";
            labelOsszeskor.Text = "összes kor:";
            label6eveDolgozo.Text = "6 éve dolgozó: ";
        }
        private void radiogombAdat(int lepteto)
        {
            if (alkalmazottLista[lepteto].Kor > alkalmazottLista[legidosebb].Kor)
            {
                legidosebb = lepteto;
            }           
            osszKor += alkalmazottLista[lepteto].Kor;
            if (alkalmazottLista[lepteto].Dolgozik >= 6)
            {
                hatEveDolgozo += alkalmazottLista[lepteto].Nev + " ";
            }
        }
        private void CiklusAdatNullazas()
        {
            osszKor = 0;
            legidosebb = 0;
            hatEveDolgozo = "";
        }
        private void radiogombLabelKiiras()
        {
            labelLegidosebb.Text = $"legidősebb: {alkalmazottLista[legidosebb].Kor} éves";
            labelOsszeskor.Text = $"összes kor: {osszKor} év";
            bool hatEveNemdolgozo = hatEveDolgozo == "";
            if (hatEveNemdolgozo)
            {
                hatEveDolgozo = "nincs";
            }
            label6eveDolgozo.Text = $"6 éve dolgozó: {hatEveDolgozo}";
        }
        private void kiirasDolgozoOsszesitoFiuk()
        {
            kiirasDolgozoOsszesito = $"Fiúk:\n{fiukFajlLegidosebb} \n{fiukFajlOsszeskor}\n{fiukFajlHatvedolgozo}\n";
            File.WriteAllText(dolgozokFajl, kiirasDolgozoOsszesito);
        }
        private void kiirasDolgozoOsszesitoLanyok()
        {
            kiirasDolgozoOsszesito = $"Lányok:\n{lanyokFajlLegidosebb} \n{lanyokFajlOsszeskor}\n{lanyokFajlHatvedolgozo}\n";
            File.WriteAllText(dolgozokFajl, kiirasDolgozoOsszesito);
        }
    }
}
