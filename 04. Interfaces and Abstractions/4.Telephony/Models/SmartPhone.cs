namespace Telephony.Models
{
    using System;
    
    using Telephony.Contracts;
    using Telephony.Exceptions;

    public class SmartPhone : IBrowsable, ICallable
    {
        public void CallNumber(string number)
        {
            if (!IsValidNumber(number))
            {
                throw new InvalidNumberExc();
            }

            Console.WriteLine($"Calling... {number}");
        }

       

        public void SurfSite(string site)
        {
            if (!IsValidSite(site))
            {
                throw new InvalidURLException();
            }

            Console.WriteLine($"Browsing: {site}!"); 
        }

        
        private bool IsValidSite(string site)
        {
            for (int i = 0; i < site.Length; i++)
            {
                char current = site[i];
                if (char.IsDigit(current))
                {
                    return false;
                }

            }

            return true;
        }

        private bool IsValidNumber(string number)
        {
            for (int i = 0; i < number.Length; i++)
            {
                char current = number[i];
                if (!char.IsNumber(current))
                {
                    return false;
                }

            }
            return true;
        }
        
    }
}
