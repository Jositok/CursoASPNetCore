public class Producto
{

    private decimal _precioPorDefecto;
    public string Codigo{get; private set;}

    public string Nombre{get; set;}

    public decimal Precio{get; set;}

    public Producto()
    {
        Precio = _precioPorDefecto;
    }
    
    public Producto (string codigo, string nombre)
    {
        Codigo = codigo;
        Nombre = nombre;
        Precio = _precioPorDefecto;       
    }
    public Producto(string codigo, string nombre, decimal precio)
    {
        Codigo = codigo;
        Nombre = nombre;
        Precio = precio;
    }
    public string GetDescripcionProducto(){
        return GetCodigo() + " - " + Nombre + " " + Precio + " con IVA " + GetPrecioConIVA();
    }

    public decimal GetPrecioConIVA()
    {
        return Precio * 1.21m;
    }

    private string GetCodigo()
    {
        return "Cod.: " + Codigo;
    }

}