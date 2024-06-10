namespace Kolos2.Exceptions;

public class DomainException : Exception
{
    public DomainException(){}

    public DomainException(string? messege) : base(messege)
    {
        
    }
    
}