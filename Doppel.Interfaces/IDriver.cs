namespace Doppel.Providers
{
    public interface IProvider
    {        
        string Path { get; set; }

        bool CopyFile();

        bool MoveFile();

        bool DeleteFile();
    }
}
