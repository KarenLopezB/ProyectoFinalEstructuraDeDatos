using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalEstructuraDeDatos
{
    class ClaseSerie : Program
    {
        public ClaseSerie(string clase, string titulo, int año, string genero, int temporadas, string productor, string descripcion, int rating)
        {
            this.Clase = clase;
            this.Titulo = titulo;
            this.Año = año;
            this.Genero = genero;
            this.Temporadas = temporadas;
            this.Productor = productor;
            this.Descripcion = descripcion;
            this.Rating = rating;
        }

        /* public override string ToString()
        {
            return this.Titulo +
                "(" + this.Año.ToString() +
                ")";
        } */
    }
}
