﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302223039
{
    public class KodeBuah
    {
        public enum buah
        {
             Apel, Aprikot, Alpukat, Pisang, Paprika, Blackberry, Ceri, Kelapa, Jagung 
        }
        

        public static string getKodeBuah(buah namaBuah) {
            string[] kode = { "A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00" };


            return kode[(int)namaBuah];

        }
    }
}
