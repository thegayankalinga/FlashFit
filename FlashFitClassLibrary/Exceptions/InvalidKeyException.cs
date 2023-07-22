namespace FlashFitClassLibrary.Exceptions
{
    [Serializable]
    public class InvalidKeyException : Exception
    {
        public InvalidKeyException() { }

        public InvalidKeyException(string? message) : base(message)
        {
        }
    }

}
