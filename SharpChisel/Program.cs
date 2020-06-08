using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SharpChisel
{
    class Program
    {

        [DllImport("main.dll", EntryPoint = "mainDelegate")]
        extern static int mainDelegate(byte[] test);

        static void Main(string[] args)
        {
            string argsAsString = String.Join(" ", args);
            mainDelegate(Encoding.ASCII.GetBytes(argsAsString));
        }

    }
}
