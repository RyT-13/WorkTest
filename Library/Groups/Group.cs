using System.Collections.Generic;

namespace Library.Groups
{
    public class Group : IMeasure    //делать абстрактным или не делать...?
    {
        protected List<IMeasure> items = new List<IMeasure>();

        public virtual float Measure()
        {
            float measure = 0;
            
            foreach (IMeasure item in items)
            {
                measure += item.Measure();
            }

            return measure;
        }
        
        public void Add(IMeasure item)
        {
            items.Add(item);
        }

        public bool Remove(IMeasure item)
        {
            return items.Remove(item);
        }

        public IMeasure Get(int index)
        {
            if (index >= items.Count && index < 0)
            {
                return null;
            }

            return items[index];
        }
    }
}