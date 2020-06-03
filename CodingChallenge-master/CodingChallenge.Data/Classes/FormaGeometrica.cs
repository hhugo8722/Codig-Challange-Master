/*
 * Refactorear la clase para respetar principios de programación orientada a objetos. 
 * 
 * Qué pasa si debemos soportar un nuevo idioma para los reportes, o
 * 
 * agregar más formas geométricas?
 *
 * Se puede hacer cualquier cambio que se crea necesario tanto en el código como en los tests. La única condición es que los tests pasen OK.
 *
 * TODO: Implementar Trapecio/Rectangulo, agregar otro idioma a reporting.
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CodingChallenge.Data.Classes
{

    public class FormaGeometrica
    {
        #region Formas

        public const int Cuadrado = 1;
        public const int TrianguloEquilatero = 2;
        public const int Circulo = 3;
        public const int Trapecio = 4;
        public const int Rectangulo = 5;

        #endregion

        #region Idiomas

        public const int Castellano = 1;
        public const int Ingles = 2;
        public const int Portugues = 3;

        #endregion


        public readonly decimal _lado;
        public readonly decimal _bamayor;
        public readonly decimal _bamenor;
        public readonly decimal _alturas;
        public readonly decimal _brectan;

        public int Tipo { get; set; }

        public FormaGeometrica(int tipo, decimal ancho,decimal bmayor,decimal bmenor,decimal altura,decimal brecta)
        {
            Tipo = tipo;
            _lado = ancho;
            _bamayor = bmayor;
            _bamenor = bmenor;
            _alturas = altura;
            _brectan = brecta;

        }
        public static string Imprimir(List<FormaGeometrica> formas, int idioma)
        {
            var sb = new StringBuilder();

            if (!formas.Any())
            {
                //FORMAS VACIO
                sb.Append(Idioma.formas_Lista(idioma));
            }
            //AUNQUE SEA UNA FORMA
            else
            {
                sb.Append(Idioma.formas_Reporte(idioma));

                //CALCULO FORMAS
                var numeroCuadrados = 0;
                var areaCuadrados = 0m;
                var perimetroCuadrados = 0m;

                var numeroCirculos = 0;
                var areaCirculos = 0m;
                var perimetroCirculos = 0m;

                var numeroTriangulos = 0;
                var areaTriangulos = 0m;
                var perimetroTriangulos = 0m;

                var numeroTrapecio = 0;
                var areaTrapecio = 0m;
                var perimetroTrapecio = 0m;

                var numeroRectangulo = 0;
                var areaRectangulo = 0m;
                var perimetroRectangulo = 0m;

                for (var i = 0; i < formas.Count; i++)
                {

                    if (formas[i].Tipo == Cuadrado)
                    {
                        numeroCuadrados++;
                        areaCuadrados += Calculos.CalcularArea(formas[i], formas[i]._lado, formas[i]._bamayor, formas[i]._bamenor, formas[i]._alturas, formas[i]._brectan);
                        perimetroCuadrados += Calculos.CalcularPerimetro(formas[i], formas[i]._lado, formas[i]._bamayor, formas[i]._bamenor, formas[i]._alturas, formas[i]._brectan);
                    }
                    if (formas[i].Tipo == Circulo)
                    {
                        numeroCirculos++;
                        areaCirculos += Calculos.CalcularArea(formas[i], formas[i]._lado, formas[i]._bamayor, formas[i]._bamenor, formas[i]._alturas, formas[i]._brectan);
                        perimetroCirculos += Calculos.CalcularPerimetro(formas[i], formas[i]._lado, formas[i]._bamayor, formas[i]._bamenor, formas[i]._alturas, formas[i]._brectan);
                    }
                    if (formas[i].Tipo == TrianguloEquilatero)
                    {
                        numeroTriangulos++;
                        areaTriangulos += Calculos.CalcularArea(formas[i], formas[i]._lado, formas[i]._bamayor, formas[i]._bamenor, formas[i]._alturas, formas[i]._brectan);
                        perimetroTriangulos += Calculos.CalcularPerimetro(formas[i], formas[i]._lado, formas[i]._bamayor, formas[i]._bamenor, formas[i]._alturas, formas[i]._brectan);
                    }
                    if (formas[i].Tipo == Trapecio)
                    {
                        numeroTrapecio++;
                        areaTrapecio += Calculos.CalcularArea(formas[i], formas[i]._lado, formas[i]._bamayor, formas[i]._bamenor, formas[i]._alturas, formas[i]._brectan);
                        perimetroTrapecio += Calculos.CalcularPerimetro(formas[i], formas[i]._lado, formas[i]._bamayor, formas[i]._bamenor, formas[i]._alturas, formas[i]._brectan);
                    }
                    if (formas[i].Tipo == Rectangulo)
                    {
                        numeroRectangulo++;
                        areaRectangulo += Calculos.CalcularArea(formas[i], formas[i]._lado, formas[i]._bamayor, formas[i]._bamenor, formas[i]._alturas, formas[i]._brectan);
                        perimetroRectangulo += Calculos.CalcularPerimetro(formas[i], formas[i]._lado, formas[i]._bamayor, formas[i]._bamenor, formas[i]._alturas, formas[i]._brectan);
                    }
                }

                sb.Append(Calculos.ObtenerLinea(numeroCuadrados, areaCuadrados, perimetroCuadrados, Cuadrado, idioma));
                sb.Append(Calculos.ObtenerLinea(numeroCirculos, areaCirculos, perimetroCirculos, Circulo, idioma));
                sb.Append(Calculos.ObtenerLinea(numeroTriangulos, areaTriangulos, perimetroTriangulos, TrianguloEquilatero, idioma));
                sb.Append(Calculos.ObtenerLinea(numeroTrapecio, areaTrapecio, perimetroTrapecio, Trapecio, idioma));
                sb.Append(Calculos.ObtenerLinea(numeroRectangulo, areaRectangulo, perimetroRectangulo, Rectangulo, idioma));
                    //-----------------
                    // FOOTER
                    sb.Append("TOTAL:<br/>");
                sb.Append(numeroCuadrados + numeroCirculos + numeroTriangulos + numeroTrapecio+numeroRectangulo+ " " + Idioma.formas_tipos(idioma) + " ");
                sb.Append(Idioma.formas_Total(idioma)  + (perimetroCuadrados + perimetroTriangulos + perimetroCirculos + perimetroTrapecio + perimetroRectangulo).ToString("#.##") + " ");
                sb.Append("Area " + (areaCuadrados + areaCirculos + areaTriangulos +areaTrapecio+ areaRectangulo).ToString("#.##"));
            
            }

            return sb.ToString();
        }
    }

}