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
using System.Collections.ObjectModel;

namespace ProyectoFinalEstructuraDeDatos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Program program = new Program();

        ObservableCollection<Program> programas =
            new ObservableCollection<Program>();
        public MainWindow()
        {
            InitializeComponent();

            ClasePelicula peli1 = (new ClasePelicula("En busca de la felicidad", 2006));
            ClasePelicula peli2 = (new ClasePelicula("Cenicienta", 1950));
            ClasePelicula peli3 = (new ClasePelicula("Shrek", 2001));

            ClaseSerie serie1 = (new ClaseSerie("3%", 2016));
            ClaseSerie serie2 = (new ClaseSerie("Stranger Things", 2016));
            ClaseSerie serie3 = (new ClaseSerie("13 Reasons Why", 2015));

            programas.Add(peli1);
            programas.Add(peli2);
            programas.Add(peli3);
            programas.Add(serie1);
            programas.Add(serie2);
            programas.Add(serie3);

            listProgram.ItemsSource = programas;

        }

        private void BtnNuevoElemento_Click(object sender, RoutedEventArgs e)
        {
            grdPrincipal.Children.Clear();
            grdPrincipal.Children.Add(new Nuevo());
        }

        private void listProgram_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
