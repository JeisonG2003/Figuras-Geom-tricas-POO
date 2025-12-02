 // Clase principal desde donde se ejecuta el programa
    class Program
    {
        static void Main(string[] args)
        {
            // Se crean los objetos y se envían valores a los constructores
            Circulo figuraCirculo = new Circulo(5);
            Triangulo figuraTriangulo = new Triangulo(7, 4, 5, 6, 7);

            Console.WriteLine("===== FIGURA: CÍRCULO =====");
            Console.WriteLine("Área del círculo: " + figuraCirculo.CalcularArea());
            Console.WriteLine("Perímetro del círculo: " + figuraCirculo.CalcularPerimetro());

            Console.WriteLine("\n===== FIGURA: TRIÁNGULO =====");
            Console.WriteLine("Área del triángulo: " + figuraTriangulo.CalcularArea());
            Console.WriteLine("Perímetro del triángulo: " + figuraTriangulo.CalcularPerimetro());

            // Pausa para evitar que la consola se cierre de inmediato
            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }