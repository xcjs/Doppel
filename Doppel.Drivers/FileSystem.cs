using Doppel.Interfaces;

namespace Doppel.Drivers
{
    public class FileSystem : IDriver
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
