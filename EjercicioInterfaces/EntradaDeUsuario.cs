public class EntradaDeUsuario
{
    public double ObtenerEntrada(string mensaje)
    {
        Console.WriteLine(mensaje);
        return Convert.ToDouble(Console.ReadLine());
    }
}
