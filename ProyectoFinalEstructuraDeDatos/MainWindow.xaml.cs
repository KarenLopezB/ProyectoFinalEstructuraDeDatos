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

            ClasePelicula peli1 = (new ClasePelicula("En busca de la felicidad", 2006, "Drama", 
                "Gabriele Muccino", "La vida es una lucha para Chris Gardner. Expulsado de su apartamento, él y su joven " +
                "hijo se encuentran solos sin ningún lugar a donde ir.A pesar de que Chris eventualmente " +
                "consigue trabajo como interno en una prestigiada firma financiera, la posición no le da dinero." +
                "El dúo debe vivir en un albergue y enfrentar muchas dificultades, pero Chris no se da por " +
                "vencido y lucha por conseguir una vida mejor para él y su hijo.", 4));
            ClasePelicula peli2 = (new ClasePelicula("Cenicienta", 1950, "Fantasía", 
                "Clyde Geronimi, Hamilton Luske, Wilfred Jackson", "Con una malvada madrastra y dos hermanastras " +
                "celosas que la mantienen esclavizada y en harapos, Cenicienta no tiene oportunidad de asistir " +
                "al baile real, hasta que aparece su hada madrina.", 4));
            ClasePelicula peli3 = (new ClasePelicula("Shrek", 2001, "Comedia", "Andrew Adamson, Vicky Jenson",
                "Había una vez, en un pantano muy lejano, vivía un ogro llamado Shrek (Mike Myers) cuya preciosa " +
                "soledad se ve súbitamente interrumpida por la invasión de los ruidosos personajes de los cuentos " +
                "de hadas.Todos fueron expulsados de sus reinos por el malvado Lord Farquaad(John Lithgow). " +
                "Decidido a salvar su casa, Shrek hace un trato con Farquaad y se prepara para rescatar a la " +
                "princesa Fiona(Cameron Diaz) para que sea la novia de Farquaad.", 5));

            ClaseSerie serie1 = (new ClaseSerie("3%", 2016, "Thriller", 3, "César Charlone, Tiago Mello",
                "En un futuro no muy lejano, los ciudadanos luchan por formar parte del grupo de los privilegiados " +
                "y así evitar caer en la devastación.", 4));
            ClaseSerie serie2 = (new ClaseSerie("Stranger Things", 2016, "Ciencia Ficción", 3,
                "Shawn Levy, Dan Cohen", "Cuando un niño desaparece, sus amigos, la familia y la policía se ven " +
                "envueltos en una serie de eventos misteriosos al tratar de encontrarlo.Su ausencia coincide con " +
                "el avistamiento de una criatura terrorífica y la aparición de una extraña niña.", 5));
            ClaseSerie serie3 = (new ClaseSerie("13 Reasons Why", 2015, "Drama", 3, "Joseph Incaprera",
                "Después de que una mujer joven se quite la vida, su compañero de clase encuentra una misteriosa " +
                "caja en su patio.", 5));

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
            btnOrdenarAZ.Visibility = Visibility.Hidden;
            btnOrdenarZA.Visibility = Visibility.Hidden;
            btnAñoAscendente.Visibility = Visibility.Hidden;
            btnAñoDescendente.Visibility = Visibility.Hidden;
            btnNuevoElemento.Visibility = Visibility.Hidden;

        }

        private void listProgram_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listProgram.SelectedIndex != -1)
            {
                grdPrincipal.Children.Clear();
                grdPrincipal.Children.Add(new VisualizarPelícula());


                btnNuevoElemento.Visibility = Visibility.Hidden;
                btnOrdenarAZ.Visibility = Visibility.Hidden;
                btnOrdenarZA.Visibility = Visibility.Hidden;
                btnAñoAscendente.Visibility = Visibility.Hidden;
                btnAñoDescendente.Visibility = Visibility.Hidden;


                ((VisualizarPelícula)(listProgram.Children[0])).txtbTitulo.Text = Program[listProgram.SelectedIndex].Titulo;
                ((VisualizarPelícula)(listProgram.Children[0])).cb_genero.Text = Program[listProgram.SelectedIndex].Genero;
                ((VisualizarPelícula)(listProgram.Children[0])).cb_sinopsis.Text = Program[listProgram.SelectedIndex].Sinopsis;
                ((VisualizarSerie)(listProgram.Children[0])).cb_productor.Text = Program[listProgram.SelectedIndex].Productor;
                ((VisualizarPelícula)(listProgram.Children[0])).cb_director.Text = Program[listProgram.SelectedIndex].Director;
            }
        }
    }
}
