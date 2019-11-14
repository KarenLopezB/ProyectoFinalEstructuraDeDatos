using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalEstructuraDeDatos
{
    class ClaseSerie
    {
        public string Titulos { get; set; }
        public int Años { get; set; }

        public ClaseSerie(string titulos, int años)
        {
            this.Titulos = titulos;
            this.Años = años;
        }

        public override string ToString()
        {
            return this.Titulos +
                "(" + this.Años.ToString() +
                ")";
        }
    }
}
