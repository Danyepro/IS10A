namespace Application
{
    public class Triangulo
    {
        // Método para calcular el perímetro de un triángulo
        public static double Perimetro(double a, double b, double c)
        {
            double perimetro = a + b + c;
            return perimetro;
        }

        // Método para calcular el área de un triángulo 
        public static double Area(double b, double d)
        {
            double area = (b * d) / 2;
            return area;
        }
    }
}
