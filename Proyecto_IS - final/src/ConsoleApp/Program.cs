double ladoA = 5; // Corresponde a 'a' (un lado del triángulo)
double ladoB = 3; // Corresponde a 'b' (la base del triángulo)
double ladoC = 4; // Corresponde a 'c' (otro lado del triángulo)
double alturaTriangulo = 4; // Altura del triángulo correspondiente a la base 'b'
double alturaPrisma = 10; // Altura del prisma triangular

// Cálculo del perímetro del triángulo
double perimetro = Application.Triangulo.Perimetro(ladoA, ladoB, ladoC);

// Cálculo del área de la base triangular
double area = Application.Triangulo.Area(ladoB, alturaTriangulo);

// Cálculo del área por altura
double areaPorAltura = area * alturaPrisma;

Console.WriteLine($"El perímetro de la base de un triángulo con lados de {ladoA}cm, {ladoB}cm y {ladoC}cm es {perimetro}cm");
Console.WriteLine($"El área de la base de un triángulo con base de {ladoB}cm y altura de {alturaTriangulo}cm es {area}cm2");
Console.WriteLine($"El resultado de multiplicar el área de la base por la altura del prisma es {areaPorAltura}cm3");
