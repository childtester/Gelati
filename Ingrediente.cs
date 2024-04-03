using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gelati_Magrini_Nicolas
{
    public class Ingrediente
    {
        public int idGelato { get; set; }
        public string Tipo { get; set; }
        public string Valore { get; set; }


        public Ingrediente(string[] I)
        {
            idGelato = int.Parse(I[0]);
            Tipo = I[1];
            Valore = I[2];
        }
    }
    public class Ingredienti : List<Ingrediente>
    {
        public Ingredienti() { }
        public Ingredienti(string I)
        {
            StreamReader rs = new StreamReader(I);
            rs.ReadLine();
            string dati;
            while (!rs.EndOfStream)
            {
                dati = rs.ReadLine();
                string[] n = dati.Split(';');
                Add(new Ingrediente(n));
            }

        }


    }
}
