using System;

namespace FiguresLib.Figures
{
    /// <summary>
    /// Класс окружности с определенным радиусом.
    /// </summary>
    public class FigureCircle : Figure
    {
        private float radius;

        /// <summary>
        /// Радиус окружности.
        /// </summary>
        /// <exception cref="IsNotFigureException">Выбрасывает, когда задан отрицательный радиус.</exception>
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

        /// <summary>
        /// Инициализирует новый экземпляр класса с указанным радиусом.
        /// </summary>
        /// <param name="radius">Радиус окружности. Не может быть отрицательным.</param>
        /// <exception cref="IsNotFigureException">Выбрасывает, когда задан отрицательный радиус.</exception>
        public FigureCircle(float radius)
        {
            Radius = radius;
        }

        public override float Measure()
        {
            return Square;
        }
    }
}