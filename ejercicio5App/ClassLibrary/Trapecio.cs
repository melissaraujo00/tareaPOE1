using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiguraInterfaz;

namespace TrapecioLibreria
{
    internal class Trapecio : Ifigura
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
        public decimal CalcularArea()
        {
            decimal area = ((BaseMayor + BaseMenor) * Altura) / 2;
            return area;
        }

        public decimal CalcularPerimetro()
        {
            decimal perímetro = BaseMenor + BaseMayor + (LadosParalelos * 2);
            return perímetro;
        }
    }
}
