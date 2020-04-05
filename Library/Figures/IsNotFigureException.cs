using System;

namespace Library.Figures
{
    public class IsNotFigureException : Exception
    {
        private string message;
        
        public IsNotFigureException(string message)
        {
            this.message = message;
        }

        public override string ToString()
        {
            return message;
        }
    }
}