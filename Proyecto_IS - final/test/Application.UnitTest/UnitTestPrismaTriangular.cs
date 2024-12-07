using System;
using Xunit;
using Application;

namespace Application.UnitTest
{
    public class UnitTestPrismaTriangular
    {
        // Pruebas para el Volumen
        [Theory]
        [InlineData(6, 10, 60)]   // Volumen = Área * Altura del prisma
        [InlineData(12, 5, 60)]
        [InlineData(7.5, 8, 60)]
        [InlineData(20, 15, 300)]
        [InlineData(25, 12, 300)]
        public void TestVolumen(double areaBase, double alturaPrisma, double volumenEsperado)
        {
            // Act - Realizar
            double resultado = PrismaTriangular.Volumen(areaBase, alturaPrisma);

            // Assert - Verificar
            Assert.Equal(volumenEsperado, resultado, 5); // Tolerancia de 5 decimales
        }
    }
}
