using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcPOO
{
    internal class FahrenheittoCelsius
    {
        public double FahrenheitValue { get; private set; }

        public double ConvertToCelsius(double valor)
        {
            if (valor < 0)
                throw new ArgumentOutOfRangeException(nameof(valor), "O valor de Fahrenheit não pode ser menor que o zero absoluto.");

            FahrenheitValue = valor;
            return (5.0 / 9.0) * (FahrenheitValue - 32);
        }
    }
}
