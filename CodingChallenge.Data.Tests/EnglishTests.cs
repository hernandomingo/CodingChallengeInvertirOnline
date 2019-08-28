using System;
using System.Collections.Generic;
using CodingChallenge.Data.Classes;
using NUnit.Framework;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class EnglishTests
    {
        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                Impresora.Imprimir(new List<FormaGeometrica>(), 2));
        }

        [TestCase]
        public void TestResumenListaConUnCuadradoEnIngles()
        {
            var cuadrados = new List<FormaGeometrica> { new Cuadrado(5) };

            var resumen = Impresora.Imprimir(cuadrados, Impresora.Ingles);

            Assert.AreEqual("<h1>Shapes report</h1>1 Square | Area 25 | Perimeter 20 <br/>TOTAL:<br/>1 shapes Perimeter 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadradosEnIngles()
        {
            var cuadrados = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var resumen = Impresora.Imprimir(cuadrados, Impresora.Ingles);

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnRectanguloEnIngles()
        {
            var rectangulo = new List<FormaGeometrica> { new Rectangulo(4, 3) };

            var resumen = Impresora.Imprimir(rectangulo, Impresora.Ingles);

            Assert.AreEqual("<h1>Shapes report</h1>1 Rectangle | Area 12 | Perimeter 14 <br/>TOTAL:<br/>1 shapes Perimeter 14 Area 12", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasRectangulosEnIngles()
        {
            var rectangulos = new List<FormaGeometrica>
            {
                new Rectangulo(5, 3),
                new Rectangulo(1, 3),
                new Rectangulo(3, 4)
            };

            var resumen = Impresora.Imprimir(rectangulos, Impresora.Ingles);

            Assert.AreEqual("<h1>Shapes report</h1>3 Rectangles | Area 30 | Perimeter 38 <br/>TOTAL:<br/>3 shapes Perimeter 38 Area 30", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnTrapecioEnIngles()
        {
            var rectangulo = new List<FormaGeometrica> { new Trapecio(4, 3, 2, 2, 3) };

            var resumen = Impresora.Imprimir(rectangulo, Impresora.Ingles);

            Assert.AreEqual("<h1>Shapes report</h1>1 Trapeze | Area 10,5 | Perimeter 11 <br/>TOTAL:<br/>1 shapes Perimeter 11 Area 10,5", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTrapeciosEnIngles()
        {
            var rectangulos = new List<FormaGeometrica>
            {
                new Trapecio(4, 3, 2, 2, 3),
                new Trapecio(5, 4, 2, 2, 3),
                new Trapecio(7, 6, 2, 2, 5)
            };

            var resumen = Impresora.Imprimir(rectangulos, Impresora.Ingles);

            Assert.AreEqual("<h1>Shapes report</h1>3 Trapezes | Area 56,5 | Perimeter 41 <br/>TOTAL:<br/>3 shapes Perimeter 41 Area 56,5", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnCirculoEnIngles()
        {
            var cuadrados = new List<FormaGeometrica> { new Circulo(5) };

            var resumen = Impresora.Imprimir(cuadrados, Impresora.Ingles);

            Assert.AreEqual("<h1>Shapes report</h1>1 Circle | Area 19,63 | Perimeter 15,71 <br/>TOTAL:<br/>1 shapes Perimeter 15,71 Area 19,63", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCirculosEnIngles()
        {
            var cuadrados = new List<FormaGeometrica>
            {
                new Circulo(5),
                new Circulo(1),
                new Circulo(3)
            };

            var resumen = Impresora.Imprimir(cuadrados, Impresora.Ingles);

            Assert.AreEqual("<h1>Shapes report</h1>3 Circles | Area 27,49 | Perimeter 28,27 <br/>TOTAL:<br/>3 shapes Perimeter 28,27 Area 27,49", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnTriangulo()
        {
            var cuadrados = new List<FormaGeometrica> { new TrianguloEquilatero(5) };

            var resumen = Impresora.Imprimir(cuadrados, Impresora.Ingles);

            Assert.AreEqual("<h1>Shapes report</h1>1 Triangle | Area 10,83 | Perimeter 15 <br/>TOTAL:<br/>1 shapes Perimeter 15 Area 10,83", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTriangulos()
        {
            var cuadrados = new List<FormaGeometrica>
            {
                new TrianguloEquilatero(5),
                new TrianguloEquilatero(1),
                new TrianguloEquilatero(3)
            };

            var resumen = Impresora.Imprimir(cuadrados, Impresora.Ingles);

            Assert.AreEqual("<h1>Shapes report</h1>3 Triangles | Area 15,16 | Perimeter 27 <br/>TOTAL:<br/>3 shapes Perimeter 27 Area 15,16", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnIngles()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = Impresora.Imprimir(formas, Impresora.Ingles);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65",
                resumen);
        }
    }
}
