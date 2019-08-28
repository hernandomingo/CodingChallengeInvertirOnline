using System;
using System.Collections.Generic;
using CodingChallenge.Data.Classes;
using NUnit.Framework;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class ItalianoTests
    {
        [TestCase]
        public void TestResumenListaVaciaFormasEnItaliano()
        {
            Assert.AreEqual("<h1>Elenco vuoto di forme!</h1>",
                Impresora.Imprimir(new List<FormaGeometrica>(), 3));
        }

        [TestCase]
        public void TestResumenListaConUnCuadradoEnItaliano()
        {
            var cuadrados = new List<FormaGeometrica> { new Cuadrado(5) };

            var resumen = Impresora.Imprimir(cuadrados, Impresora.Italiano);

            Assert.AreEqual("<h1>Rapporto di Forme</h1>1 Quadrato | Area 25 | Perimetro 20 <br/>TOTALE:<br/>1 forme Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadradosEnItaliano()
        {
            var cuadrados = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var resumen = Impresora.Imprimir(cuadrados, Impresora.Italiano);

            Assert.AreEqual("<h1>Rapporto di Forme</h1>3 Quadrati | Area 35 | Perimetro 36 <br/>TOTALE:<br/>3 forme Perimetro 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnRectanguloEnItaliano()
        {
            var rectangulo = new List<FormaGeometrica> { new Rectangulo(4, 3) };

            var resumen = Impresora.Imprimir(rectangulo, Impresora.Italiano);

            Assert.AreEqual("<h1>Rapporto di Forme</h1>1 Rettangolo | Area 12 | Perimetro 14 <br/>TOTALE:<br/>1 forme Perimetro 14 Area 12", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasRectangulosEnItaliano()
        {
            var rectangulos = new List<FormaGeometrica>
            {
                new Rectangulo(5, 3),
                new Rectangulo(1, 3),
                new Rectangulo(3, 4)
            };

            var resumen = Impresora.Imprimir(rectangulos, Impresora.Italiano);

            Assert.AreEqual("<h1>Rapporto di Forme</h1>3 Rettangoli | Area 30 | Perimetro 38 <br/>TOTALE:<br/>3 forme Perimetro 38 Area 30", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnTrapecioEnItaliano()
        {
            var rectangulo = new List<FormaGeometrica> { new Trapecio(4, 3, 2, 2, 3) };

            var resumen = Impresora.Imprimir(rectangulo, Impresora.Italiano);

            Assert.AreEqual("<h1>Rapporto di Forme</h1>1 Trapeze | Area 10,5 | Perimetro 11 <br/>TOTALE:<br/>1 forme Perimetro 11 Area 10,5", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTrapeciosEnItaliano()
        {
            var rectangulos = new List<FormaGeometrica>
            {
                new Trapecio(4, 3, 2, 2, 3),
                new Trapecio(5, 4, 2, 2, 3),
                new Trapecio(7, 6, 2, 2, 5)
            };

            var resumen = Impresora.Imprimir(rectangulos, Impresora.Italiano);

            Assert.AreEqual("<h1>Rapporto di Forme</h1>3 Trapezi | Area 56,5 | Perimetro 41 <br/>TOTALE:<br/>3 forme Perimetro 41 Area 56,5", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnCirculoEnItaliano()
        {
            var cuadrados = new List<FormaGeometrica> { new Circulo(5) };

            var resumen = Impresora.Imprimir(cuadrados, Impresora.Italiano);

            Assert.AreEqual("<h1>Rapporto di Forme</h1>1 Cerchio | Area 19,63 | Perimetro 15,71 <br/>TOTALE:<br/>1 forme Perimetro 15,71 Area 19,63", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCirculosEnItaliano()
        {
            var cuadrados = new List<FormaGeometrica>
            {
                new Circulo(5),
                new Circulo(1),
                new Circulo(3)
            };

            var resumen = Impresora.Imprimir(cuadrados, Impresora.Italiano);

            Assert.AreEqual("<h1>Rapporto di Forme</h1>3 Cerchi | Area 27,49 | Perimetro 28,27 <br/>TOTALE:<br/>3 forme Perimetro 28,27 Area 27,49", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnTriangulo()
        {
            var cuadrados = new List<FormaGeometrica> { new TrianguloEquilatero(5) };

            var resumen = Impresora.Imprimir(cuadrados, Impresora.Italiano);

            Assert.AreEqual("<h1>Rapporto di Forme</h1>1 Triangolo | Area 10,83 | Perimetro 15 <br/>TOTALE:<br/>1 forme Perimetro 15 Area 10,83", resumen);
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

            var resumen = Impresora.Imprimir(cuadrados, Impresora.Italiano);

            Assert.AreEqual("<h1>Rapporto di Forme</h1>3 Triangoli | Area 15,16 | Perimetro 27 <br/>TOTALE:<br/>3 forme Perimetro 27 Area 15,16", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnItaliano()
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

            var resumen = Impresora.Imprimir(formas, Impresora.Italiano);

            Assert.AreEqual(
                "<h1>Rapporto di Forme</h1>2 Quadrati | Area 29 | Perimetro 28 <br/>2 Cerchi | Area 13,01 | Perimetro 18,06 <br/>3 Triangoli | Area 49,64 | Perimetro 51,6 <br/>TOTALE:<br/>7 forme Perimetro 97,66 Area 91,65",
                resumen);
        }
    }
}
