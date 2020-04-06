namespace FiguresLib.Groups
{
    /// <summary>
    /// Класс группы, который поэлементно применяет оператор умножения для вычисления меры группы.
    /// </summary>
    public class GroupMyltiply : Group
    {
        public override float Measure()
        {
            if (items.Count == 0)
            {
                return 0;
            }
            
            float measure = 1;
            
            foreach (IMeasure item in items)
            {
                measure *= item.Measure();
            }

            return measure;
        }
    }
}