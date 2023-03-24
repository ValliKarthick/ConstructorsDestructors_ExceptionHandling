using System;

namespace ConstructorsDestructors_ExceptionHandling
{
    public class StatusAlert
    {
        int status = 0;
        int dangerZone = 0;
        public void ShowCurrentStatus()
        {
            if (status >= dangerZone)
            {
                throw (new StatusAlertException("DangerZone Alert..!!!"));
            }
            else
            {
                Console.WriteLine("Status: {0}", status);
            }
        }
    }
}
