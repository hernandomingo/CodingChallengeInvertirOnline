using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Rectangulo : FormaGeometrica
    {
        private readonly decimal _ladoA;
        private readonly decimal _ladoB;
        public Rectangulo(decimal ladoA, decimal ladoB)
        {
            _ladoA = ladoA;
            _ladoB = ladoB;
        }
        public override decimal CalcularArea()
        {
            return _ladoA * _ladoB;
        }

        public override decimal CalcularPerimetro()
        {
            return _ladoA * 2 + _ladoB * 2;
        }
    }
}
