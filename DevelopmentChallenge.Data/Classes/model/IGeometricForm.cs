using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    interface IGeometricForm
    {
        int Type { get; }
        decimal CalculateArea { get;  }
        decimal CalculatePerimeter { get; }
    }
}
