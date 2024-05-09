namespace PmsAppExceptions
{
    public static class ExceptionWrapper<T>
    {
        public static T? WrapException(string? message, Exception inner)
        {
            var ex = Activator.CreateInstance(typeof(T), message, inner);
            return (T?)ex;
        }
    }
}
