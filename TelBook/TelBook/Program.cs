using System;

namespace TelBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var begin = new Services.BeginService();
            begin.Begin(new Services.RunService());
            
        }
    }
}
