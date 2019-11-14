using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalEstructuraDeDatos
{
    class ClasePelicula
    {
        public string Titulop { get; set; }
        public int Añop { get; set; }

        public ClasePelicula(string titulop, int añop)
        {
            this.Titulop = titulop;
            this.Añop = añop;
        }

        public override string ToString()
        {
            return this.Titulop +
                "(" + this.Añop.ToString() +
                ")";
        }
    }
}
