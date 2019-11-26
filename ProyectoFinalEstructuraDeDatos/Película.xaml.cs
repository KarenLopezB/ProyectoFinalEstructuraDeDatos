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
    /// Lógica de interacción para Película.xaml
    /// </summary>
    public partial class Película : UserControl
    {
        public Película()
        {
            InitializeComponent();
        }

        private void BtnGuardarPelicula_Click(object sender, RoutedEventArgs e)
        {
            //programas.Add(new Color(txtbox1.Text, txtbox2.Text, txtbox3.Text));
            //txtbox1.Text = "";
            //txtbox2.Text = "";
            //txtbox3.Text = "";
        }

        private void BtnCancelarPelicula_Click(object sender, RoutedEventArgs e)
        {
            //grdNuevo.Children.Clear();
        }
    }
}
