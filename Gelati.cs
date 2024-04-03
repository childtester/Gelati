using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gelati_Magrini_Nicolas
{
    public class Gelato
    {
        public int idGelato { get; set; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public string Prezzo { get; set; }

        public Gelato(string[] G)
        {
            int a;
            int.TryParse(G[0], out a);
            idGelato = a;
            Nome = G[1];
            Descrizione = G[2];
            Prezzo = G[3];
        }
    }
    public class Gelati : List<Gelato>
    {
        public Gelati(string G)
        {
            string[] n;
            string dati;
            StreamReader sr = new StreamReader(G);
            sr.ReadLine();
            do
            {
                dati = Convert.ToString(sr.ReadLine());
                n = dati.Split(';');
                Add(new Gelato(n));
            } while (!sr.EndOfStream);

        }


    }
}
