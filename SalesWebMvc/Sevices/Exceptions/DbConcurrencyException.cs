namespace SalesWebMVC.Sevices.Exceptions
{
    public class DbConcurrencyException : ApplicationException
    {
        public DbConcurrencyException(string message) : base(message) { }
    }
}
