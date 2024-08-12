public class VehiculoCorporativo : Vehiculo
{
    public ClienteCorporativo Propietario { get; set; }

    public VehiculoCorporativo(string matricula, string modelo, string tipoCombustible, ClienteCorporativo propietario)
        : base(matricula, modelo, tipoCombustible)
    {
        Propietario = propietario;
    }
}
