namespace PmsAppExceptions
{
    public class ServiceException : ApplicationException
    {
        private readonly string? _message;
        private readonly Exception? _inner;

        public ServiceException()
        {
           // _message = "some error occurred in service";
        }
        public ServiceException(string? message)
        {
            _message = message;
        }
        public ServiceException(string? message, Exception inner)
        {
            _message = message;
            _inner = inner;
        }

        public override string Message => _message ?? "some error occurred";

        public new Exception? InnerException => _inner ?? null;
    }
}
