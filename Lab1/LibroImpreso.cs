using Lab1;
using System;

public class LibroImpreso : Libro
{
    public int NumeroDePaginas { get; set; }

    public LibroImpreso(string titulo, string autor, int añoPublicacion, double precio, int numeroDePaginas)
        : base(titulo, autor, añoPublicacion, precio)
    {
        NumeroDePaginas = numeroDePaginas;
    }

    public override void Describir()
    {
        Console.WriteLine($"Título: {Titulo}");
        Console.WriteLine($"Autor: {Autor}");
        Console.WriteLine($"Año de publicación: {AñoPublicacion}");
        Console.WriteLine($"Precio: {Precio:C}");
        Console.WriteLine($"Número de páginas: {NumeroDePaginas}");
    }
}



