namespace Library.Groups
{
    public class GroupMyltiply : Group
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