using System;
using FiguresLib.Figures;
using NUnit.Framework;

namespace FiguresLibTests
{
    public class FigureSquareTests
    {
        [Test]
        public void Initialization_PositiveLength_NotException()
        {
            float lenOfSide = 3;
            TestDelegate init = new TestDelegate( () => new FigureSquare(lenOfSide));

            Assert.DoesNotThrow(init);
        }

        [Test]
        public void Initialization_NegativeLength_Exception()
        {
            float lenOfSide = -3;
            TestDelegate init = new TestDelegate( () => new FigureSquare(lenOfSide));
            
            Assert.Catch<IsNotFigureException>(init);
        }

        [Test]
        public void LenOfSide_NegativeNumber_Exception()
        {
            float lenOfSide = 5;
            FigureSquare square = new FigureSquare(lenOfSide);

            Assert.Catch<IsNotFigureException>(() => square.LenOfSide = -5);
        }
        
        [Test]
        public void Perimeter_Length5()
        {
            float lenOfSide = 5;
            FigureSquare square = new FigureSquare(lenOfSide);

            float P = 4 * lenOfSide;

            Assert.AreEqual(P, square.Perimeter);
        }

        [Test]
        public void Square_Length5()
        {
            float lenOfSide = 5;
            FigureSquare square = new FigureSquare(lenOfSide);

            float S = MathF.Pow(lenOfSide, 2);

            Assert.AreEqual(S, square.Square);
        }

        [Test]
        public void Measure_Length10()
        {
            float lenOfSide = 10;
            FigureSquare square = new FigureSquare(lenOfSide);
            float S = MathF.Pow(lenOfSide, 2);

            float measure = square.Measure();

            Assert.AreEqual(S, measure);
        }
    }
}