using Doppel.Providers;

namespace Doppel.Providers
{
    public class FileSystem : IProvider
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
