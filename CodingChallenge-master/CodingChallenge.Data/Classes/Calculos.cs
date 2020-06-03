using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    internal class Calculos : FormaGeometrica
    {
        public Calculos(int tipo, decimal ancho, decimal bmayor, decimal bmenor, decimal altura, decimal brecta) : base(tipo, ancho, bmayor, bmenor, altura, brecta)
        {
        }

        public static string ObtenerLinea(int cantidad, decimal area, decimal perimetro, int tipo, int idioma)
        {
            if (cantidad > 0)
            {
                if (idioma == Castellano)
                    return $"{cantidad} {TraducirForma(tipo, cantidad, idioma)} | Area {area:#.##} | Perimetro {perimetro:#.##} <br/>";
                if (idioma == Ingles)
                    return $"{cantidad} {TraducirForma(tipo, cantidad, idioma)} | Area {area:#.##} | Perimeter {perimetro:#.##} <br/>";
                if (idioma == Portugues)
                    return $"{cantidad} {TraducirForma(tipo, cantidad, idioma)} | Area {area:#.##} | Perimetro {perimetro:#.##} <br/>";
            }

            return string.Empty;

        }

        public static string TraducirForma(int tipo, int cantidad, int idioma)
        {
            switch (tipo)
            {
                case Cuadrado:
                    if (idioma == Castellano)
                        return cantidad == 1 ? "Cuadrado" : "Cuadrados";
                    if (idioma == Ingles)
                        return cantidad == 1 ? "Square" : "Squares";
                    else
                        return cantidad == 1 ? "Quadrado" : "Quadrados";
                case Circulo:
                    if (idioma == Castellano)
                        return cantidad == 1 ? "Círculo" : "Círculos";
                    if (idioma == Ingles)
                        return cantidad == 1 ? "Circle" : "Circles";
                    else 
                        return cantidad == 1 ? "Circulo" : "Circulos";
                case TrianguloEquilatero:
                    if (idioma == Castellano)
                        return cantidad == 1 ? "Triángulo" : "Triángulos";
                    if (idioma == Ingles)
                        return cantidad == 1 ? "Triangle" : "Triangles";
                    else
                        return cantidad == 1 ? "Triângulo" : "Triângulos";
                case Trapecio:
                    if (idioma == Castellano)
                        return cantidad == 1 ? "Trapecio" : "Trapecios";
                    if (idioma == Ingles)
                        return cantidad == 1 ? "Trapeze" : "Trapezoids";
                    else 
                        return cantidad == 1 ? "Trapézio" : "Trapézios";
                case Rectangulo:
                    if (idioma == Castellano)
                        return cantidad == 1 ? "Rectangulo" : "Rectangulos";
                    if (idioma == Ingles)
                        return cantidad == 1 ? "Rectangle" : "Rectangles";
                    else 
                        return cantidad == 1 ? "Retângulo" : "Retângulos";
            }
            return string.Empty;

        }

        public static decimal CalcularArea(FormaGeometrica Tipo, decimal _lado,decimal _bamayor,decimal _bamenor, decimal _alturas, decimal _brectan)
        {

            switch (Tipo.Tipo)
            {
                case Cuadrado:
                    return _lado * _lado;
                case Circulo:
                    return (decimal)Math.PI * (_lado / 2) * (_lado / 2);
                case TrianguloEquilatero:
                    return ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
                case Trapecio:
                    return ((_bamayor + _bamenor) * _alturas) / 2;
                case Rectangulo:
                    return _brectan * _alturas;
                default:
                    throw new ArgumentOutOfRangeException(@"Forma desconocida");
            }
        }

        public static decimal CalcularPerimetro(FormaGeometrica Tipo, decimal _lado,decimal _bamayor,decimal _bamenor, decimal _alturas, decimal _brectan)
        {

            switch (Tipo.Tipo)
            {
                case Cuadrado:
                    return _lado * 4;
                case Circulo:
                    return (decimal)Math.PI * _lado;
                case TrianguloEquilatero:
                    return _lado * 3;
                case Trapecio:
                    return _lado + _lado + _bamayor + _bamenor;
                case Rectangulo:
                    return 2 * (_alturas + _brectan);
                default:
                    throw new ArgumentOutOfRangeException(@"Forma desconocida");
            }
        }
    }
}
