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
            var algarismos = new List<char>(numeroRomano.ToCharArray());
            int retorno = 0;

            for(int i=0; i < algarismos.Count; i++)
            {
                int atual = _numerosRomanos[algarismos[i].ToString()];
                int proximo = (i < algarismos.Count -1)? _numerosRomanos[algarismos[i + 1].ToString()] : -1;
                int valor;
                if (atual < proximo)
                {
                    valor = (proximo - atual);
                    i++;
                }
                else
                {
                    valor = atual;
                }
                retorno += valor;
            }
           
            return retorno;
        }
    }
}
