public class OperacionesGeometricas : EjercicioInterfaces
{
    public double CalcularAreaCuadrado(double lado)
    {
        return lado * lado;
    }

    public double CalcularAreaCirculo(double radio)
    {
        return Math.PI * radio * radio;
    }

    public double CalcularVolumenCubo(double lado)
    {
        return lado * lado * lado;
    }

    public double CalcularLongitudCircunferencia(double radio)
    {
        return 2 * Math.PI * radio;
    }

    public double CalcularAreaTriangulo(double baseTriangulo, double altura)
    {
        return (baseTriangulo * altura) / 2;
    }
}
