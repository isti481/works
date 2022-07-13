using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuhaszIstvan_Mz60
{
    class Almalmazott
    {
        public string Nev { get; set; }
        public int Kor { get; set; }
        public string Neme { get; set; }
        public int Dolgozik { get; set; }

        public Almalmazott(string nev) : this(nev,2021,"Fiu",6)
        {
            
        }

        public Almalmazott(string nev, int kor, string neme, int dolgozik)
        {
            //Nev = nev;
            Kor = kor;
            Neme = neme;
            Dolgozik = dolgozik;
        }

        public Almalmazott(string fajlEgySora, string nev)
        {
            string[] egySor = fajlEgySora.Split(';');
            Nev = egySor[0];
            Kor = int.Parse(egySor[1]);
            Neme = egySor[2];
            Dolgozik = int.Parse(egySor[3]);
        }


        
    }

    class AlkalmazottNeme : Almalmazott(string nev)
    {
        

        public Almalmazott Fiu { get; set; }
        public Almalmazott Lany { get; set; }
    }
}
