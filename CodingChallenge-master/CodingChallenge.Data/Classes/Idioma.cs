using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    class Idioma : FormaGeometrica
    {
        public Idioma(int tipo, decimal ancho, decimal bmayor, decimal bmenor, decimal altura, decimal brecta) : base(tipo, ancho, bmayor, bmenor, altura, brecta)
        {
        }

        public static string formas_Lista(int idioma)
        {
            string result = string.Empty;
            if (idioma == Castellano)
                result = "<h1>Lista vacía de formas!</h1>";
            if (idioma == Ingles)
                result = "<h1>Empty list of shapes!</h1>";
            if (idioma == Portugues)
                result = "<h1>Lista vazia de formas!</h1>";
            return result;
        }
        public static string formas_Reporte(int idioma)
        {
            string result = string.Empty;
            if (idioma == Castellano)
                result = "<h1>Reporte de Formas</h1>";
            if (idioma == Ingles)
                result = "<h1>Shapes report</h1>";
            if (idioma == Portugues)
                result = "<h1>Relatório de formas</h1>";
            return result;
        }
        public static string formas_Total(int idioma)
        {
            string result = string.Empty;
            if (idioma == Castellano)
                result = "Perimetro ";
            if (idioma == Ingles)
                result = "Perimeter ";
            if (idioma == Portugues)
                result = "Perimetro ";
            return result;
        }

        public static string formas_tipos(int idioma)
        {
            string result = string.Empty;
            if (idioma == Castellano)
                result = "formas";
            if (idioma == Ingles)
                result = "shapes";
            if (idioma == Portugues)
                result = "formas";
            return result;
        }
    }
}
