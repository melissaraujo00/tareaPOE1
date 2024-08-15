using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Trapecio
    {
        public decimal BaseMenor { get; set; }
        public decimal BaseMayor { get; set; }
        public decimal LadosParalelos { get; set; }   
        public decimal Altura { get; set; }

        public Trapecio(
            decimal baseMenor,
            decimal baseMayor,
            decimal ladosParalelos,
            decimal altura
            )
        {
            BaseMenor = baseMenor;
            BaseMayor = baseMayor;
            LadosParalelos = ladosParalelos;
            Altura = altura;
        }

        public decimal CalcularPerimetro()
        { 
            decimal perímetro = BaseMenor + BaseMayor + (LadosParalelos * 2);
            return perímetro;
        }

        public decimal CalcularArea()
        {
            decimal area = ((BaseMayor + BaseMenor) * Altura) / 2;
            return area;
        }

    }

    public class Pentagono
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

        public decimal CalcularPerimetro()
        {
            decimal perimetro = LongitudLado * 5;
            return perimetro;
        }

        public decimal CalcularArea()
        {
            decimal perimetro = CalcularPerimetro();
            return (perimetro * Apotema) / 2;
        }

    }
}
