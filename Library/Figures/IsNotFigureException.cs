using System;

namespace Library.Figures
{
    /// <summary>
    /// Класс исключений для фигур.
    /// </summary>
    public class IsNotFigureException : Exception
    {
        private string message;
        
            /// <summary>
            /// Создает новое исключение с заданым сообщением.
            /// </summary>
            /// <param name="message">Сообщение исключения</param>
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