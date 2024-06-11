using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Classes.types
{
    public class GeometricRectangle : GeometricFormAbstract, IGeometricForm
    {
        public override int Type => 5;

        public GeometricRectangle(decimal length, decimal width) : base(new List<decimal> { length, width }) { }

        public override decimal CalculateArea => Sides[0] * Sides[1];

        public override decimal CalculatePerimeter => (2 * Sides[0]) + (2 * Sides[1]);
    }
}
