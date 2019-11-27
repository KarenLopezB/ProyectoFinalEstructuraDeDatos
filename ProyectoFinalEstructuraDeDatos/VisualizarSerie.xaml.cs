﻿using System;
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
    /// Lógica de interacción para VisualizarSerie.xaml
    /// </summary>
    public partial class VisualizarSerie : UserControl
    {
        public VisualizarSerie()
        {
            InitializeComponent();

            txtbTituloS.IsEnabled = false;
            txtbAñoS.IsEnabled = false;
            txtbProductorS.IsEnabled = false;
            txtbTemporadasS.IsEnabled = false;
            txtbDescripcionS.IsEnabled = false;
            txtbGeneroS.IsEnabled = false;
            txtbRatingS.IsEnabled = false;
        }
    }
}
