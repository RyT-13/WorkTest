using System;

namespace FiguresLib.Figures
{
    /// <summary>
    /// Класс квадрата с определенной стороной.
    /// </summary>
    public class FigureSquare : Figure
    {
        private float lenOfSide;

        /// <summary>
        /// Длина одной стороны.
        /// </summary>
        /// <exception cref="IsNotFigureException">Выбрасывает, когда задана отрицательная длина стороны.</exception>
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

        /// <summary>
        /// Инициализирует новый экземпляр класса с указанной длиной сторон.
        /// </summary>
        /// <param name="lenOfSide">Длина одной стороны. Не может быть отрицательной.</param>
        /// <exception cref="IsNotFigureException">Выбрасывает, когда задана отрицательная длина стороны.</exception>
        public FigureSquare(float lenOfSide)
        {
            LenOfSide = lenOfSide;
        }

        public override float Measure()
        {
            return Square;
        }
    }
}