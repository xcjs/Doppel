using System;

namespace Doppel.Interfaces
{
    public interface IFile
    {
        string Path { get; set; }
        Int64 Size { get; set; }
    }
}