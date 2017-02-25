using System;
using Doppel.Interfaces;

namespace Doppel.Providers.FileSystem
{
    public class File : IFile
    {
        public string Path { get; set; }
        public Int64 Size { get; set; }
    }
}