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

            OtherMethodInDev();

        }

        private static void OtherMethodInDev()
        {
            throw new NotImplementedException();
        }

        private static void GetCurrentDate()
        {
            // This is dev (Now), dev correction
            var curDate = DateTime.Now;

            // This is anew code from dev
        }
    }
}
