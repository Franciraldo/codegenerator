using System;

namespace iCodeGenerator.iCodeGeneratorGui
{
    public class FolderEventArgs : EventArgs
    {
        public string FolderName { get; set; }

        public FolderEventArgs(string folderName)
        {
            FolderName = folderName;
        }
    }
}