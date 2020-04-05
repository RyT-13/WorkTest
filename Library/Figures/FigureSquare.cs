using System;

namespace Library.Figures
{
    public class FigureSquare : Figure
    {
        private float lenOfSide;

        public float LenOfSide
        {
            get => lenOfSide;
            set
            {
                if (value < 0)
                {
                    throw new IsNotFigureException("Length of side < 0.");
                }

                lenOfSide = value;
            }
        }
        
        public override float Square => MathF.Pow(lenOfSide, 2);
        public override float Perimeter => lenOfSide * 4;


        public FigureSquare(float lenOfSide)
        {
            LenOfSide = lenOfSide;
        }
        
        public override float Measure()
        {
            return Square + Perimeter;
        }
    }
}