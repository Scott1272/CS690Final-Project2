using LanguageTracker;
using System;
using System.IO;


namespace LanguageTracker
{
    public class FileSaver {
        private string fileName;

        public FileSaver(string filename) {
            this.fileName = filename;
            // Ensure the file is created if it does not exist
            if (!File.Exists(this.fileName)) {
                File.Create(this.fileName).Close();
            }
        }

        public void AppendLine(string line) {
            File.AppendAllText(this.fileName, line + Environment.NewLine);
        }
    }
}