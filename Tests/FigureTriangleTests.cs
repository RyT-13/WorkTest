using System;
using Library.Figures;
using NUnit.Framework;

namespace Tests
{
    public class TriangleFigureTests
    {
        [Test]
        public void Initialization_PositiveSides_NotException()
        {
            float a = 3;
            float b = 4;
            float c = 5;
            TestDelegate init = new TestDelegate( () => new FigureTriangle(a, b, c));

            Assert.DoesNotThrow(init);
        }

        [Test]
        public void Initialization_NegativeSides_Exception()
        {
            float a = -3;
            float b = -4;
            float c = -5;
            TestDelegate init = new TestDelegate( () => new FigureTriangle(a, b, c));
            
            Assert.Catch<IsNotFigureException>(init);
        }
        
        [Test]
        public void Initialization_ShortSides_Exception()
        {
            float a = 1;
            float b = 1;
            float c = 5;
            TestDelegate init = new TestDelegate( () => new FigureTriangle(a, b, c));
            
            Assert.Catch<IsNotFigureException>(init);
        }

        [Test]
        public void Sides_NegativeNumbers_Exception()
        {
            float a = 3;
            float b = 4;
            float c = 5;
            FigureTriangle triangle = new FigureTriangle(a, b, c);

            Assert.Catch<IsNotFigureException>(() => triangle.Redefine(-3, -4,-5));
        }
        
        [Test]
        public void Sides_ShortSides_Exception()
        {
            float a = 3;
            float b = 4;
            float c = 5;
            FigureTriangle triangle = new FigureTriangle(a, b, c);

            Assert.Catch<IsNotFigureException>(() => triangle.Redefine(1, 1,5));
        }
        
        [Test]
        public void Perimeter()
        {
            float a = 3;
            float b = 4;
            float c = 5;
            FigureTriangle triangle = new FigureTriangle(a, b, c);
            float P = a + b + c;

            Assert.AreEqual(P, triangle.Perimeter);
        }

        [Test]
        public void Square()
        {
            float a = 3;
            float b = 4;
            float c = 5;
            FigureTriangle triangle = new FigureTriangle(a, b, c);
            float p = (a + b + c)/2;
            float S = MathF.Sqrt(p * (p - a) * (p - b) * (p - c));

            Assert.AreEqual(S, triangle.Square);
        }

        [Test]
        public void Measure()
        {
            float a = 3;
            float b = 4;
            float c = 5;
            FigureTriangle triangle = new FigureTriangle(a, b, c);
            float P = a + b + c;
            float p = P/2;
            float S = MathF.Sqrt(p * (p - a) * (p - b) * (p - c));

            float measure = triangle.Measure();

            Assert.AreEqual(S+P, measure);
        }
    }
}