using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
   
using System.Collections.Generic;

public abstract class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AñoPublicacion { get; set; }
        public double Precio { get; set; }

        public Libro(string titulo, string autor, int añoPublicacion, double precio)
        {
            Titulo = titulo;
            Autor = autor;
            AñoPublicacion = añoPublicacion;
            Precio = precio;
        }

        public abstract void Describir();

        public static double CalcularPrecioTotal(List<Libro> libros)
        {
            double total = 0;
            foreach (var libro in libros)
            {
                total += libro.Precio;
            }
            return total;
        }
    }


}

