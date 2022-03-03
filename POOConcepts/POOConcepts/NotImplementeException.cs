using System.Runtime.Serialization;

namespace ConceptsPOO
{
    [Serializable]
    internal class NotImplementeException : Exception
    {
        public NotImplementeException()
        {
        }

        public NotImplementeException(string? message) : base(message)
        {
        }

        public NotImplementeException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NotImplementeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}