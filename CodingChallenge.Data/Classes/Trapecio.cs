using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Trapecio : FormaGeometrica
    {
        private readonly decimal _baseA;
        private readonly decimal _baseB;
        private readonly decimal _ladoA;
        private readonly decimal _ladoB;
        private readonly decimal _altura;
        public Trapecio(decimal baseA, decimal baseB, decimal ladoA, decimal ladoB, decimal altura)
        {
            _baseA = baseA;
            _baseB = baseB;
            _ladoA = ladoA;
            _ladoB = ladoB;
            _altura = altura;
        }

        public override decimal CalcularArea()
        {
            return _altura * (_baseA + _baseB) / 2;
        }

        public override decimal CalcularPerimetro()
        {
            return _baseA + _baseB +_ladoA + _ladoB;
        }
    }
}
