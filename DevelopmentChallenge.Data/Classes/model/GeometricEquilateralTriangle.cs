using System;
using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Classes.types
{
    public class GeometricEquilateralTriangle : GeometricFormAbstract, IGeometricForm
    {
        public override int Type => 2;

        public GeometricEquilateralTriangle(decimal sideWidth) : base(new List<decimal> { sideWidth }) {  }

        public override decimal CalculateArea => ((decimal)Math.Sqrt(3) / 4) * Sides[0] * Sides[0];

        public override decimal CalculatePerimeter => Sides[0] * 3;
    }
}
