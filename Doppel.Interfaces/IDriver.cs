namespace Doppel.Interfaces
{
    public interface IDriver
    {        
        string Path { get; set; }

        bool CopyFile();

        bool MoveFile();

        bool DeleteFile();
    }
}
