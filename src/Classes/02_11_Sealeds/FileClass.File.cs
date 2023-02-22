using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Sealeds
{
    file class FileClass
    {
        public void Method() => Console.WriteLine("file class FileClass");
    }

    internal class Aaa
    {
        public void Method() => new FileClass().Method();
    }
}
