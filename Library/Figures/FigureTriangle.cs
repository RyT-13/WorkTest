using System;

namespace Library.Figures
{
    public class FigureTriangle : Figure
    {
        private float a;
        private float b;
        private float c;

        public FigureTriangle(float a, float b, float c)
        {
            Redefine(a, b, c);
        }

        public void Redefine(float a, float b, float c)
        {
            if (a < 0 || b < 0 || c < 0)
            {
                this.a = this.b = this.c = 0;
            }
            else
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
        }

        public override float Perimetr() => a + b + c;

        public override float Square()
        {
            float p = Perimetr() / 2;
            return MathF.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public override float Measure()
        {
            return Square() + Perimetr();
        }
    }
}