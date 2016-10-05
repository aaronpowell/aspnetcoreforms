using System;

namespace AspNetCoreForms
{
    public class ParseException : Exception
    {
        public ParseException()
            : base ("Parser Error: The Runat attribute must have the value Server.")
        {
        }
    }
}
