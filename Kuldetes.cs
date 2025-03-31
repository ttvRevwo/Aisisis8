﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqmuvletek
{
    public class Kuldetes
    {
        public Kuldetes(string sor)
        {
            string[] adatok = sor.Split(';');
            Nev = adatok[0];
            Ev = int.Parse(adatok[1]);
            Celpont = adatok[2];
            Legenyseg = int.Parse(adatok[3]);
            Sikeres = adatok[4] == "Igen" ? true : false;
            Leiras = adatok[5];
            Koltseg = double.Parse(adatok[6]);
            HasznosTeher = double.Parse(adatok[7]);
        }

        //név;év;célpont;legénység;sikeres;leírás;költség (mrd USD);hasznos teher (kg)
        public string Nev { get; private set; }
        public int Ev { get; private set; }
        public string Celpont { get; private set; }
        public int Legenyseg { get; private set; }
        public bool Sikeres { get; private set; }
        public string Leiras { get; private set; }
        public double Koltseg { get; private set; }
        public double HasznosTeher { get; private set; }


    }
}
