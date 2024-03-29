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
    /// Lógica de interacción para VisualizarPelícula.xaml
    /// </summary>
    public partial class VisualizarPelícula : UserControl
    {
        public VisualizarPelícula()
        {
            InitializeComponent();

            txtbTitulo.IsEnabled = false;
            txtbAño.IsEnabled = false;
            txtbDirector.IsEnabled = false;
            txtbSinopsis.IsEnabled = false;
            txtbGenero.IsEnabled = false;
            txtbRating.IsEnabled = false;
        }
    }
}
