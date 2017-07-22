using System;
using System.Collections.Generic;

namespace Doppel.Api
{
    public interface IProvider
    {
        string Protocol { get; }
        Uri Source { get; set; }
        Uri Destination { get; set; }

        Queue<string> FileQueue { get; set; }

        bool CopyFile();

        bool DeleteFile();
    }
}
