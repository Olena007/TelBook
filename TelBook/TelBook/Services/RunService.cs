using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelBook.Services
{
    internal class RunService : Interfaces.IRun
    {
        public void Run()
        {
            Models.Contact contact = new Models.Contact();

            var start = new StartService();
            start.Start();
        }
    }
}
