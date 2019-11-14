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
        ObservableCollection<ClasePelicula> peliculas =
            new ObservableCollection<ClasePelicula>();
        ObservableCollection<ClaseSerie> series =
            new ObservableCollection<ClaseSerie>();
        public MainWindow()
        {
            InitializeComponent();

            peliculas.Add(new ClasePelicula("En busca de la felicidad", 2006));
            peliculas.Add(new ClasePelicula("Cenicienta", 1950));
            peliculas.Add(new ClasePelicula("Shrek", 2001));

            listProgram.ItemsSource = peliculas;

            series.Add(new ClaseSerie("3%", 2016));
            series.Add(new ClaseSerie("Stranger Things", 2016));
            series.Add(new ClaseSerie("13 Reasons Why", 2015));

            listProgram.ItemsSource = series;
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
