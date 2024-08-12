public class ClienteVIP : Cliente
{
    public float Descuento { get; set; }

    public ClienteVIP(string nombre, string correoElectronico, string direccion, float descuento)
        : base(nombre, correoElectronico, direccion)
    {
        Descuento = descuento;
    }
}
