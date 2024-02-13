using Lab1;
using System;

public class LibroDigital : Libro
{
    public string Formato { get; set; }
    public int NumeroDePaginas { get; set; }

    public LibroDigital(string titulo, string autor, int añoPublicacion, double precio, string formato, int numeroDePaginas)
        : base(titulo, autor, añoPublicacion, precio)
    {
        Formato = formato;
        NumeroDePaginas = numeroDePaginas;
    }

    public override void Describir()
    {
        Console.WriteLine($"Título: {Titulo}");
        Console.WriteLine($"Autor: {Autor}");
        Console.WriteLine($"Año de publicación: {AñoPublicacion}");
        Console.WriteLine($"Precio: {Precio:C}");
        Console.WriteLine($"Formato: {Formato}");
        Console.WriteLine($"Número de páginas: {NumeroDePaginas}");
    }
}



