namespace MisClases.Gente{
    
    public enum Genero
        {
            Hombre,
            Mujer
        }

    

    public abstract class Persona
    {
        public string Nombre{get; set;}
        public string Apellidos{get; set;}
        public int Edad{get; set;}
        public Genero Genero{get; set;}

        public Persona(string nombre, string apellidos, int edad, Genero genero)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Edad = edad;
            Genero = genero;
        }

        public abstract string GetNombreCompleto();

        public abstract string GetDatos();

        
    

        public bool EsMayorDeEdad()
        {
            return Edad>=18;
        }


        
    }

    
  //  public class Aristocrata : Persona
    //{
      //  public Aristocrata(string nombre, string apellidos, int edad, Genero genero) 
        //: base(nombre, apellidos, edad, genero)
        //{
        //}
        //public string Titulo{get; set;}
    //}//

}