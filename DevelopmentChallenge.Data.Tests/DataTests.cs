using System;
using System.Collections.Generic;
using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Classes.enums;
using DevelopmentChallenge.Data.Classes.types;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumeListEmpty()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                GeometricForm.Print(new List<GeometricFormAbstract>(), Language.SPANISH));
        }

        [TestCase]
        public void TestResumeListEmptyFormsInEnglish()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                GeometricForm.Print(new List<GeometricFormAbstract>(), Language.ENGLISH));
        }

        [TestCase]
        public void TestResumeListWithOneSquad()
        {
            var squads = new List<GeometricFormAbstract> {new GeometricSquad(5)};

            var resumen = GeometricForm.Print(squads, Language.SPANISH);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 forma Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumeListWithMoreSquads()
        {
            var squads = new List<GeometricFormAbstract>
            {
                new GeometricSquad(5),
                new GeometricSquad(1),
                new GeometricSquad(3)
            };

            var resumen = GeometricForm.Print(squads, Language.ENGLISH);

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumeListWithMoreTypes()
        {
            var forms = new List<GeometricFormAbstract>
            {
                new GeometricSquad(5),
                new GeometricCircle(3),
                new GeometricEquilateralTriangle(4),
                new GeometricSquad(2),
                new GeometricEquilateralTriangle(9),
                new GeometricCircle(2.75m),
                new GeometricEquilateralTriangle(4.2m),
            };

            var resume = GeometricForm.Print(forms, Language.ENGLISH);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65",
                resume);
        }

        [TestCase]
        public void TestResumeListWithMoreTypeInSpanish()
        {
            var forms = new List<GeometricFormAbstract>
            {
                new GeometricSquad(5),
                new GeometricCircle(3),
                new GeometricEquilateralTriangle(4),
                new GeometricSquad(2),
                new GeometricEquilateralTriangle(9),
                new GeometricCircle(2.75m),
                new GeometricEquilateralTriangle(4.2m),
            };

            var resume = GeometricForm.Print(forms, Language.SPANISH);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65",
                resume);
        }



        [TestCase]
        public void TestResumeListWithOneRectangleInSpanish()
        {
            var forms = new List<GeometricFormAbstract>
            {
                new GeometricRectangle(5, 10),
            };

            var resume = GeometricForm.Print(forms, Language.SPANISH);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>1 Rectángulo | Area 50 | Perimetro 30 <br/>TOTAL:<br/>1 forma Perimetro 30 Area 50",
                resume);
        }


        [TestCase]
        public void TestResumeListWithOneTrapezeInEnglish()
        {
            var forms = new List<GeometricFormAbstract>
            {
                new GeometricTrapeze(5, 5, 10),
            };

            var resume = GeometricForm.Print(forms, Language.ENGLISH);

            Assert.AreEqual(
                "<h1>Shapes report</h1>1 Trapeze | Area 50 | Perimeter 100 <br/>TOTAL:<br/>1 shape Perimeter 100 Area 50",
                resume);
        }


        [TestCase]
        public void TestResumeListWithMoreTypesInItalian()
        {
            var forms = new List<GeometricFormAbstract>
            {
                new GeometricSquad(5),
                new GeometricCircle(3),
                new GeometricEquilateralTriangle(4),
                new GeometricSquad(2),
                new GeometricEquilateralTriangle(9),
                new GeometricCircle(2.75m),
                new GeometricEquilateralTriangle(4.2m),
                new GeometricRectangle(4m, 5m),
            };

            var resume = GeometricForm.Print(forms, Language.ITALIAN);

            Assert.AreEqual(
                "<h1>Rapporto moduli</h1>2 Quadrati | Zona 29 | Perimetro 28 <br/>2 Cerchi | Zona 13,01 | Perimetro 18,06 <br/>3 Triangoli | Zona 49,64 | Perimetro 51,6 <br/>1 Rettangolo | Zona 20 | Perimetro 18 <br/>TOTALE:<br/>8 forme Perimetro 115,66 Zona 111,65",
                resume);
        }



    }
}
