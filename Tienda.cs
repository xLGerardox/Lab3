public class Tienda
{
    public List<Cliente> Clientes { get; set; }
    public List<Vehiculo> Vehiculos { get; set; }
    public List<Pedido> Pedidos { get; set; }

    public Tienda()
    {
        Clientes = new List<Cliente>();
        Vehiculos = new List<Vehiculo>();
        Pedidos = new List<Pedido>();
    }
}

