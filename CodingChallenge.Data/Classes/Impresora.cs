using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using System.Reflection;
using System.Globalization;

namespace CodingChallenge.Data.Classes
{
    public class Impresora
    {
        #region Idiomas

        public const int Castellano = 1;
        public const int Ingles = 2;
        public const int Italiano = 3;

        #endregion

        private static ResourceManager resourceManager;
        private static CultureInfo culture;

        public static string Imprimir(List<FormaGeometrica> formas, int idioma)
        {
            SeleccionarIdioma(idioma);

            var sb = new StringBuilder();

            if (!formas.Any())
            {
                sb.Append(resourceManager.GetString("mensajeListaVacia", culture));
            }
            else
            {
                ArmarReporte(formas, sb);
            }

            return sb.ToString();
        }

        private static void SeleccionarIdioma(int idioma)
        {
            switch (idioma)
            {
                case Castellano:
                    culture = CultureInfo.CreateSpecificCulture("es");
                    break;
                case Italiano:
                    culture = CultureInfo.CreateSpecificCulture("it");
                    break;
                default:
                    culture = CultureInfo.CreateSpecificCulture("en");
                    break;
            }
            resourceManager = new ResourceManager("CodingChallenge.Data.Resources.Resources", Assembly.GetExecutingAssembly());
        }

        private static int CantidadDelTipo<T>(List<FormaGeometrica> formas)
        {
            return formas.OfType<T>().Count();
        }

        private static decimal AreasDelTipo<T>(List<FormaGeometrica> formas) where T : FormaGeometrica
        {
            return formas.OfType<T>().Sum(i => i.CalcularArea());
        }

        private static decimal PerimetrosDelTipo<T>(List<FormaGeometrica> formas) where T : FormaGeometrica
        {
            return formas.OfType<T>().Sum(i => i.CalcularPerimetro());
        }

        private static void AgregarLinea<T>(List<FormaGeometrica> formas, StringBuilder sb) where T: FormaGeometrica
        {
            int cantidadTotal = CantidadDelTipo<T>(formas);
            decimal areaTotal = AreasDelTipo<T>(formas);
            decimal perimetroTotal = PerimetrosDelTipo<T>(formas);

            if (cantidadTotal > 0)
            {
                sb.Append($"{cantidadTotal} {TraducirForma(typeof(T).Name, cantidadTotal)} | {resourceManager.GetString("area", culture)} {areaTotal:#.##} | {resourceManager.GetString("perimetro", culture)} {perimetroTotal:#.##} <br/>");
            }
        }

        private static string TraducirForma(string tipo, int cantidad)
        {
            switch (tipo)
            {
                case "Cuadrado":
                    return cantidad == 1 ? resourceManager.GetString("cuadrado", culture) : resourceManager.GetString("cuadrados", culture);
                case "Rectangulo":
                    return cantidad == 1 ? resourceManager.GetString("rectangulo", culture) : resourceManager.GetString("rectangulos", culture);
                case "Trapecio":
                    return cantidad == 1 ? resourceManager.GetString("trapecio", culture) : resourceManager.GetString("trapecios", culture);
                case "Circulo":
                    return cantidad == 1 ? resourceManager.GetString("circulo", culture) : resourceManager.GetString("circulos", culture);
                case "TrianguloEquilatero":
                    return cantidad == 1 ? resourceManager.GetString("triangulo", culture) : resourceManager.GetString("triangulos", culture);
            }

            return string.Empty;
        }

        private static void ArmarReporte(List<FormaGeometrica> formas, StringBuilder sb)
        {
            sb.Append(resourceManager.GetString("mensajeHeader", culture));

            AgregarLinea<Cuadrado>(formas, sb);
            AgregarLinea<Rectangulo>(formas, sb);
            AgregarLinea<Trapecio>(formas, sb);
            AgregarLinea<Circulo>(formas, sb);
            AgregarLinea<TrianguloEquilatero>(formas, sb);

            // FOOTER
            sb.Append(resourceManager.GetString("mensajeFooter", culture));
            sb.Append(formas.Count() + " " + resourceManager.GetString("formas", culture) + " ");
            sb.Append(resourceManager.GetString("perimetro", culture) + " " + PerimetrosDelTipo<FormaGeometrica>(formas).ToString("#.##") + " ");
            sb.Append(resourceManager.GetString("area", culture) + " " + AreasDelTipo<FormaGeometrica>(formas).ToString("#.##"));
        }
    }
}
