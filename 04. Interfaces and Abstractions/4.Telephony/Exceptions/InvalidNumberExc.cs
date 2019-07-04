namespace Telephony.Exceptions
{
    using System;

    public class InvalidNumberExc : FormatException
    {
        public InvalidNumberExc(string message="Invalid number!") : base(message)
        {

        }
    }
}
