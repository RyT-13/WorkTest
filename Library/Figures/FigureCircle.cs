using System;

namespace Library.Figures
{
    public class FigureCircle : Figure
    {
        private float radius;
        public float Radius
        {
            get => radius;
            set
            {
                if (value < 0)
                {
                    throw new IsNotFigureException("Radius < 0.");
                }

                radius = value;
            }
        }
        
        public override float Square => MathF.PI * MathF.Pow(Radius, 2);
        public override float Perimeter => MathF.PI * 2 * Radius;

        public FigureCircle(float radius)
        {
            Radius = radius;
        }
        
        
        public override float Measure()
        {
            return Square + Perimeter;
        }


    }
}