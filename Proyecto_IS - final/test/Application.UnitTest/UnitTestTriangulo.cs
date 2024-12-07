using System;
using Xunit;
using Application;

namespace Application.UnitTest
{
    public class UnitTestTriangulo
    {
        // Pruebas para el Perímetro
        [Theory]
        [InlineData(3, 4, 5, 12)] // Perímetro = a + b + c
        [InlineData(6, 8, 10, 24)]
        [InlineData(5, 5, 5, 15)]
        [InlineData(7, 24, 25, 56)]
        [InlineData(10, 10, 15, 35)]
        public void TestPerimetro(double a, double b, double c, double perimetroEsperado)
        {
            // Act - Realizar
            double resultado = Triangulo.Perimetro(a, b, c);

            // Assert - Verificar
            Assert.Equal(perimetroEsperado, resultado, 5); // Tolerancia de 5 decimales
        }

        // Pruebas para el Área
        [Theory]
        [InlineData(6, 4, 12)] // Área = (base * altura) / 2
        [InlineData(10, 5, 25)]
        [InlineData(8, 3, 12)]
        [InlineData(15, 10, 75)]
        [InlineData(7, 6, 21)]
        public void TestArea(double baseTriangulo, double altura, double areaEsperada)
        {
            // Act - Realizar
            double resultado = Triangulo.Area(baseTriangulo, altura);

            // Assert - Verificar
            Assert.Equal(areaEsperada, resultado, 5); // Tolerancia de 5 decimales
        }
    }
}
