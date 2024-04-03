using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gelati_Magrini_Nicolas
{
    public enum Ingredientee { Panna, Colorante,Aroma, PannaSoia, Cacao, Latte, Caffe, Mascarpone, Uovo}
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
        public static Ingrediente MakeInrediente(string[] e)
        {
            Enum.TryParse(e[1], out Ingredientee ciccio);
            switch (ciccio)
            {
                case Ingredientee.Panna:
                    return new IngredientePanna(e);
                    break;

                case Ingredientee.Colorante:
                    return new IngredienteColorante(e);
                    break;
                case Ingredientee.Latte:
                    return new IngredienteLatte(e);
                    break;
                default:
                    return new Ingrediente(e);
                    break;
            }
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
                Add(Ingrediente.MakeInrediente(n));
            }

        }


    }
    public class IngredientePanna : Ingrediente
    {
        public IngredientePanna(string[] s) : base(s)
        {
            Calorie = s[3];
        }
        public string Calorie { get; set; }

    }
    public class IngredienteColorante : Ingrediente
    {
        public IngredienteColorante(string[] d) : base(d)
        {
            Colorante = d[3];
        }
        public string Colorante { get; set; }

    }
    public class IngredienteLatte : Ingrediente
    {
        public IngredienteLatte(string[] c) : base(c)
        {
            Lattosio = c[3];
        }
        public string Lattosio { get; set; }

    }
}
