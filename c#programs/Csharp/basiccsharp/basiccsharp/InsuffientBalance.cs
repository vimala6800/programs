using System.Runtime.Serialization;

namespace basiccsharp
{
    [Serializable]
    internal class InsuffientBalance : Exception
    {
        public InsuffientBalance()
        {
        }

        public InsuffientBalance(string? message) : base(message)
        {
        }

        public InsuffientBalance(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected InsuffientBalance(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}