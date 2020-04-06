namespace FiguresLib.Figures
{
    /// <summary>
    /// Родительский класс для всех фигур.
    /// </summary>
    public abstract class Figure : IMeasure
    {
        public abstract float Measure();

        /// <summary>
        /// Площадь фигры.
        /// </summary>
        public abstract float Square { get; }

        /// <summary>
        /// Периметр фигуры.
        /// </summary>
        public abstract float Perimeter { get; }
    }
}