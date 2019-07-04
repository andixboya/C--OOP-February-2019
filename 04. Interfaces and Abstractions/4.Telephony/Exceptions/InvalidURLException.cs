namespace Telephony.Exceptions
{
    using System;

    public class InvalidURLException : FormatException
    {
        public InvalidURLException(string message="Invalid URL!") : base(message)
        {
            
        }
    }
}
