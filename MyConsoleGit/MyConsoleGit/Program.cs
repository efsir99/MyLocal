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

            // Mydev branch
            OtherMethodInDev();

        }

        private static void OtherMethodInDev()
        {
            throw new NotImplementedException();
        }

        private static void GetCurrentDate()
        {
            // My changes stash
            var cur = DateTime.Today;
           
            // This is a new code from dev
        }
    }
}
