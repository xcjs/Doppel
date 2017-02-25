using Doppel.Interfaces;

namespace Doppel.Providers.FileSystem
{
    public class Provider : IProvider
    {
        public string Path { get; set; }

        public bool CopyFile() {
            return false;
        }

        public bool MoveFile() {
            return false;
        }

        public bool DeleteFile() {
            return false;
        }
    }
}
