public class Cliente
{
    public string Nombre { get; set; }
    public string CorreoElectronico { get; set; }
    public string Direccion { get; set; }

    public Cliente(string nombre, string correoElectronico, string direccion)
    {
        Nombre = nombre;
        CorreoElectronico = correoElectronico;
        Direccion = direccion;
    }
}