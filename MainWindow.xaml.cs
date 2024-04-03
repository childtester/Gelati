using System;
using System.Collections.Generic;
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

namespace Gelati_Magrini_Nicolas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Ingredienti ingredienti;
        Gelati gelati;
        public MainWindow()
        {
            InitializeComponent();
            gelati = new Gelati("Gelati.csv");
            ingredienti = new Ingredienti("Ingredienti.csv");
            dgGelati.ItemsSource = gelati;


        }

        

        private void dgingre_loadingRow(object sender, DataGridRowEventArgs e)
        {
            Ingrediente b = e.Row.Item as Ingrediente;

        }

        private void dgGelati_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Ingredienti lista = new Ingredienti();
            Gelato b = e.AddedItems[0] as Gelato;
            foreach (Ingrediente i in ingredienti) 
            {
             if(i.idGelato == b.idGelato)
                {
                   lista.Add(i);
                }   
            }dgingre.ItemsSource = lista;
        }
    }
}
