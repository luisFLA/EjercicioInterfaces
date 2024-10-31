public class ImpresionDeResultados
{
    private readonly EjercicioInterfaces _operaciones;

    public ImpresionDeResultados(EjercicioInterfaces operaciones)
    {
        _operaciones = operaciones;
    }

    public void ImprimirResultados(int opcion)
    {
        EntradaDeUsuario entrada = new EntradaDeUsuario();

        switch (opcion)
        {
            case 1:
                double ladoCuadrado = entrada.ObtenerEntrada("Ingrese el lado del cuadrado:");
                Console.WriteLine($"Área del cuadrado: {_operaciones.CalcularAreaCuadrado(ladoCuadrado)}");
                break;

            case 2:
                double radioCirculo = entrada.ObtenerEntrada("Ingrese el radio del círculo:");
                Console.WriteLine($"Área del círculo: {_operaciones.CalcularAreaCirculo(radioCirculo)}");
                break;

            case 3:
                double ladoCubo = entrada.ObtenerEntrada("Ingrese el lado del cubo:");
                Console.WriteLine($"Volumen del cubo: {_operaciones.CalcularVolumenCubo(ladoCubo)}");
                break;

            case 4:
                double radioCircunferencia = entrada.ObtenerEntrada("Ingrese el radio de la circunferencia:");
                Console.WriteLine($"Longitud de la circunferencia: {_operaciones.CalcularLongitudCircunferencia(radioCircunferencia)}");
                break;

            case 5:
                double baseTriangulo = entrada.ObtenerEntrada("Ingrese la base del triángulo:");
                double alturaTriangulo = entrada.ObtenerEntrada("Ingrese la altura del triángulo:");
                Console.WriteLine($"Área del triángulo: {_operaciones.CalcularAreaTriangulo(baseTriangulo, alturaTriangulo)}");
                break;

            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }
}
