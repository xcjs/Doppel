using Doppel.Api;
using System;
using System.Collections.Generic;

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
        public Uri Source { get; set; }
        public Uri Destination { get; set; }
        public Queue<string> FileQueue { get; set; }

        public bool CopyFile() {
            return false;
        }

        public bool DeleteFile() {
            return false;
        }
    }
}
