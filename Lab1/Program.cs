using Lab1;
using System;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        
        LibroDigital ebook = new LibroDigital("La Sombra del Viento", "Carlos Ruiz Zafón", 2001, 12.99, "PDF", 3);
        LibroImpreso libroImpreso = new LibroImpreso("Cien años de soledad", "Gabriel García Márquez", 1967, 25.50, 432);

        
        Console.WriteLine("Detalles del libro digital:");
        ebook.Describir();

        Console.WriteLine("\nDetalles del libro impreso:");
        libroImpreso.Describir();

        
        List<Libro> listaLibros = new List<Libro>();
        listaLibros.Add(ebook);
        listaLibros.Add(libroImpreso);
        double precioTotal = Libro.CalcularPrecioTotal(listaLibros);
        Console.WriteLine($"\nPrecio total de los libros: {precioTotal:C}");
    }
}

