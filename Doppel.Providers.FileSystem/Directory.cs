using System.Collections.Generic;
using Doppel.Interfaces;

namespace Doppel.Providers.FileSystem
{
    public class Directory : IDirectory
    {
        public string Path { get; set; }
        public HashSet<IDirectory> Directories { get; set; }
        public HashSet<IFile> Files { get; set; }
    }
}