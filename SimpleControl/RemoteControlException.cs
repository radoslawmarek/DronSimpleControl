using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleControl.Infrastructure
{
    public class RemoteControlException : Exception
    {
        public RemoteControlException()
        {

        }

        public RemoteControlException(string message) : base(message)
        {
           
        }

        public RemoteControlException(string message, Exception inner) : base (message,inner)
        {

        }
    }
}
