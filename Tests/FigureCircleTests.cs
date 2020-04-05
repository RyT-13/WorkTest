using System;
using Library.Figures;
using NUnit.Framework;

namespace Tests
{
    public class CircleFigureTests
    {
        [Test]
        public void Initialization_PositiveRadius_NotException()
        {
            float radius = 3;
            TestDelegate init = new TestDelegate( () => new FigureCircle(radius));

            Assert.DoesNotThrow(init);
        }

        [Test]
        public void Initialization_NegativeRadius_Exception()
        {
            float radius = -3;
            TestDelegate init = new TestDelegate( () => new FigureCircle(radius));
            
            Assert.Catch<IsNotFigureException>(init);
        }

        [Test]
        public void Radius_NegativeNumber_Exception()
        {
            float radius = 5;
            FigureCircle circle = new FigureCircle(radius);

            Assert.Catch<IsNotFigureException>(() => circle.Radius = -5);
        }
        
        [Test]
        public void Perimeter_Radius5()
        {
            float radius = 5;
            FigureCircle circle = new FigureCircle(radius);

            float P = MathF.PI * 2 * radius;

            Assert.AreEqual(P, circle.Perimeter);
        }

        [Test]
        public void Square_Radius5()
        {
            float radius = 5;
            FigureCircle circle = new FigureCircle(radius);

            float S = MathF.PI * MathF.Pow(radius, 2);

            Assert.AreEqual(S, circle.Square);
        }

        [Test]
        public void Measure_Radius10()
        {
            float radius = 10;
            FigureCircle circle = new FigureCircle(radius);
            float S = MathF.PI * MathF.Pow(radius, 2);
            float P = MathF.PI * 2 * radius;

            float measure = circle.Measure();

            Assert.AreEqual(S+P, measure);
        }
    }
}