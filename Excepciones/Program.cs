using System;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
        try{
            Program myProgram = null;
            Console.WriteLine(myProgram.ToString());
        }
        catch (System.NullReferenceException )
        {

        }
        Console.WriteLine("La vida sigue");
    }
}

    public class Vehiculo
    {
        public Motor Motor{get; set;}
    }

    public class Motor
    {
        public string Combustible{get; set;}
        public Motor(string combustible)
        {
            Combustible = combustible;
        }
    }

}
