using Application;

class Program
{
    static void Main(string[] args)
    {
        // Lados del triángulo base
        double ladoA = 5.0; // Primer lado del triángulo
        double ladoB = 6.0; // Base del triángulo
        double ladoC = 7.0; // Tercer lado del triángulo

        // Altura del triángulo correspondiente a la base 'ladoB'
        double alturaTriangulo = 4.0;

        // Altura del prisma
        double alturaPrisma = 10.0;

        // Cálculo del perímetro del triángulo
        double perimetro = Triangulo.Perimetro(ladoA, ladoB, ladoC);

        // Cálculo del área de la base triangular
        double area = Triangulo.Area(ladoB, alturaTriangulo);

        // Cálculo del volumen del prisma triangular
        double volumen = PrismaTriangular.Volumen(area, alturaPrisma);

        // Salida de los resultados
        Console.WriteLine($"El perímetro de la base de un Prisma Triangular con lados de {ladoA}cm, {ladoB}cm y {ladoC}cm es {perimetro}cm");
        Console.WriteLine($"El área de la base de un Prisma Triangular con base de {ladoB}cm y altura de {alturaTriangulo}cm es {area}cm²");
        Console.WriteLine($"El volumen de un Prisma Triangular con área de base de {area}cm² y altura de {alturaPrisma}cm es {volumen}cm³");
    }
}
