using System;

namespace Library.Figures
{
    public class FigureCircle : Figure
    {
        private float radius;

        public float Radius
        {
            get => radius;
            set => radius = value < 0 ? 0 : value;
        }

        public FigureCircle(float radius)
        {
            Radius = radius;
        }
        
        
        public override float Measure()
        {
            return Square() + Perimetr();
        }

        public override float Square() => MathF.PI * MathF.Pow(radius, 2);
        public override float Perimetr() => MathF.PI * 2 * radius;
    }
}