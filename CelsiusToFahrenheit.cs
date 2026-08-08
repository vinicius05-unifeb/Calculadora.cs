using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcPOO
{
    internal class CelsiusToFahrenheit
    {
        public double CelsiusValue { get; private set; }

        public double ConvertToFahrenheit(double valor)
        {
            if (valor < -273.15)
                throw new ArgumentOutOfRangeException(nameof(valor), "O valor de Celsius não pode ser menor que o zero absoluto.");

            CelsiusValue = valor;
            return (CelsiusValue * 9.0 / 5.0) + 32;
        }
    }
}
