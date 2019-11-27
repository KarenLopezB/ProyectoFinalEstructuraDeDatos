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

        ObservableCollection<Program> Programas =
            new ObservableCollection<Program>();
        public MainWindow()
        {
            InitializeComponent();



            ClasePelicula peli1 = (new ClasePelicula("Pelicula", "En busca de la felicidad", 2006, "Drama",
                "Gabriele Muccino", "La vida es una lucha para Chris Gardner. Expulsado de su apartamento, él y su joven " +
                "hijo se encuentran solos sin ningún lugar a donde ir.A pesar de que Chris eventualmente " +
                "consigue trabajo como interno en una prestigiada firma financiera, la posición no le da dinero." +
                "El dúo debe vivir en un albergue y enfrentar muchas dificultades, pero Chris no se da por " +
                "vencido y lucha por conseguir una vida mejor para él y su hijo.", 4));
            ClasePelicula peli2 = (new ClasePelicula("Pelicula", "Cenicienta", 1950, "Fantasía",
                "Clyde Geronimi, Hamilton Luske, Wilfred Jackson", "Con una malvada madrastra y dos hermanastras " +
                "celosas que la mantienen esclavizada y en harapos, Cenicienta no tiene oportunidad de asistir " +
                "al baile real, hasta que aparece su hada madrina.", 4));
            ClasePelicula peli3 = (new ClasePelicula("Pelicula", "Shrek", 2001, "Comedia", "Andrew Adamson, Vicky Jenson",
                "Había una vez, en un pantano muy lejano, vivía un ogro llamado Shrek (Mike Myers) cuya preciosa " +
                "soledad se ve súbitamente interrumpida por la invasión de los ruidosos personajes de los cuentos " +
                "de hadas.Todos fueron expulsados de sus reinos por el malvado Lord Farquaad(John Lithgow). " +
                "Decidido a salvar su casa, Shrek hace un trato con Farquaad y se prepara para rescatar a la " +
                "princesa Fiona(Cameron Diaz) para que sea la novia de Farquaad.", 5));

            ClaseSerie serie1 = (new ClaseSerie("Serie", "3%", 2016, "Thriller", 3, "César Charlone, Tiago Mello",
                "En un futuro no muy lejano, los ciudadanos luchan por formar parte del grupo de los privilegiados " +
                "y así evitar caer en la devastación.", 4));
            ClaseSerie serie2 = (new ClaseSerie("Serie", "Stranger Things", 2016, "Ciencia Ficción", 3,
                "Shawn Levy, Dan Cohen", "Cuando un niño desaparece, sus amigos, la familia y la policía se ven " +
                "envueltos en una serie de eventos misteriosos al tratar de encontrarlo.Su ausencia coincide con " +
                "el avistamiento de una criatura terrorífica y la aparición de una extraña niña.", 5));
            ClaseSerie serie3 = (new ClaseSerie("Serie", "13 Reasons Why", 2015, "Drama", 3, "Joseph Incaprera",
                "Después de que una mujer joven se quite la vida, su compañero de clase encuentra una misteriosa " +
                "caja en su patio.", 5));

            Programas.Add(peli1);
            Programas.Add(peli2);
            Programas.Add(peli3);
            Programas.Add(serie1);
            Programas.Add(serie2);
            Programas.Add(serie3);

            listProgram.ItemsSource = Programas;

        }

        private void BtnNuevoElemento_Click(object sender, RoutedEventArgs e)
        {
            grdPrincipal.Children.Clear();

            txtAgregarNuevo.Visibility = Visibility.Visible;
            txtTipo.Visibility = Visibility.Visible;
            rdbtnPelicula1.Visibility = Visibility.Visible;
            rdbtnSerie1.Visibility = Visibility.Visible;

            btnOrdenarAZ.Visibility = Visibility.Hidden;
            btnOrdenarZA.Visibility = Visibility.Hidden;
            btnAñoAscendente.Visibility = Visibility.Hidden;
            btnAñoDescendente.Visibility = Visibility.Hidden;
            btnNuevoElemento.Visibility = Visibility.Hidden;
            btnGuardarNuevojeje.Visibility = Visibility.Hidden;
            btnCancelarNuevo.Visibility = Visibility.Hidden;
            Img5estrellas.Visibility = Visibility.Hidden;
            Img4estrellas.Visibility = Visibility.Hidden;
            Img3estrellas.Visibility = Visibility.Hidden;
            Img2estrellas.Visibility = Visibility.Hidden;
            Img1estrella.Visibility = Visibility.Hidden;

            //grdPrincipal.Children.Add(new Nuevo());

        }

        private void listProgram_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listProgram.SelectedIndex != -1)
            {
                //grdPrincipal.Children.Clear();
                //grdPrincipal.Children.Add(new VisualizarPelícula());


                btnNuevoElemento.Visibility = Visibility.Hidden;
                btnOrdenarAZ.Visibility = Visibility.Hidden;
                btnOrdenarZA.Visibility = Visibility.Hidden;
                btnAñoAscendente.Visibility = Visibility.Hidden;
                btnAñoDescendente.Visibility = Visibility.Hidden;
                btnActualizarE.Visibility = Visibility.Hidden;
                btnEliminarE.Visibility = Visibility.Hidden;
                btnCancelarE.Visibility = Visibility.Hidden;
                btnGuardarNuevojeje.Visibility = Visibility.Hidden;
                btnCancelarNuevo.Visibility = Visibility.Hidden;
                txtAgregarNuevo.Visibility = Visibility.Hidden;
                txtTipo.Visibility = Visibility.Hidden;
                rdbtnPelicula1.Visibility = Visibility.Hidden;
                rdbtnSerie1.Visibility = Visibility.Hidden;
                Img5estrellas.Visibility = Visibility.Hidden;
                Img4estrellas.Visibility = Visibility.Hidden;
                Img3estrellas.Visibility = Visibility.Hidden;
                Img2estrellas.Visibility = Visibility.Hidden;
                Img1estrella.Visibility = Visibility.Hidden;

                btnHabilitarEdicion.Visibility = Visibility.Visible;
                btnEliminarPV.Visibility = Visibility.Visible;
                btnCancelarPV.Visibility = Visibility.Visible;

                if (Programas[listProgram.SelectedIndex].Clase == "Pelicula")
                {
                    grdPrincipal.Children.Clear();
                    grdPrincipal.Children.Add(new VisualizarPelícula());

                    ((VisualizarPelícula)(grdPrincipal.Children[0])).txtbTitulo.Text = Programas[listProgram.SelectedIndex].Titulo;
                    ((VisualizarPelícula)(grdPrincipal.Children[0])).txtbAño.Text = Programas[listProgram.SelectedIndex].Año.ToString();
                    ((VisualizarPelícula)(grdPrincipal.Children[0])).txtbDirector.Text = Programas[listProgram.SelectedIndex].Director;
                    ((VisualizarPelícula)(grdPrincipal.Children[0])).txtbSinopsis.Text = Programas[listProgram.SelectedIndex].Sinopsis;
                    ((VisualizarPelícula)(grdPrincipal.Children[0])).txtbGenero.Text = Programas[listProgram.SelectedIndex].Genero;
                    ((VisualizarPelícula)(grdPrincipal.Children[0])).txtbRating.Text = Programas[listProgram.SelectedIndex].Rating.ToString();
                    //((VisualizarSerie)grdPrincipal.Children[0]).txtbTemporadas.Text = Programas[listProgram.SelectedIndex].Temporadas;
                    //((VisualizarSerie)(grdPrincipal.Children[0])).txtbProductor.Text = Programas[listProgram.SelectedIndex].Productor;
                    //((VisualizarSerie)(grdPrincipal.Children[0])).txtbDescripcion.Text = Programas[listProgram.SelectedIndex].Descripcion;

                    /* ((VisualizarPelícula)(grdPrincipal.Children[0])).txtbTitulo.IsEnabled = true;
                       ((VisualizarPelícula)(grdPrincipal.Children[0])).txtbAño.IsEnabled = true;
                       ((VisualizarPelícula)(grdPrincipal.Children[0])).txtbDirector.IsEnabled = true;
                       ((VisualizarPelícula)(grdPrincipal.Children[0])).txtbSinopsis.IsEnabled = true;
                       ((VisualizarPelícula)(grdPrincipal.Children[0])).txtbGenero.IsEnabled = true;
                       ((VisualizarPelícula)(grdPrincipal.Children[0])).txtbRating.IsEnabled = true;  */

                   Img5estrellas.Visibility = Visibility.Hidden;
                    Img4estrellas.Visibility = Visibility.Hidden;
                    Img3estrellas.Visibility = Visibility.Hidden;
                    Img2estrellas.Visibility = Visibility.Hidden;
                    Img1estrella.Visibility = Visibility.Hidden; 

                    if (((VisualizarPelícula)(grdPrincipal.Children[0])).txtbRating.Text == "1")
                    {
                        Img1estrella.Visibility = Visibility.Visible;
                    }
                    if (((VisualizarPelícula)(grdPrincipal.Children[0])).txtbRating.Text == "2")
                    {
                        Img2estrellas.Visibility = Visibility.Visible;
                    }
                    if (((VisualizarPelícula)(grdPrincipal.Children[0])).txtbRating.Text == "3")
                    {
                        Img3estrellas.Visibility = Visibility.Visible;
                    }
                    if (((VisualizarPelícula)(grdPrincipal.Children[0])).txtbRating.Text == "4")
                    {
                        Img4estrellas.Visibility = Visibility.Visible;
                    }
                    if (((VisualizarPelícula)(grdPrincipal.Children[0])).txtbRating.Text == "5")
                    {
                        Img5estrellas.Visibility = Visibility.Visible;
                    }

                    btnEliminarPV.Visibility = Visibility.Visible;
                    btnCancelarPV.Visibility = Visibility.Visible;
                }

                if (Programas[listProgram.SelectedIndex].Clase == "Serie")
                {
                    grdPrincipal.Children.Clear();
                    grdPrincipal.Children.Add(new VisualizarSerie());

                    ((VisualizarSerie)(grdPrincipal.Children[0])).txtbTituloS.Text = Programas[listProgram.SelectedIndex].Titulo;
                    ((VisualizarSerie)(grdPrincipal.Children[0])).txtbAñoS.Text = Programas[listProgram.SelectedIndex].Año.ToString();
                    ((VisualizarSerie)(grdPrincipal.Children[0])).txtbGeneroS.Text = Programas[listProgram.SelectedIndex].Genero;
                    ((VisualizarSerie)(grdPrincipal.Children[0])).txtbTemporadasS.Text = Programas[listProgram.SelectedIndex].Temporadas.ToString();
                    ((VisualizarSerie)(grdPrincipal.Children[0])).txtbProductorS.Text = Programas[listProgram.SelectedIndex].Productor;
                    ((VisualizarSerie)(grdPrincipal.Children[0])).txtbDescripcionS.Text = Programas[listProgram.SelectedIndex].Descripcion;
                    ((VisualizarSerie)(grdPrincipal.Children[0])).txtbRatingS.Text = Programas[listProgram.SelectedIndex].Rating.ToString();

                    Img5estrellas.Visibility = Visibility.Hidden;
                    Img4estrellas.Visibility = Visibility.Hidden;
                    Img3estrellas.Visibility = Visibility.Hidden;
                    Img2estrellas.Visibility = Visibility.Hidden;
                    Img1estrella.Visibility = Visibility.Hidden; 

                    if (((VisualizarSerie)(grdPrincipal.Children[0])).txtbRatingS.Text == "1")
                    {
                        Img1estrella.Visibility = Visibility.Visible;
                    }
                    if (((VisualizarSerie)(grdPrincipal.Children[0])).txtbRatingS.Text == "2")
                    {
                        Img2estrellas.Visibility = Visibility.Visible;
                    }
                    if (((VisualizarSerie)(grdPrincipal.Children[0])).txtbRatingS.Text == "3")
                    {
                        Img3estrellas.Visibility = Visibility.Visible;
                    }
                    if (((VisualizarSerie)(grdPrincipal.Children[0])).txtbRatingS.Text == "4")
                    {
                        Img4estrellas.Visibility = Visibility.Visible;
                    }
                    if (((VisualizarSerie)(grdPrincipal.Children[0])).txtbRatingS.Text == "5")
                    {
                        Img5estrellas.Visibility = Visibility.Visible;
                    }
                    btnEliminarPV.Visibility = Visibility.Visible;
                    btnCancelarPV.Visibility = Visibility.Visible;
                }
            }
        }

        private void RdbtnPelicula1_Checked(object sender, RoutedEventArgs e)
        {
            grdPrincipal.Children.Clear();
            grdPrincipal.Children.Add(new Película());

            btnGuardarNuevojeje.Visibility = Visibility.Visible;
            btnCancelarNuevo.Visibility = Visibility.Visible;

            txtMensaje.Visibility = Visibility.Hidden;
        }

        private void RdbtnSerie1_Checked(object sender, RoutedEventArgs e)
        {
            grdPrincipal.Children.Clear();
            grdPrincipal.Children.Add(new Serie());

            btnGuardarNuevojeje.Visibility = Visibility.Visible;
            btnCancelarNuevo.Visibility = Visibility.Visible;

            txtMensaje.Visibility = Visibility.Hidden;

        }

        private void BtnCancelarNuevo_Click(object sender, RoutedEventArgs e)
        {
            grdPrincipal.Children.Clear();
            btnNuevoElemento.Visibility = Visibility.Visible;
            btnOrdenarAZ.Visibility = Visibility.Visible;
            btnOrdenarZA.Visibility = Visibility.Visible;
            btnAñoAscendente.Visibility = Visibility.Visible;
            btnAñoDescendente.Visibility = Visibility.Visible;
            btnGuardarNuevojeje.Visibility = Visibility.Hidden;
            btnCancelarNuevo.Visibility = Visibility.Hidden;
            txtAgregarNuevo.Visibility = Visibility.Hidden;
            txtTipo.Visibility = Visibility.Hidden;
            rdbtnPelicula1.Visibility = Visibility.Hidden;
            rdbtnSerie1.Visibility = Visibility.Hidden;
        }

        private void BtnHabilitarEdicion_Click(object sender, RoutedEventArgs e)
        {

            if (Programas[listProgram.SelectedIndex].Clase == "Pelicula")
            {
                grdPrincipal.Children.Clear();
                grdPrincipal.Children.Add(new Editar());

                btnHabilitarEdicion.Visibility = Visibility.Hidden;
                btnEliminarPV.Visibility = Visibility.Hidden;
                btnCancelarPV.Visibility = Visibility.Hidden;
                btnActualizarE.Visibility = Visibility.Visible;
                btnEliminarE.Visibility = Visibility.Visible;
                btnCancelarE.Visibility = Visibility.Visible;

                Img5estrellas.Visibility = Visibility.Hidden;
                Img4estrellas.Visibility = Visibility.Hidden;
                Img3estrellas.Visibility = Visibility.Hidden;
                Img2estrellas.Visibility = Visibility.Hidden;
                Img1estrella.Visibility = Visibility.Hidden;
                btnGuardarNuevojeje.Visibility = Visibility.Hidden;
                btnCancelarNuevo.Visibility = Visibility.Hidden;
                txtAgregarNuevo.Visibility = Visibility.Hidden;
                txtTipo.Visibility = Visibility.Hidden;
                rdbtnPelicula1.Visibility = Visibility.Hidden;
                rdbtnSerie1.Visibility = Visibility.Hidden;

                ((Editar)(grdPrincipal.Children[0])).txtTituloEP.Text = Programas[listProgram.SelectedIndex].Titulo;
                ((Editar)(grdPrincipal.Children[0])).txtAñoEP.Text = Programas[listProgram.SelectedIndex].Año.ToString();
                ((Editar)(grdPrincipal.Children[0])).cbGeneroEP.Text = Programas[listProgram.SelectedIndex].Genero;
                ((Editar)(grdPrincipal.Children[0])).txtDirectorEP.Text = Programas[listProgram.SelectedIndex].Director;
                ((Editar)(grdPrincipal.Children[0])).txtSinopsisEP.Text = Programas[listProgram.SelectedIndex].Sinopsis;
                ((Editar)(grdPrincipal.Children[0])).txtRatingEP.Text = Programas[listProgram.SelectedIndex].Rating.ToString();

                /* ((VisualizarPelícula)(grdPrincipal.Children[0])).txtbTitulo.IsEnabled = true;
                 ((VisualizarPelícula)(grdPrincipal.Children[0])).txtbAño.IsEnabled = true;
                 ((VisualizarPelícula)(grdPrincipal.Children[0])).txtbDirector.IsEnabled = true;
                 ((VisualizarPelícula)(grdPrincipal.Children[0])).txtbSinopsis.IsEnabled = true;
                 ((VisualizarPelícula)(grdPrincipal.Children[0])).txtbGenero.IsEnabled = true;
                 ((VisualizarPelícula)(grdPrincipal.Children[0])).txtbRating.IsEnabled = true; */
            }

            if (Programas[listProgram.SelectedIndex].Clase == "Serie")
            {
                grdPrincipal.Children.Clear();
                grdPrincipal.Children.Add(new EditarSerie());

                btnHabilitarEdicion.Visibility = Visibility.Hidden;
                btnEliminarPV.Visibility = Visibility.Hidden;
                btnCancelarPV.Visibility = Visibility.Hidden;
                btnActualizarE.Visibility = Visibility.Visible;
                btnEliminarE.Visibility = Visibility.Visible;
                btnCancelarE.Visibility = Visibility.Visible;

                Img5estrellas.Visibility = Visibility.Hidden;
                Img4estrellas.Visibility = Visibility.Hidden;
                Img3estrellas.Visibility = Visibility.Hidden;
                Img2estrellas.Visibility = Visibility.Hidden;
                Img1estrella.Visibility = Visibility.Hidden;
                btnGuardarNuevojeje.Visibility = Visibility.Hidden;
                btnCancelarNuevo.Visibility = Visibility.Hidden;
                txtAgregarNuevo.Visibility = Visibility.Hidden;
                txtTipo.Visibility = Visibility.Hidden;
                rdbtnPelicula1.Visibility = Visibility.Hidden;
                rdbtnSerie1.Visibility = Visibility.Hidden;

                ((EditarSerie)(grdPrincipal.Children[0])).txtTituloES.Text = Programas[listProgram.SelectedIndex].Titulo;
                ((EditarSerie)(grdPrincipal.Children[0])).txtAñoES.Text = Programas[listProgram.SelectedIndex].Año.ToString();
                ((EditarSerie)(grdPrincipal.Children[0])).cbGeneroES.Text = Programas[listProgram.SelectedIndex].Genero;
                ((EditarSerie)(grdPrincipal.Children[0])).txtTemporadasES.Text = Programas[listProgram.SelectedIndex].Temporadas.ToString();
                ((EditarSerie)(grdPrincipal.Children[0])).txtProductorES.Text = Programas[listProgram.SelectedIndex].Productor;
                ((EditarSerie)(grdPrincipal.Children[0])).txtDescripcionES.Text = Programas[listProgram.SelectedIndex].Descripcion;
                ((EditarSerie)(grdPrincipal.Children[0])).txtRatingES.Text = Programas[listProgram.SelectedIndex].Rating.ToString();

                /* ((VisualizarSerie)(grdPrincipal.Children[0])).txtbTituloS.IsEnabled = true;
                 ((VisualizarSerie)(grdPrincipal.Children[0])).txtbAñoS.IsEnabled = true;
                 ((VisualizarSerie)(grdPrincipal.Children[0])).txtbProductorS.IsEnabled = true;
                 ((VisualizarSerie)(grdPrincipal.Children[0])).txtbDescripcionS.IsEnabled = true;
                 ((VisualizarSerie)(grdPrincipal.Children[0])).txtbTemporadasS.IsEnabled = true;
                 ((VisualizarSerie)(grdPrincipal.Children[0])).txtbGeneroS.IsEnabled = true;
                 ((VisualizarSerie)(grdPrincipal.Children[0])).txtbRatingS.IsEnabled = true; */
            }
        }

        private void BtnEliminarPV_Click(object sender, RoutedEventArgs e)
        {
            if (listProgram.SelectedIndex != -1)
            {
                Programas.RemoveAt(listProgram.SelectedIndex);
                grdPrincipal.Children.Clear();

                btnHabilitarEdicion.Visibility = Visibility.Hidden;
                btnEliminarPV.Visibility = Visibility.Hidden;
                btnCancelarPV.Visibility = Visibility.Hidden;
                btnActualizarE.Visibility = Visibility.Hidden;
                btnEliminarE.Visibility = Visibility.Hidden;
                btnCancelarE.Visibility = Visibility.Hidden;

                Img5estrellas.Visibility = Visibility.Hidden;
                Img4estrellas.Visibility = Visibility.Hidden;
                Img3estrellas.Visibility = Visibility.Hidden;
                Img2estrellas.Visibility = Visibility.Hidden;
                Img1estrella.Visibility = Visibility.Hidden;
                btnGuardarNuevojeje.Visibility = Visibility.Hidden;
                btnCancelarNuevo.Visibility = Visibility.Hidden;
                txtAgregarNuevo.Visibility = Visibility.Hidden;
                txtTipo.Visibility = Visibility.Hidden;
                rdbtnPelicula1.Visibility = Visibility.Hidden;
                rdbtnSerie1.Visibility = Visibility.Hidden;

                btnNuevoElemento.Visibility = Visibility.Visible;
                btnOrdenarAZ.Visibility = Visibility.Visible;
                btnOrdenarZA.Visibility = Visibility.Visible;
                btnAñoAscendente.Visibility = Visibility.Visible;
                btnAñoDescendente.Visibility = Visibility.Visible;
            }
        }

        private void BtnCancelarPV_Click(object sender, RoutedEventArgs e)
        {
            if (listProgram.SelectedIndex != -1)
            {
                grdPrincipal.Children.Clear();

                btnHabilitarEdicion.Visibility = Visibility.Hidden;
                btnEliminarPV.Visibility = Visibility.Hidden;
                btnCancelarPV.Visibility = Visibility.Hidden;
                btnActualizarE.Visibility = Visibility.Hidden;
                btnEliminarE.Visibility = Visibility.Hidden;
                btnCancelarE.Visibility = Visibility.Hidden;

                Img5estrellas.Visibility = Visibility.Hidden;
                Img4estrellas.Visibility = Visibility.Hidden;
                Img3estrellas.Visibility = Visibility.Hidden;
                Img2estrellas.Visibility = Visibility.Hidden;
                Img1estrella.Visibility = Visibility.Hidden;
                btnGuardarNuevojeje.Visibility = Visibility.Hidden;
                btnCancelarNuevo.Visibility = Visibility.Hidden;
                txtAgregarNuevo.Visibility = Visibility.Hidden;
                txtTipo.Visibility = Visibility.Hidden;
                rdbtnPelicula1.Visibility = Visibility.Hidden;
                rdbtnSerie1.Visibility = Visibility.Hidden;

                btnNuevoElemento.Visibility = Visibility.Visible;
                btnOrdenarAZ.Visibility = Visibility.Visible;
                btnOrdenarZA.Visibility = Visibility.Visible;
                btnAñoAscendente.Visibility = Visibility.Visible;
                btnAñoDescendente.Visibility = Visibility.Visible;
            }
        }

        private void BtnActualizarE_Click(object sender, RoutedEventArgs e)
        {
            if (Programas[listProgram.SelectedIndex].Clase == "Pelicula")
            {
                if (((Editar)(grdPrincipal.Children[0])).txtTituloEP.Text == "" ||
                    ((Editar)(grdPrincipal.Children[0])).txtAñoEP.Text == "" ||
                    ((Editar)(grdPrincipal.Children[0])).txtRatingEP.Text == "" ||
                    ((Editar)(grdPrincipal.Children[0])).cbGeneroEP.Text == "" ||
                    ((Editar)(grdPrincipal.Children[0])).txtDirectorEP.Text == "" ||
                    ((Editar)(grdPrincipal.Children[0])).txtSinopsisEP.Text == "")
                {
                    txtMensaje.Visibility = Visibility.Visible;
                }
                else
                {
                    grdPrincipal.Children.Add(new Editar());

                    //Para minimizar toda la información, hacemos lo siguiente

                    var variable1 =
                        ((Editar)(grdPrincipal.Children[0]));
                    var variable2 =
                        Programas[listProgram.SelectedIndex];

                    variable2.Titulo = variable1.txtTituloEP.Text;
                    variable2.Genero = variable1.cbGeneroEP.Text;
                    variable2.Director = variable1.txtDirectorEP.Text;
                    variable2.Sinopsis = variable1.txtSinopsisEP.Text;

                    var año =
                        variable2.Año.ToString();
                    var año2 =
                        Convert.ToInt32(((Editar)(grdPrincipal.Children[0])).txtAñoEP.Text);
                    Programas[listProgram.SelectedIndex].Año = año2;
                    var rating =
                        variable2.Rating.ToString();
                    var rating2 =
                        Convert.ToInt32(((Editar)(grdPrincipal.Children[0])).txtRatingEP.Text);
                    Programas[listProgram.SelectedIndex].Rating = rating2;

                    listProgram.Items.Refresh();
                    grdPrincipal.Children.Clear();
                    txtMensaje.Visibility = Visibility.Hidden;
                }

                btnNuevoElemento.Visibility = Visibility.Visible;
                btnOrdenarAZ.Visibility = Visibility.Visible;
                btnOrdenarZA.Visibility = Visibility.Visible;
                btnAñoAscendente.Visibility = Visibility.Visible;
                btnAñoDescendente.Visibility = Visibility.Visible;

                btnHabilitarEdicion.Visibility = Visibility.Hidden;
                btnEliminarPV.Visibility = Visibility.Hidden;
                btnCancelarPV.Visibility = Visibility.Hidden;
                btnActualizarE.Visibility = Visibility.Hidden;
                btnCancelarE.Visibility = Visibility.Hidden;
                btnEliminarE.Visibility = Visibility.Hidden;
                btnGuardarNuevojeje.Visibility = Visibility.Hidden;
                btnCancelarNuevo.Visibility = Visibility.Hidden;
                txtAgregarNuevo.Visibility = Visibility.Hidden;
                txtTipo.Visibility = Visibility.Hidden;
                rdbtnPelicula1.Visibility = Visibility.Hidden;
                rdbtnSerie1.Visibility = Visibility.Hidden;
                Img5estrellas.Visibility = Visibility.Hidden;
                Img4estrellas.Visibility = Visibility.Hidden;
                Img3estrellas.Visibility = Visibility.Hidden;
                Img2estrellas.Visibility = Visibility.Hidden;
                Img1estrella.Visibility = Visibility.Hidden;

                /*
                if (txtTituloEP.Text == "" || txtCodigoP.Text == "" || txtMarcaP.Text == "" || txtDescuentoP.Text == "" || txtPrecioP.Text == "")
                {
                    txtMensaje.Visibility = Visibility.Visible;

                }
                else
                {
                    grdPrincipal.Children.Clear();
                }
                */
            };

            if (Programas[listProgram.SelectedIndex].Clase == "Serie")
            {
                if (((EditarSerie)(grdPrincipal.Children[0])).txtTituloES.Text == "" ||
                    ((EditarSerie)(grdPrincipal.Children[0])).txtAñoES.Text == "" ||
                    ((EditarSerie)(grdPrincipal.Children[0])).txtRatingES.Text == "" ||
                    ((EditarSerie)(grdPrincipal.Children[0])).cbGeneroES.Text == "" ||
                    ((EditarSerie)(grdPrincipal.Children[0])).txtTemporadasES.Text == "" ||
                    ((EditarSerie)(grdPrincipal.Children[0])).txtProductorES.Text == "" ||
                    ((EditarSerie)(grdPrincipal.Children[0])).txtDescripcionES.Text == "")
                {
                    txtMensaje.Visibility = Visibility.Visible;
                }
                else
                {

                    if (Programas[listProgram.SelectedIndex].Clase == "Serie")
                    {

                        grdPrincipal.Children.Add(new EditarSerie());

                        var variable1 =
                            ((EditarSerie)(grdPrincipal.Children[0]));
                        var variable2 =
                            Programas[listProgram.SelectedIndex];

                        variable2.Titulo = variable1.txtTituloES.Text;
                        variable2.Genero = variable1.cbGeneroES.Text;
                        variable2.Productor = variable1.txtProductorES.Text;
                        variable2.Descripcion = variable1.txtDescripcionES.Text;

                        var año =
                            variable2.Año.ToString();
                        var año2 =
                            Convert.ToInt32(((EditarSerie)(grdPrincipal.Children[0])).txtAñoES.Text);
                        Programas[listProgram.SelectedIndex].Año = año2;
                        var rating =
                            variable2.Rating.ToString();
                        var rating2 =
                            Convert.ToInt32(((EditarSerie)(grdPrincipal.Children[0])).txtRatingES.Text);
                        Programas[listProgram.SelectedIndex].Rating = rating2;
                        var temporadas =
                            variable2.Temporadas.ToString();
                        var temporadas2 =
                            Convert.ToInt32(((EditarSerie)(grdPrincipal.Children[0])).txtTemporadasES.Text);
                        Programas[listProgram.SelectedIndex].Rating = temporadas2;

                        listProgram.Items.Refresh();
                        grdPrincipal.Children.Clear();
                        txtMensaje.Visibility = Visibility.Hidden;

                        btnNuevoElemento.Visibility = Visibility.Visible;
                        btnOrdenarAZ.Visibility = Visibility.Visible;
                        btnOrdenarZA.Visibility = Visibility.Visible;
                        btnAñoAscendente.Visibility = Visibility.Visible;
                        btnAñoDescendente.Visibility = Visibility.Visible;

                        btnHabilitarEdicion.Visibility = Visibility.Hidden;
                        btnEliminarPV.Visibility = Visibility.Hidden;
                        btnCancelarPV.Visibility = Visibility.Hidden;
                        btnActualizarE.Visibility = Visibility.Hidden;
                        btnCancelarE.Visibility = Visibility.Hidden;
                        btnEliminarE.Visibility = Visibility.Hidden;
                        btnGuardarNuevojeje.Visibility = Visibility.Hidden;
                        btnCancelarNuevo.Visibility = Visibility.Hidden;
                        txtAgregarNuevo.Visibility = Visibility.Hidden;
                        txtTipo.Visibility = Visibility.Hidden;
                        rdbtnPelicula1.Visibility = Visibility.Hidden;
                        rdbtnSerie1.Visibility = Visibility.Hidden;
                        Img5estrellas.Visibility = Visibility.Hidden;
                        Img4estrellas.Visibility = Visibility.Hidden;
                        Img3estrellas.Visibility = Visibility.Hidden;
                        Img2estrellas.Visibility = Visibility.Hidden;
                        Img1estrella.Visibility = Visibility.Hidden;
                    }
                }
            }
        }

        private void BtnEliminarE_Click(object sender, RoutedEventArgs e)
        {
            if (listProgram.SelectedIndex != -1)
            {
                Programas.RemoveAt(listProgram.SelectedIndex);
                grdPrincipal.Children.Clear();

                btnHabilitarEdicion.Visibility = Visibility.Hidden;
                btnEliminarPV.Visibility = Visibility.Hidden;
                btnCancelarPV.Visibility = Visibility.Hidden;
                btnActualizarE.Visibility = Visibility.Hidden;
                btnEliminarE.Visibility = Visibility.Hidden;
                btnCancelarE.Visibility = Visibility.Hidden;

                Img5estrellas.Visibility = Visibility.Hidden;
                Img4estrellas.Visibility = Visibility.Hidden;
                Img3estrellas.Visibility = Visibility.Hidden;
                Img2estrellas.Visibility = Visibility.Hidden;
                Img1estrella.Visibility = Visibility.Hidden;
                btnGuardarNuevojeje.Visibility = Visibility.Hidden;
                btnCancelarNuevo.Visibility = Visibility.Hidden;
                txtAgregarNuevo.Visibility = Visibility.Hidden;
                txtTipo.Visibility = Visibility.Hidden;
                rdbtnPelicula1.Visibility = Visibility.Hidden;
                rdbtnSerie1.Visibility = Visibility.Hidden;

                btnNuevoElemento.Visibility = Visibility.Visible;
                btnOrdenarAZ.Visibility = Visibility.Visible;
                btnOrdenarZA.Visibility = Visibility.Visible;
                btnAñoAscendente.Visibility = Visibility.Visible;
                btnAñoDescendente.Visibility = Visibility.Visible;
            }
        }

        private void BtnCancelarE_Click(object sender, RoutedEventArgs e)
        {
            if (listProgram.SelectedIndex != -1)
            {
                grdPrincipal.Children.Clear();

                btnHabilitarEdicion.Visibility = Visibility.Hidden;
                btnEliminarPV.Visibility = Visibility.Hidden;
                btnCancelarPV.Visibility = Visibility.Hidden;
                btnActualizarE.Visibility = Visibility.Hidden;
                btnEliminarE.Visibility = Visibility.Hidden;
                btnCancelarE.Visibility = Visibility.Hidden;

                Img5estrellas.Visibility = Visibility.Hidden;
                Img4estrellas.Visibility = Visibility.Hidden;
                Img3estrellas.Visibility = Visibility.Hidden;
                Img2estrellas.Visibility = Visibility.Hidden;
                Img1estrella.Visibility = Visibility.Hidden;
                btnGuardarNuevojeje.Visibility = Visibility.Hidden;
                btnCancelarNuevo.Visibility = Visibility.Hidden;
                txtAgregarNuevo.Visibility = Visibility.Hidden;
                txtTipo.Visibility = Visibility.Hidden;
                rdbtnPelicula1.Visibility = Visibility.Hidden;
                rdbtnSerie1.Visibility = Visibility.Hidden;

                btnNuevoElemento.Visibility = Visibility.Visible;
                btnOrdenarAZ.Visibility = Visibility.Visible;
                btnOrdenarZA.Visibility = Visibility.Visible;
                btnAñoAscendente.Visibility = Visibility.Visible;
                btnAñoDescendente.Visibility = Visibility.Visible;
            }
        }

        private void BtnOrdenarAZ_Click(object sender, RoutedEventArgs e)
        {
            bool ordenarAZ;
            do
            {
                ordenarAZ = false;
                for (int AZ = 0; AZ < (Programas.Count - 1); AZ++)
                {
                    if (string.Compare(Programas[AZ].Titulo, Programas[AZ + 1].Titulo) > 0)
                    {
                        var temp = Programas[AZ];
                        Programas[AZ] = Programas[AZ + 1];
                        Programas[AZ + 1] = temp;
                        ordenarAZ = true;
                    }
                }
            } while (ordenarAZ == true);
        }


        private void BtnOrdenarZA_Click(object sender, RoutedEventArgs e)
        {
            bool ordenarZA;
            do
            {
                ordenarZA = false;
                for (int ZA = 0; ZA < (Programas.Count - 1); ZA++)
                {
                    if (string.Compare(Programas[ZA].Titulo, Programas[ZA + 1].Titulo) < 0)
                    {
                        var temp = Programas[ZA];
                        Programas[ZA] = Programas[ZA + 1];
                        Programas[ZA + 1] = temp;
                        ordenarZA = true;
                    }
                }
            } while (ordenarZA == true);
        }

        private void BtnAñoAscendente_Click(object sender, RoutedEventArgs e)
        {
            int añoAscendente, i;
            añoAscendente = Programas.Count / 2;

            while (añoAscendente > 0)
            {
                for (i = 0; i < Programas.Count; i++)
                {
                    if (añoAscendente + i < Programas.Count && Programas[i].Año > Programas[añoAscendente + i].Año)
                    {
                        var temp = Programas[i];
                        Programas[i] = Programas[añoAscendente + i];
                        Programas[añoAscendente + i] = temp;
                    }
                }
                añoAscendente--;
            }
        }

        private void BtnAñoDescendente_Click(object sender, RoutedEventArgs e)
        {
            int añoDescendente, i;
            añoDescendente = Programas.Count / 2;

            while (añoDescendente > 0)
            {
                for (i = 0; i < Programas.Count; i++)
                {
                    if (añoDescendente + i < Programas.Count && Programas[i].Año < Programas[añoDescendente + i].Año)
                    {

                        var temp = Programas[i];
                        Programas[i] = Programas[añoDescendente + i];
                        Programas[añoDescendente + i] = temp;
                    }
                }
                añoDescendente--;
            }
        }


        private void BtnGuardarNuevo2_Click(object sender, RoutedEventArgs e)
        {
            if (((Película)(grdPrincipal.Children[0])).txtTituloP1.Text == "" ||
                   ((Película)(grdPrincipal.Children[0])).txtAñoP1.Text == "" ||
                   ((Película)(grdPrincipal.Children[0])).txtDirectorP1.Text == "" ||
                   ((Película)(grdPrincipal.Children[0])).txtSinopsisP1.Text == "" ||
                   ((Película)(grdPrincipal.Children[0])).txtGeneroP1.Text == "" ||
                   ((Película)(grdPrincipal.Children[0])).cbRatingP1.Text == "")
            {
                txtMensaje.Visibility = Visibility.Visible;
            }
            else
            {
                grdPrincipal.Children.Add(new Película());
                var añoPelicula1 = ((Película)(grdPrincipal.Children[0])).txtAñoP1.Text;
                int añoPelicula2 = int.Parse(añoPelicula1);
                var ratingPelicula1 = ((Película)(grdPrincipal.Children[0])).cbRatingP1.Text;
                int ratingPelicula2 = int.Parse(ratingPelicula1);

                Programas.Add(new ClasePelicula(
                    ((Película)(grdPrincipal.Children[0])).txtTipoP1.Text,
                    ((Película)(grdPrincipal.Children[0])).txtTituloP1.Text, añoPelicula2,
                    ((Película)(grdPrincipal.Children[0])).txtGeneroP1.Text,
                    ((Película)(grdPrincipal.Children[0])).txtDirectorP1.Text,
                    ((Película)(grdPrincipal.Children[0])).txtSinopsisP1.Text, ratingPelicula2));

                listProgram.Items.Refresh();
                grdPrincipal.Children.Clear();

                txtMensaje.Visibility = Visibility.Hidden;

                btnGuardarNuevojeje.Visibility = Visibility.Hidden;
                btnCancelarNuevo.Visibility = Visibility.Hidden;
                btnGuardarNuevo2.Visibility = Visibility.Hidden;
                txtAgregarNuevo.Visibility = Visibility.Hidden;
                txtTipo.Visibility = Visibility.Hidden;
                rdbtnPelicula1.Visibility = Visibility.Hidden;
                rdbtnSerie1.Visibility = Visibility.Hidden;
                Img5estrellas.Visibility = Visibility.Hidden;
                Img4estrellas.Visibility = Visibility.Hidden;
                Img3estrellas.Visibility = Visibility.Hidden;
                Img2estrellas.Visibility = Visibility.Hidden;
                Img1estrella.Visibility = Visibility.Hidden;

                btnNuevoElemento.Visibility = Visibility.Visible;
                btnOrdenarAZ.Visibility = Visibility.Visible;
                btnOrdenarZA.Visibility = Visibility.Visible;
                btnAñoAscendente.Visibility = Visibility.Visible;
                btnAñoDescendente.Visibility = Visibility.Visible;
            };

            if (((Serie)(grdPrincipal.Children[0])).txtTituloS1.Text == "" ||
               ((Serie)(grdPrincipal.Children[0])).txtAñoS1.Text == "" ||
               ((Serie)(grdPrincipal.Children[0])).txtProductorS1.Text == "" ||
               ((Serie)(grdPrincipal.Children[0])).txtTemporadasS1.Text == "" ||
               ((Serie)(grdPrincipal.Children[0])).txtDescripcionS1.Text == "" ||
               ((Serie)(grdPrincipal.Children[0])).cbGeneroS1.Text == "" ||
               ((Serie)(grdPrincipal.Children[0])).cbRatingS1.Text == "")
            {
                txtMensaje.Visibility = Visibility.Visible;
            }
            else
            {
                var añoSerie1 = ((Serie)(grdPrincipal.Children[0])).txtAñoS1.Text;
                int añoSerie2 = int.Parse(añoSerie1);
                var ratingSerie1 = ((Serie)(grdPrincipal.Children[0])).cbRatingS1.Text;
                int ratingSerie2 = int.Parse(ratingSerie1);
                var temporadasSerie1 = ((Serie)(grdPrincipal.Children[0])).txtTemporadasS1.Text;
                int temporadasSerie2 = int.Parse(temporadasSerie1);

                Programas.Add(new ClaseSerie(
                    ((Serie)(grdPrincipal.Children[0])).txtTipoS1.Text,
                    ((Serie)(grdPrincipal.Children[0])).txtTituloS1.Text, añoSerie2,
                    ((Serie)(grdPrincipal.Children[0])).cbGeneroS1.Text, temporadasSerie2,
                    ((Serie)(grdPrincipal.Children[0])).txtProductorS1.Text,
                    ((Serie)(grdPrincipal.Children[0])).txtDescripcionS1.Text, ratingSerie2));

                listProgram.Items.Refresh();
                grdPrincipal.Children.Clear();

                btnGuardarNuevojeje.Visibility = Visibility.Hidden;
                btnGuardarNuevo2.Visibility = Visibility.Hidden;
                btnCancelarNuevo.Visibility = Visibility.Hidden;
                txtAgregarNuevo.Visibility = Visibility.Hidden;
                txtTipo.Visibility = Visibility.Hidden;
                rdbtnPelicula1.Visibility = Visibility.Hidden;
                rdbtnSerie1.Visibility = Visibility.Hidden;
                Img5estrellas.Visibility = Visibility.Hidden;
                Img4estrellas.Visibility = Visibility.Hidden;
                Img3estrellas.Visibility = Visibility.Hidden;
                Img2estrellas.Visibility = Visibility.Hidden;
                Img1estrella.Visibility = Visibility.Hidden;

                btnNuevoElemento.Visibility = Visibility.Visible;
                btnOrdenarAZ.Visibility = Visibility.Visible;
                btnOrdenarZA.Visibility = Visibility.Visible;
                btnAñoAscendente.Visibility = Visibility.Visible;
                btnAñoDescendente.Visibility = Visibility.Visible;

                txtMensaje.Visibility = Visibility.Hidden;
            };
        }

        private void BtnGuardarNuevojeje_Click(object sender, RoutedEventArgs e)
        {
            if (((Serie)(grdPrincipal.Children[0])).txtTituloS1.Text == "" ||
               ((Serie)(grdPrincipal.Children[0])).txtAñoS1.Text == "" ||
               ((Serie)(grdPrincipal.Children[0])).txtProductorS1.Text == "" ||
               ((Serie)(grdPrincipal.Children[0])).txtTemporadasS1.Text == "" ||
               ((Serie)(grdPrincipal.Children[0])).txtDescripcionS1.Text == "" ||
               ((Serie)(grdPrincipal.Children[0])).cbGeneroS1.Text == "" ||
               ((Serie)(grdPrincipal.Children[0])).cbRatingS1.Text == "")
            {
                txtMensaje.Visibility = Visibility.Visible;
            }
            else
            {
                var añoSerie1 = ((Serie)(grdPrincipal.Children[0])).txtAñoS1.Text;
                int añoSerie2 = int.Parse(añoSerie1);
                var ratingSerie1 = ((Serie)(grdPrincipal.Children[0])).cbRatingS1.Text;
                int ratingSerie2 = int.Parse(ratingSerie1);
                var temporadasSerie1 = ((Serie)(grdPrincipal.Children[0])).txtTemporadasS1.Text;
                int temporadasSerie2 = int.Parse(temporadasSerie1);

                Programas.Add(new ClaseSerie(
                    ((Serie)(grdPrincipal.Children[0])).txtTipoS1.Text,
                    ((Serie)(grdPrincipal.Children[0])).txtTituloS1.Text, añoSerie2,
                    ((Serie)(grdPrincipal.Children[0])).cbGeneroS1.Text, temporadasSerie2,
                    ((Serie)(grdPrincipal.Children[0])).txtProductorS1.Text,
                    ((Serie)(grdPrincipal.Children[0])).txtDescripcionS1.Text, ratingSerie2));

                listProgram.Items.Refresh();
                grdPrincipal.Children.Clear();

                btnGuardarNuevojeje.Visibility = Visibility.Hidden;
                btnGuardarNuevo2.Visibility = Visibility.Hidden;
                btnCancelarNuevo.Visibility = Visibility.Hidden;
                txtAgregarNuevo.Visibility = Visibility.Hidden;
                txtTipo.Visibility = Visibility.Hidden;
                rdbtnPelicula1.Visibility = Visibility.Hidden;
                rdbtnSerie1.Visibility = Visibility.Hidden;
                Img5estrellas.Visibility = Visibility.Hidden;
                Img4estrellas.Visibility = Visibility.Hidden;
                Img3estrellas.Visibility = Visibility.Hidden;
                Img2estrellas.Visibility = Visibility.Hidden;
                Img1estrella.Visibility = Visibility.Hidden;

                btnNuevoElemento.Visibility = Visibility.Visible;
                btnOrdenarAZ.Visibility = Visibility.Visible;
                btnOrdenarZA.Visibility = Visibility.Visible;
                btnAñoAscendente.Visibility = Visibility.Visible;
                btnAñoDescendente.Visibility = Visibility.Visible;

                txtMensaje.Visibility = Visibility.Hidden;
            };
        }
    }
}