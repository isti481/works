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
    public partial class MunkahelyFrm : Form
    {
        string kiirashozNem = "";
        private FrmDolgozok frmDolgozok;
        public MunkahelyFrm()
        {
            InitializeComponent();   
        }                  
        private void buttonDolgozokFormra_Click(object sender, EventArgs e)
        {
            frmDolgozok = new FrmDolgozok();
            frmDolgozok.ShowDialog();
        }
        private void buttonDolgozoFelvitel_Click(object sender, EventArgs e)
        {
            ellenorzes();
        }
        private void ellenorzes()
        {
            bool jo = false;
            if (radioButtonUjlany.Checked)
            {
                kiirashozNem = "Lany";
            }
            if (radioButtonUjfiu.Checked)
            {
                kiirashozNem = "Fiu";
            }
            while (!jo)
            {
                int korAdat;
                bool sikeresUjKorMegadas = int.TryParse(textBoxUjKor.Text, out korAdat);
                int munkabantoltottEvAdat;
                bool sikeresmunkabantoltottEvMegadas = int.TryParse(textBoxMunkabantoltottEv.Text, out munkabantoltottEvAdat);
                if (textBoxMunkabantoltottEv.Text == string.Empty || textBoxUjKor.Text == string.Empty || textBoxUjNev.Text == string.Empty)
                {
                    MessageBox.Show("Nem lehet üres mező az adat megadásánál");
                    break;
                }
                if (sikeresUjKorMegadas==false)
                {
                    MessageBox.Show("Nem megfelelő kor érték!");
                    break;
                }
                if (int.Parse(textBoxUjKor.Text) > 150 || int.Parse(textBoxUjKor.Text) < 14)
                {
                    MessageBox.Show("Nem megfelelő kor érték!");
                    break;
                }
                if (sikeresmunkabantoltottEvMegadas == false)
                {
                    MessageBox.Show("A munkában töltött év adatának számnak kell lennie!");
                    break;
                }
                if ( int.Parse(textBoxMunkabantoltottEv.Text) > int.Parse(textBoxUjKor.Text) )
                {
                    MessageBox.Show("A munkában töltött év adat, nem lehet több mint a kor adata!");
                    break;
                }
                if ( !radioButtonUjlany.Checked && !radioButtonUjfiu.Checked)
                {
                    MessageBox.Show("Nem megfelelő nem érték!");
                    break;
                }
                else
                {
                    jo = true;
                    MessageBox.Show("Rögzítve");
                    FajlbaIras();
                    MezoTorles();
                }
            }
        }
        private void MezoTorles()
        {
            textBoxUjNev.Clear();
            textBoxUjKor.Clear();
            radioButtonUjfiu.Checked=false;
            radioButtonUjlany.Checked=false;
            kiirashozNem = "";
            textBoxMunkabantoltottEv.Clear();
        }
        public void FajlbaIras() // **egy üres sor mindig legyen a txt végén, vagy ne is létezzen a fájl,majd a program megoldja**
        {
            string kiirasUjDolgozoFajlba = $"{textBoxUjNev.Text};{textBoxUjKor.Text};{kiirashozNem};{textBoxMunkabantoltottEv.Text}\n";
            File.AppendAllText("emberek.txt", kiirasUjDolgozoFajlba);
        }
    }
}
