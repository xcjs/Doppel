using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Doppel
{
    internal static class ApplicationArguments
    {
        public static Uri Source { get; set; }
        public static Uri Destination { get; set; }
    }
}