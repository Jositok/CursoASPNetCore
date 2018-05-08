using System;
using System.Collections.Generic;
using System.Linq;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
        
            //Una "Colección es una lista de elementos que se trata como una unidad. Permite manipular su contenido.

            //Matriz
            string[] listaNombres = {"Antonio", "Bea", "Mario","Jose"};

            Console.WriteLine("Elementos en lista: " + listaNombres.Length);

            for(int i = 0; i<listaNombres.Length; i++)
            {
                Console.WriteLine(listaNombres[i]);
            }


            //Lista
            List<Decimal> precios = new List<decimal>();
            precios.Add(23.23m);
            precios.Add(11.4523m);
            precios.Add(90.50m);

            var miPrecio = precios[2];

            var p1 = new Producto("1", "Mahou", 15);
            var p2 = new Producto("2", "Alhambra", 27);
            var p3 = new Producto("3", "Amstel", 15);

            List<Producto> productos = new List<Producto>();
            productos.Add(p1);
            productos.Add(p2);
            productos.Add(p3);
            productos.Add(new Producto("4", "Cruzcampo", 12));
            productos.Add(new Producto("5", "Mahou Negra", 9));

            // Lambda (Función anónima)
            var mahou = productos.Where(p => p.Nombre.Contains("Mah"));
            Console.WriteLine("¿Hay mahou? " + mahou.Any());
            ListarProductos(mahou.ToList());

            ListarProductos(productos);
            IncrementarPrecio(productos, 5);
            ListarProductos(productos);

            

            
            
        }

        private static void IncrementarPrecio(List<Producto> productos, double porcentaje)
        {
            var aplicar = 1 +(porcentaje/100);
            foreach (var producto in productos)
            {
                producto.Precio += producto.Precio * aplicar;
            }
        }

        private static void ListarProductos(List<Producto> productos)
        {
            foreach (var producto in productos)
            {
                Console.WriteLine(producto.Codigo + " " + producto.Nombre + " " + producto.Precio);
            }
        }
    }

    public class Producto
    {
        public string Codigo {get; set;}
        public string Nombre {get; set;}
        public double Precio {get; set;}

        public Producto(string codigo, string nombre, double precio)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
        }
    }
}
