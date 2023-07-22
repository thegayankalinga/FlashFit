namespace FlashFitClassLibrary.Exceptions
{
    [Serializable]
    public class ExistinUserFoundException : Exception
    {
        public ExistinUserFoundException() { }

        public ExistinUserFoundException(string? message) : base(message)
        {
        }
    }
}
