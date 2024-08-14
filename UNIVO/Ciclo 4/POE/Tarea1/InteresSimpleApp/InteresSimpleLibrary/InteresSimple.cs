using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteresSimpleLibrary
{
    public class InteresSimple : IInteresSimple
    {
        public double Capital { get; set; }

        public double TasaInteres { get; set; }

        public double Tiempo { get; set; }


        public InteresSimple(
            double capital,
            double tasaInteres,
            double tiempo
            ) 
        {
            Capital = capital;
            TasaInteres = tasaInteres;
            Tiempo = tiempo;
        }

        public double CalcularInteresSimple()
        {
            return (Capital * TasaInteres * Tiempo) / 100;
        }

    }
}
