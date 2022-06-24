using System.Collections.Generic;
using System.IO;

namespace MiniTC.Model
{
    class Model
    {
        public string[] GetAllDrives() => Directory.GetLogicalDrives();
        public static string GetParentOfFile(string path) => Directory.GetParent(path).FullName;
        public string[] GetAllFiles(string path)
        {
            List<string> Content = new List<string>();
            try
            {
                if (Directory.GetParent(path) != null)
                    Content.Add("..");

                string[] Directories = Directory.GetDirectories(path);
                string[] Files = Directory.GetFiles(path);

                for (int i=0; i<Directories.Length; i++)
                    Content.Add("<D>" + Path.GetFileName(Directories[i]));

                for (int j = 0; j < Files.Length; j++)
                    Content.Add(Path.GetFileName(Files[j]));
            }
            catch {}
            return Content.ToArray();
        }
        public string ChangePath(string path, string selectedFile)
        {
            if (selectedFile != null && selectedFile != "..." && selectedFile.Contains("<D>") )
            {
                selectedFile = selectedFile.Replace("<D>", "");
                string newPath = Path.Combine(path, selectedFile);
                return newPath;
            }

            if (selectedFile == "...")
                path = GetParentOfFile(path);

            return path;
        }
        public void CopyFile(string source, string destination)
        {
            try
            {
                File.Copy(source, destination, true);
            }
            catch {}
        }
    }
}
