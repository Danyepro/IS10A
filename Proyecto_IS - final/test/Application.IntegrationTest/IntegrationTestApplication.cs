using Xunit;
using Application;

namespace Application.IntegrationTest
{
    public class IntegrationTestApplication
    {
        [Fact]
        public void TestCalculoAreaBase()
        {
            double baseTriangulo = 5.0;
            double alturaTriangulo = 6.0;
            double areaBase = Triangulo.Area(baseTriangulo, alturaTriangulo);
            Assert.Equal(15.0, areaBase, 2);
        }

        [Fact]
        public void TestCalculoVolumen()
        {
            double baseTriangulo = 5.0;
            double alturaTriangulo = 6.0;
            double alturaPrisma = 10.0;
            double areaBase = Triangulo.Area(baseTriangulo, alturaTriangulo);
            double volumen = PrismaTriangular.Volumen(areaBase, alturaPrisma);
            Assert.Equal(150.0, volumen, 2);
        }

        [Fact]
        public void TestPerimetroBaseYAreaBase()
        {
            double lado1 = 3.0;
            double lado2 = 4.0;
            double lado3 = 5.0;
            double baseTriangulo = 5.0;
            double alturaTriangulo = 6.0;

            double perimetro = Triangulo.Perimetro(lado1, lado2, lado3);
            double areaBase = Triangulo.Area(baseTriangulo, alturaTriangulo);

            Assert.True(perimetro > 0 && areaBase > 0);
        }

        [Fact]
        public void TestVolumenNoNegativo()
        {
            double areaBase = 15.0;
            double alturaPrisma = 10.0;
            double volumen = PrismaTriangular.Volumen(areaBase, alturaPrisma);
            Assert.True(volumen > 0);
        }

        [Fact]
        public void TestAreaBaseComparacion()
        {
            double basePequena = 3.0;
            double alturaPequena = 4.0;
            double baseGrande = 5.0;
            double alturaGrande = 6.0;

            double areaPequena = Triangulo.Area(basePequena, alturaPequena);
            double areaGrande = Triangulo.Area(baseGrande, alturaGrande);

            Assert.True(areaGrande > areaPequena);
        }
    }
}
