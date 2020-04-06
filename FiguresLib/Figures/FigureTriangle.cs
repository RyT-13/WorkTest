using System;

namespace FiguresLib.Figures
{
    public class FigureTriangle : Figure
    {
        private float a;
        private float b;
        private float c;

        /// <summary>
        /// Одна из сторон.
        /// </summary>
        public float A => a;

        /// <summary>
        /// Одна из сторон.
        /// </summary>
        public float B => b;

        /// <summary>
        /// Одна из сторон.
        /// </summary>
        public float C => c;

        /// <summary>
        /// Инициализирует новый экземпляр класса с указанными длинами сторон.
        /// 
        /// </summary>
        /// <param name="a">Длина одной из сторон.</param>
        /// <param name="b">Длина одной из сторон.</param>
        /// <param name="c">Длина одной из сторон.</param>
        /// <exception cref="IsNotFigureException">Выбрасывает, когда фигуру невозможно построить по заданным длинам.</exception>
        public FigureTriangle(float a, float b, float c)
        {
            Redefine(a, b, c);
        }

        /// <summary>
        /// Позволяет переопределить длины сторон.
        /// </summary>
        /// <param name="a">Длина одной из сторон.</param>
        /// <param name="b">Длина одной из сторон.</param>
        /// <param name="c">Длина одной из сторон.</param>
        /// <exception cref="IsNotFigureException">Выбрасывает, когда фигуру невозможно построить по заданным длинам.</exception>
        public void Redefine(float a, float b, float c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new IsNotFigureException("Side or sides <= 0.");
            }

            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new IsNotFigureException("One of the side more than sum of two others.");
            }

            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override float Perimeter => a + b + c;

        public override float Square
        {
            get
            {
                float p = Perimeter / 2;
                return MathF.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
        }

        public override float Measure()
        {
            return Square;
        }
    }
}