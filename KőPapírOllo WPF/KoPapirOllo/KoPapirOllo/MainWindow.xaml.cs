using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KoPapirOllo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        int tipp;
        int kor = 0;
        static Random rnd = new Random();
        string jatekostipp;
        string geptippSzoveg;
        int gepvalasztasa3;
        string allas;
        List <string> lista = new List<string>();
        int jatekosValasztas;
        string gepValasztasa2;
        public MainWindow()
        {
            InitializeComponent();
            MessageBox.Show("Üdvözöllek! Indítsd el az új játékot és kezdődhet a móka!","Üdv!",MessageBoxButton.OK,MessageBoxImage.Information);
            rbn_ko.IsEnabled = false;
            rbn_ollo.IsEnabled = false;
            rbn_papir.IsEnabled = false;
            btnMentes.IsEnabled = false;
        }

        private void btnUjjatek_Click(object sender, RoutedEventArgs e)
        {

            Ujjatek(); 
            
        }

        private void valasztas()
        {
            
            if (rbn_ko.IsChecked == true)
            {
                jatekosValasztas = 1;
            }
            if (rbn_papir.IsChecked == true)
            {
                jatekosValasztas = 2;

            }
            if (rbn_ollo.IsChecked == true) 
            {
                jatekosValasztas = 3;
            }

            rbn_ko.IsEnabled = false;
            rbn_ollo.IsEnabled = false;
            rbn_papir.IsEnabled = false;
            tipp = rnd.Next(1, 4);

            switch (tipp)
            {
                case 1:
                    geptippSzoveg = "kő";
                    break;

                case 2:
                    geptippSzoveg = "papír";
                    break;
                case 3:
                    geptippSzoveg = "olló";
                    break;

            }
            lblEllenfeltipp.Content = "Ellenfel tipp: " + geptippSzoveg;

            logika();
        }

        private void logika()
        {
            if (jatekosValasztas == 1)
            {
                if (tipp == 2)
                {
                    lblNyertes.Content = "Nyertes: Gép nyert";
                }
                if (tipp == 3)
                {
                    lblNyertes.Content = "Nyertes: Játékos nyert";
                }
                döntetlen();

            }
            if (jatekosValasztas == 2)
            {
                if (tipp == 3)
                {
                    lblNyertes.Content = "Nyertes: Gép nyert";
                }
                if (tipp == 1)
                {
                    lblNyertes.Content = "Nyertes: Játékos nyert";
                }
                döntetlen();

            }
            if (jatekosValasztas == 3)
            {
                if (tipp == 1)
                {
                    lblNyertes.Content = "Nyertes: Gép nyert";
                }
                if (tipp == 2)
                {
                    lblNyertes.Content = "Nyertes: Játékos nyert";
                }
                döntetlen();

            }
            kor++;
            txtAllas.Text += kor + ". kör " + lblNyertes.Content + "\n";
            btnMentes.IsEnabled = true;
        }

        private void döntetlen()
        {
            if (jatekosValasztas == tipp)
            {
                lblNyertes.Content = "Nyertes: Döntetlen";
            }
        }

        private void Ujjatek()
        {
            
            rbn_ko.IsEnabled = true;
            rbn_ollo.IsEnabled = true;
            rbn_papir.IsEnabled = true;
            tipp = 0;
            //kor = 0;
            rbn_ollo.IsChecked = false;
            rbn_ko.IsChecked = false;
            rbn_papir.IsChecked = false;
            lblEllenfeltipp.Content = "Ellenfel tipp: ";
            lblNyertes.Content = "Nyertes: ";
            geptippSzoveg = "";
            jatekostipp = "";
            jatekosValasztas = 0;
            gepvalasztasa3 = 0;
            //valasztas();
            
            
        }       
        
        private void btnMentes_Click(object sender, RoutedEventArgs e)
        {            
            if (tipp == 1)
            {
                geptippSzoveg = "Kő";
                
            }
            if (tipp == 2)
            {
                geptippSzoveg = "Papír";
                
            }
            if (tipp == 3)
            {
                geptippSzoveg = "Olló";
                
            }
            /*allas = $"A játékos tippje: {jatekostipp}\nGép tipp: {geptippSzoveg}\n{lblNyertes.Content}\n-------------------------\n";*/
            allas = txtAllas.Text;
            File.AppendAllText("allas.txt", allas);
            MessageBox.Show("Elmentve");

        }

        private void rbn_ollo_Checked(object sender, RoutedEventArgs e)
        {
            valasztas();
        }

        private void rbn_ko_Checked(object sender, RoutedEventArgs e)
        {
            valasztas();
        }

        private void rbn_papir_Checked(object sender, RoutedEventArgs e)
        {
            valasztas();
        }

        
    }
}
