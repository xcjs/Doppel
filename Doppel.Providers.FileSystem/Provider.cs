using Doppel.Interfaces;
using System;

namespace Doppel.Providers.FileSystem
{
    public class Provider : IProvider
    {
        public string Protocol
        {
            get 
            {
                return "file";
            }
        }
        public Uri Path { get; set; }

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
