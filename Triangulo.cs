// Clase que encapsula datos primitivos de un triángulo
    // (base, altura y tres lados) para calcular área y perímetro.
    public class Triangulo
    {
        private double baseT;
        private double altura;
        private double ladoA;
        private double ladoB;
        private double ladoC;

        // Constructor que inicializa las medidas del triángulo
        public Triangulo(double baseTriangulo, double alt, double a, double b, double c)
        {
            baseT = baseTriangulo;
            altura = alt;
            ladoA = a;
            ladoB = b;
            ladoC = c;
        }

        // Fórmula del área: (base × altura) / 2
        public double CalcularArea()
        {
            return (baseT * altura) / 2;
        }

        // Perímetro del triángulo: suma de los tres lados
        public double CalcularPerimetro()
        {
            return ladoA + ladoB + ladoC;
        }
    }
