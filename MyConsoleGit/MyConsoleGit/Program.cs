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
            // This is dev (Now), dev correction
            // Dev branch
            var cur = DateTime.Now;

           
        }
    }
}
