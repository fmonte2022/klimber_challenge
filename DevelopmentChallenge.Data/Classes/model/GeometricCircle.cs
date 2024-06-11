using System;
using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Classes.types
{
    public class GeometricCircle : GeometricFormAbstract, IGeometricForm
    {
        public override int Type => 3;

        public GeometricCircle(decimal diameterWith) : base(new List<decimal> { diameterWith }) {  }

        public override decimal CalculateArea => (decimal)Math.PI * (Sides[0] / 2) * (Sides[0] / 2);

        public override decimal CalculatePerimeter => (decimal)Math.PI * Sides[0];
    }
}
