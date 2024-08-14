public class ClienteCorporativo : Cliente
{
    public float Descuento { get; set; }
    public List<VehiculoCorporativo> Vehiculos { get; set; }

    public ClienteCorporativo(string nombre, string correoElectronico, string direccion, float descuento)
        : base(nombre, correoElectronico, direccion)
    {
        Descuento = descuento;
        Vehiculos = new List<VehiculoCorporativo>();
    }
}

