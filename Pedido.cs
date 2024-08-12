public class Pedido
{
    public int NumeroPedido { get; set; }
    public DateTime Fecha { get; set; }
    public Cliente Cliente { get; set; }
    public List<Producto> Productos { get; set; }
    public float Total { get; set; }

    public Pedido(int numeroPedido, DateTime fecha, Cliente cliente)
    {
        NumeroPedido = numeroPedido;
        Fecha = fecha;
        Cliente = cliente;
        Productos = new List<Producto>();
        Total = 0;
    }

    public void CalcularTotal()
    {
        Total = Productos.Sum(p => p.Precio);

        if (Cliente is ClienteVIP vip)
        {
            Total -= Total * vip.Descuento / 100;
        }
        else if (Cliente is ClienteCorporativo corporativo)
        {
            Total -= Total * corporativo.Descuento / 100;
        }
    }
}

