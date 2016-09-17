using System.IO;

namespace Doppel.Interfaces
{
    public interface IDriver
    {
        FileInfo FileInfo { get; }
        
        bool CopyFile();

        bool MoveFile();

        bool DeleteFile();
    }
}
