using System;
using System.Collections.Generic;
using System.Text;

namespace App
{
    public class Romano
    {
        Dictionary<string, int> _numerosRomanos = new Dictionary<string, int>()
        {
            {"I", 1},
            {"V", 5},
            {"X", 10},
            {"L", 50},
            {"C", 100},
            {"D", 500},
            {"M", 1000}
        };

        public int ToDecimal(string numeroRomano)
        {
            var algarismos = numeroRomano.ToCharArray();
            int retorno = 0;

            foreach(var al in algarismos)
            {
                if(al.ToString() > algarismos.)

                retorno +=_numerosRomanos[al.ToString()];
            }

            return retorno;
        }
    }
}
