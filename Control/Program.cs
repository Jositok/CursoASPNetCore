using System;

namespace Control
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //If - else
            Console.WriteLine("Pulsa la tecla 5");
            var a = Console.ReadKey();
            var teclaPulsada = a.KeyChar;
            
            if(teclaPulsada == '5')
            {
                Console.WriteLine("Has pulsado 5");
            }
            else
            {
                Console.WriteLine("No has pulsado el 5...");
            }
            // Switch

            switch(teclaPulsada)
            {
                case 'a':
                    Console.WriteLine("Añadir elemento");
                    break;
                case 'b':
                    Console.WriteLine("Listar elementos");
                    break;
                case 'c':
                    Console.WriteLine("Eliminar elemento");
                    break;
            }
            
            //Iteraciones

            // While
            int i =5;
            while(i<5)
            {
                Console.WriteLine(i++);
            }

            // Do While
            int x = 0;
            do
            {
                Console.WriteLine(x++);
            }
            while(x<7);

            // For
            for(int b = 0; b<10; b++)
            {
                Console.WriteLine(b);
            }
        }
    }
}
