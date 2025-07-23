using System;
using PracticaClases;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bienvenido!!");
Console.WriteLine("Por favor, ingrese el nombre que saga le gustaria ver");
string saga = Console.ReadLine();

int anioPublicacion = 0;
string numeroPelicula = "";
string personajeFavorito = "";

Console.Write("Coloque el numero de la saga:  ");
numeroPelicula = Console.ReadLine();
Console.Write("\nColoque el nombre de su personaje favorito:  ");
personajeFavorito = Console.ReadLine();


if (saga == "Harry Potter")
{
    if (numeroPelicula == "1") { { numeroPelicula = "Harry Potter y la piedra filosofal"; anioPublicacion = 2010; } }
    else if (numeroPelicula == "2") { numeroPelicula = "Harry Potter y la camara secreta"; anioPublicacion = 2011; }
    else if (numeroPelicula == "3") { numeroPelicula = "Harry Potter y el prisionero de Azkaban"; anioPublicacion = 2012; }
    else if (numeroPelicula == "4") { numeroPelicula = "Harry Potter y el caliz de fuego"; anioPublicacion = 2013; }
    else if (numeroPelicula == "5") { numeroPelicula = "Harry Potter y la orden del fenix"; anioPublicacion = 2014; }
    else if (numeroPelicula == "6") { numeroPelicula = "Harry Potter y el misterio del principe"; anioPublicacion = 2015; }
    else if (numeroPelicula == "7") { numeroPelicula = "Harry Potter y las reliquias de la muerte Parte 1"; anioPublicacion = 2016; }
    else if (numeroPelicula == "8") { numeroPelicula = "Harry Potter y las reliquias de la muerte Parte 2"; anioPublicacion = 2019; }
    else Console.WriteLine("Número de película no reconocido. Por favor, intente nuevamente.");

        var libro = new HarryPotter("Harry Potter", "JK", anioPublicacion, numeroPelicula, personajeFavorito);
    Console.WriteLine($"Título: {libro.Titulo}");
    Console.WriteLine($"Autor: {libro.Autor}");
    Console.WriteLine($"Año de Publicación: {libro.AnioPublicacion}");
    Console.WriteLine($"Número de Película: {numeroPelicula}");
    Console.WriteLine($"Personaje Favorito: {personajeFavorito}");

} else if (saga == "El Señor de los Anillos")
{
    if (numeroPelicula == "1") { { numeroPelicula = "El Señor de los Anillos: La comunidad del Anillo"; anioPublicacion = 2010; } }
    else if (numeroPelicula == "2") { numeroPelicula = "El Señor de los Anillos: Las Dos torres"; anioPublicacion = 2011; }
    else if (numeroPelicula == "3") { numeroPelicula = "El Señor de los Anillos: El retorno del Rey"; anioPublicacion = 2012; }
    else if (numeroPelicula == "4") { numeroPelicula = "El Hobbit"; anioPublicacion = 2013; }
    else Console.WriteLine("Número de película no reconocido. Por favor, intente nuevamente.");

    var libro = new HarryPotter("El Señor de los Anillos", "J.R.R. Tolkien", anioPublicacion, numeroPelicula, personajeFavorito);
    Console.WriteLine($"Título: {libro.Titulo}");
    Console.WriteLine($"Autor: {libro.Autor}");
    Console.WriteLine($"Año de Publicación: {libro.AnioPublicacion}");
    Console.WriteLine($"Número de Película: {numeroPelicula}");
    Console.WriteLine($"Personaje Favorito: {personajeFavorito}");
}
else 
{
    Console.WriteLine("Saga no reconocida. Por favor, intente nuevamente.");
}
