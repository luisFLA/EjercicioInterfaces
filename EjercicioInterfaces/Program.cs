class Program
{
    static void Main(string[] args)
    {
        EjercicioInterfaces operaciones = new OperacionesGeometricas();
        ImpresionDeResultados impresionDeResultados = new ImpresionDeResultados(operaciones);

        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("\n--- Menú de Operaciones Geométricas ---");
            Console.WriteLine("1. Calcular Área de un Cuadrado");
            Console.WriteLine("2. Calcular Área de un Círculo");
            Console.WriteLine("3. Calcular Volumen de un Cubo");
            Console.WriteLine("4. Calcular Longitud de una Circunferencia");
            Console.WriteLine("5. Calcular Área de un Triángulo");
            Console.WriteLine("6. Salir");
            Console.Write("Seleccione una opción: ");

            int opcion = int.Parse(Console.ReadLine());

            if (opcion == 6)
            {
                continuar = false;
                Console.WriteLine("Saliendo del programa...");
            }
            else
            {
                impresionDeResultados.ImprimirResultados(opcion);
            }
        }
    }
}
