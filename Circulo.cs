// Clase que encapsula el dato primitivo "radio"
    // y permite calcular área y perímetro del círculo.
    public class Circulo
    {
        private double radio; // Se oculta para proteger el dato

        // Constructor para inicializar el círculo con un radio
        public Circulo(double valorRadio)
        {
            radio = valorRadio;
        }

        // Método que calcula el área con la fórmula: π * radio²
        public double CalcularArea()
        {
            return Math.PI * radio * radio;
        }

        // Método que calcula el perímetro con la fórmula: 2 * π * radio
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }
    }
