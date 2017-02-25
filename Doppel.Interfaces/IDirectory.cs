using System;
using System.Collections.Generic;

namespace Doppel.Interfaces
{
    public interface IDirectory
    {
        string Path { get; set; }
        HashSet<IDirectory> Directories { get; set; }
        HashSet<IFile> Files { get; set; }
    }
}