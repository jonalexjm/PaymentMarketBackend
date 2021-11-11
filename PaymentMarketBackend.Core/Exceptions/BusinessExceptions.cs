using System;

namespace PaymentMarketBackend.Core.Exceptions
{
    public class BusinessExceptions : Exception
    {
        public BusinessExceptions()
        {
            
        }

        public BusinessExceptions(string message) : base(message)
        {
            
        }
        
    }
}