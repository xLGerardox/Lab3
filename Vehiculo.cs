public class Vehiculo
{
    public string Matricula { get; set; }
    public string Modelo { get; set; }
    public string TipoCombustible { get; set; }

    public Vehiculo(string matricula, string modelo, string tipoCombustible)
    {
        Matricula = matricula;
        Modelo = modelo;
        TipoCombustible = tipoCombustible;
    }
}
