using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleControl.Infrastructure
{
    public interface IRemoteControl : IDisposable
    {
        void Forward();
        void Backward();
        void Left();
        void Right();
        void Stop();
    }
}
