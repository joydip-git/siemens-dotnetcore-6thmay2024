namespace PmsAppExceptions
{
    public class RepositoryException : ApplicationException
    {
        public RepositoryException():base("some error occurred in repository method") { }

        public RepositoryException(string? message) : base(message) { }

        public RepositoryException(string? message, Exception innerException):base(message, innerException) { }
    }
}
