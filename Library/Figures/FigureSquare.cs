using System;

namespace Library.Figures
{
    public class FigureSquare : Figure
    {
        private float lenOfSide;

        public float LenOfSide
        {
            get => lenOfSide;
            set => lenOfSide = value < 0 ? 0 : value;
        }

        public FigureSquare(float lenOfSide)
        {
            LenOfSide = lenOfSide;
        }

        public override float Square() => MathF.Pow(lenOfSide, 2);
        public override float Perimetr() => lenOfSide * 4;

        public override float Measure()
        {
            return Square() + Perimetr();
        }
    }
}