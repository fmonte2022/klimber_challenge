using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public abstract class GeometricFormAbstract
    {
        private readonly List<decimal> _sides;
        
        public abstract int Type { get; }
        public abstract decimal CalculateArea { get; }
        public abstract decimal CalculatePerimeter { get; }
        public List<decimal> Sides => _sides;

        public GeometricFormAbstract(List<decimal> sides)
        {
            _sides = sides;
        }
    }
}
