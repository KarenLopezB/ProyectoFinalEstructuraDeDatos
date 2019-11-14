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
        ObservableCollection<ClasePelicula> peliculas=
            new ObservableCollection<ClasePelicula>();
        ObservableCollection<ClaseSerie> series=
            new ObservableCollection<ClaseSerie>();
        public MainWindow()
        {
            InitializeComponent();

          //alumnos.Add(
           //   new Alumno("José", 9.1f, 2));



            listProgram.ItemsSource = peliculas;
        }

        private void BtnNuevoElemento_Click(object sender, RoutedEventArgs e)
        {
            grdPrincipal.Children.Clear();
            grdPrincipal.Children.Add(new Nuevo());
        }
    }
}
