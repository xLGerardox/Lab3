public class Producto
{
    public string Nombre { get; set; }
    public float Precio { get; set; }

    public Producto(string nombre, float precio)
    {
        Nombre = nombre;
        Precio = precio;
    }
}
