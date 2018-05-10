using System;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var c1 = new Cliente("1", "Orange");
            var c2 = new Cliente("2", "Movistar");
            var c3 = new Cliente("3", "Vodafone");

            Console.WriteLine(Cliente.NombreClase);
            Console.WriteLine("¿Cuantas referencias hay? " + Cliente.numeroReferencias());
        }
    }


public class Cliente
{
    public static string NombreClase = "Cliente";

    private static int contadorReferencias;
    public static int numeroReferencias()
    {
        return contadorReferencias;
    }
    public string Codigo{get; set;}
    public string Nombre{get; set;}

    public Cliente(string codigo, string nombre)
    {
        contadorReferencias++;
        
        Codigo = codigo;
        Nombre = nombre;
    }
}
}