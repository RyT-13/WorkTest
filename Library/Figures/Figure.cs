namespace Library.Figures
{
    public abstract class Figure : IMeasure
    {
        public abstract float Measure();
        public abstract float Square { get; }
        public abstract float Perimeter { get; }



    }
}