using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleGit
{
    class Program
    {
        static void Main(string[] args)
        {
            GetCurrentDate();

        }

        private static void GetCurrentDate()
        {
            var currentDate = DateTime.Now;
        }
    }
}
