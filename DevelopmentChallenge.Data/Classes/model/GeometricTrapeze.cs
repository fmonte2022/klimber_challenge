using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Classes.types
{
    public class GeometricTrapeze : GeometricFormAbstract, IGeometricForm
    {
        public override int Type => 4;

        public GeometricTrapeze(decimal sideAWidth, decimal sideBWidth, decimal height) : base(new List<decimal> { sideAWidth, sideBWidth, height }) { }

        public override decimal CalculateArea => ((Sides[0] + Sides[1]) * Sides[2]) / 2;

        public override decimal CalculatePerimeter => (Sides[0] + Sides[1]) * Sides[2];
    }
}
