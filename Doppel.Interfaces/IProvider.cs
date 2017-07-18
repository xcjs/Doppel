using System;

namespace Doppel.Interfaces
{
    public interface IProvider
    {
        string Protocol { get; }
        Uri Path { get; set; }

        bool CopyFile();

        bool MoveFile();

        bool DeleteFile();
    }
}
