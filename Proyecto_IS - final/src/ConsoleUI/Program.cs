using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            double perimetro;
            double area;
            double volumen;

            Console.WriteLine("Calculadora de Perímetro, Área y Volumen de un Prisma Triangular");

            // Solicitar los lados del triángulo
            Console.Write("Dame el primer lado del triángulo: ");
            double lado1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Dame el segundo lado del triángulo: ");
            double lado2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Dame el tercer lado del triángulo: ");
            double lado3 = Convert.ToDouble(Console.ReadLine());

            // Solicitar la altura del triángulo
            Console.Write("Dame la altura del triángulo: ");
            double alturaTriangulo = Convert.ToDouble(Console.ReadLine());

            // Solicitar la altura del prisma
            Console.Write("Dame la altura del prisma: ");
            double alturaPrisma = Convert.ToDouble(Console.ReadLine());

            // Calcular el perímetro del triángulo
            perimetro = lado1 + lado2 + lado3;

            // Calcular el área del triángulo
            area = (lado1 * alturaTriangulo) / 2; 

            // Calcular el volumen del prisma triangular
            volumen = area * alturaPrisma;

            // Mostrar los resultados
            Console.WriteLine();
            Console.WriteLine($"Perímetro: {perimetro} cm");
            Console.WriteLine($"Área: {area} cm²");
            Console.WriteLine($"Volumen: {volumen} cm³");
        }
    }
}
