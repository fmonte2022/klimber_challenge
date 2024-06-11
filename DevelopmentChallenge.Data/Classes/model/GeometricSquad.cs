using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Classes.types
{
    public class GeometricSquad : GeometricFormAbstract, IGeometricForm
    {
        public override int Type => 1;

        public GeometricSquad(decimal sideWidth) : base(new List<decimal> { sideWidth }) {  }

        public override decimal CalculateArea => Sides[0] * Sides[0];

        public override decimal CalculatePerimeter => Sides[0] * 4;
    }
}
