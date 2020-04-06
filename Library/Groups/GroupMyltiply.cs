namespace Library.Groups
{
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