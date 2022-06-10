using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelBook.Interfaces;

namespace TelBook.Services
{
    internal class BeginService : Interfaces.IBegin
    {
        public void Begin(IRun run)
        {
            run.Run();
        }
    }
}
