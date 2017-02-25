using System;

namespace Doppel.Interfaces
{
    public interface IProvider
    {        
        string Path { get; set; }

        bool CopyFile();

        bool MoveFile();

        bool DeleteFile();
    }
}
