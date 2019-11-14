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

namespace ProyectoFinalEstructuraDeDatos
{
    /// <summary>
    /// Lógica de interacción para Nuevo.xaml
    /// </summary>
    public partial class Nuevo : UserControl
    {
        public Nuevo()
        {
            InitializeComponent();
        }

        private void RdbtnPelicula_Checked(object sender, RoutedEventArgs e)
        {
            grdSerieyPelicula.Children.Clear();
            grdSerieyPelicula.Children.Add(new Película());
        }

        private void RdbtnSerie_Checked(object sender, RoutedEventArgs e)
        {
            grdSerieyPelicula.Children.Clear();
            grdSerieyPelicula.Children.Add(new Serie());
        }
    }
}
