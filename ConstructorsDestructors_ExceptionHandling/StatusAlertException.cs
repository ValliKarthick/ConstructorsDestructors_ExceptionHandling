using System;

namespace ConstructorsDestructors_ExceptionHandling
{
    public class StatusAlertException : Exception
    {
        public StatusAlertException(string message) : base(message)
        {
        }
    }
}
