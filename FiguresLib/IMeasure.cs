namespace FiguresLib
{
    /// <summary>
    /// Имплементация для объектов, у которых должна быть определенная мера.
    /// </summary>
    public interface IMeasure
    {
        /// <summary>
        /// Мера, которая определенна для данного класса.
        /// </summary>
        /// <returns>Число, которое является мерой для данного класса.</returns>
        public float Measure();
    }
}