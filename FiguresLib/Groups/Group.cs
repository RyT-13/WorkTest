using System.Collections.Generic;

namespace FiguresLib.Groups
{
    /// <summary>
    /// Родительский класс для групп.
    /// </summary>
    public abstract class Group : IMeasure
    {
        protected List<IMeasure> items = new List<IMeasure>();

        public abstract float Measure();

        /// <summary>
        /// Добавляет элемент в группу.
        /// </summary>
        /// <param name="item">Элемент, имплементирующий интерфейс IMeasure.</param>
        public void Add(IMeasure item)
        {
            items.Add(item);
        }

        /// <summary>
        /// Удаляет элемент из группы.
        /// </summary>
        /// <param name="item">Элемент, имплементирующий интерфейс IMeasure.</param>
        /// <returns>True, если элемент был успешно удален. Иначе False.</returns>
        public bool Remove(IMeasure item)
        {
            return items.Remove(item);
        }
    }
}