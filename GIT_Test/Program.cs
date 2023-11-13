using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIT_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args[0] =="-help")
            {
                Console.WriteLine("vezio követés");
            }
            else
            {
                Console.WriteLine("Hello Git");
            }
        }
    }
}
