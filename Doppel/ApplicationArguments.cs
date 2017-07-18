using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Doppel
{
    internal class ApplicationArguments
    {
        public Uri Source { get; set; }
        public Uri Destination { get; set; }
    }
}