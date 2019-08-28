using System;
using System.Collections.Generic;
using CodingChallenge.Data.Classes;
using NUnit.Framework;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class EspanolTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                Impresora.Imprimir(new List<FormaGeometrica>(), 1));
        }

        [TestCase]  
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrado = new List<FormaGeometrica> {new Cuadrado(5)};

            var resumen = Impresora.Imprimir(cuadrado, Impresora.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perímetro 20 <br/>TOTAL:<br/>1 formas Perímetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var resumen = Impresora.Imprimir(cuadrados, Impresora.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>3 Cuadrados | Area 35 | Perímetro 36 <br/>TOTAL:<br/>3 formas Perímetro 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnRectangulo()
        {
            var rectangulo = new List<FormaGeometrica> { new Rectangulo(4, 3) };

            var resumen = Impresora.Imprimir(rectangulo, Impresora.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Rectángulo | Area 12 | Perímetro 14 <br/>TOTAL:<br/>1 formas Perímetro 14 Area 12", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasRectangulos()
        {
            var rectangulos = new List<FormaGeometrica>
            {
                new Rectangulo(5, 3),
                new Rectangulo(1, 3),
                new Rectangulo(3, 4)
            };

            var resumen = Impresora.Imprimir(rectangulos, Impresora.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>3 Rectángulos | Area 30 | Perímetro 38 <br/>TOTAL:<br/>3 formas Perímetro 38 Area 30", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnTrapecio()
        {
            var rectangulo = new List<FormaGeometrica> { new Trapecio(4, 3, 2, 2, 3) };

            var resumen = Impresora.Imprimir(rectangulo, Impresora.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Trapecio | Area 10,5 | Perímetro 11 <br/>TOTAL:<br/>1 formas Perímetro 11 Area 10,5", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTrapecios()
        {
            var rectangulos = new List<FormaGeometrica>
            {
                new Trapecio(4, 3, 2, 2, 3),
                new Trapecio(5, 4, 2, 2, 3),
                new Trapecio(7, 6, 2, 2, 5)
            };

            var resumen = Impresora.Imprimir(rectangulos, Impresora.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>3 Trapecios | Area 56,5 | Perímetro 41 <br/>TOTAL:<br/>3 formas Perímetro 41 Area 56,5", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnCirculo()
        {
            var circulo = new List<FormaGeometrica> { new Circulo(5) };

            var resumen = Impresora.Imprimir(circulo, Impresora.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Círculo | Area 19,63 | Perímetro 15,71 <br/>TOTAL:<br/>1 formas Perímetro 15,71 Area 19,63", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCirculos()
        {
            var circulos = new List<FormaGeometrica>
            {
                new Circulo(5),
                new Circulo(1),
                new Circulo(3)
            };

            var resumen = Impresora.Imprimir(circulos, Impresora.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>3 Círculos | Area 27,49 | Perímetro 28,27 <br/>TOTAL:<br/>3 formas Perímetro 28,27 Area 27,49", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnTriangulo()
        {
            var triangulo = new List<FormaGeometrica> { new TrianguloEquilatero(5) };

            var resumen = Impresora.Imprimir(triangulo, Impresora.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Triángulo | Area 10,83 | Perímetro 15 <br/>TOTAL:<br/>1 formas Perímetro 15 Area 10,83", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTriangulos()
        {
            var triangulos = new List<FormaGeometrica>
            {
                new TrianguloEquilatero(5),
                new TrianguloEquilatero(1),
                new TrianguloEquilatero(3)
            };

            var resumen = Impresora.Imprimir(triangulos, Impresora.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>3 Triángulos | Area 15,16 | Perímetro 27 <br/>TOTAL:<br/>3 formas Perímetro 27 Area 15,16", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
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

            var resumen = Impresora.Imprimir(formas, Impresora.Castellano);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perímetro 28 <br/>2 Círculos | Area 13,01 | Perímetro 18,06 <br/>3 Triángulos | Area 49,64 | Perímetro 51,6 <br/>TOTAL:<br/>7 formas Perímetro 97,66 Area 91,65",
                resumen);
        }
    }
}
