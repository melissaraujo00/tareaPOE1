using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiguraInterfaz;

namespace PentagonoLibreria
{
    public class Pentagono : Ifigura
    {
        public decimal LongitudLado { get; set; }
        public decimal Apotema { get; set; }

        public Pentagono(
            decimal longitudLado,
            decimal apotema
            )
        {
            LongitudLado = longitudLado;
            Apotema = apotema;
        }
        public decimal CalcularArea()
        {
            decimal perimetro = CalcularPerimetro();
            return (perimetro * Apotema) / 2;
        }

        public decimal CalcularPerimetro()
        {
            decimal perimetro = LongitudLado * 5;
            return perimetro;
        }
    }
}
