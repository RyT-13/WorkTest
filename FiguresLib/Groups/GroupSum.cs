namespace FiguresLib.Groups
{
    /// <summary>
    /// Класс группы, который поэлементно применяет оператор сложения для вычисления меры группы.
    /// </summary>
    public class GroupSum : Group
    {
        public override float Measure()
        {
            float measure = 0;
            
            foreach (IMeasure item in items)
            {
                measure += item.Measure();
            }

            return measure;
        }
    }
}