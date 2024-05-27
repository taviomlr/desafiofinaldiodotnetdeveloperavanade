using System;
using System.IO;

namespace DesafioDeProjetoBiblioteca
{
    public class FileProcess
    {
        public bool FileExists(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentNullException("fileName");
            }
            return File.Exists(fileName);
        }

        public void CreateFile(string fileName, string content)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentNullException(nameof(fileName));
            }
            File.WriteAllText(fileName, content);
        }

        public string ReadFile(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentNullException(nameof(fileName));
            }
            if (!FileExists(fileName))
            {
                throw new FileNotFoundException("File not found", fileName);
            }
            return File.ReadAllText(fileName);
        }

        public void WriteToFile(string fileName, string content)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentNullException(nameof(fileName));
            }
            if (!FileExists(fileName))
            {
                throw new FileNotFoundException("File not found", fileName);
            }
            File.WriteAllText(fileName, content);
        }

        public void DeleteFile(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentNullException(nameof(fileName));
            }
            if (!FileExists(fileName))
            {
                throw new FileNotFoundException("File not found", fileName);
            }
            File.Delete(fileName);
        }
    }
}
