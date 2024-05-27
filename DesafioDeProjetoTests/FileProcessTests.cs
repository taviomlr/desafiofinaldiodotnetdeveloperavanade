using System;
using Xunit;
using DesafioDeProjetoBiblioteca;
using System.IO;


namespace DesafioDeProjetoTests
{
    public class FileProcessTests
    {
        [Fact]
        public void FileExists_ValidFileName_ReturnsTrue()
        {
            // Arrange
            var fileProcess = new FileProcess();
            string fileName = "testfile.txt";
            System.IO.File.WriteAllText(fileName, "Test content");

            // Act
            bool result = fileProcess.FileExists(fileName);

            // Assert
            Assert.True(result);

            // Cleanup
            System.IO.File.Delete(fileName);
        }

        [Fact]
        public void FileExists_InvalidFileName_ReturnsFalse()
        {
            // Arrange
            var fileProcess = new FileProcess();
            string fileName = "nonexistentfile.txt";

            // Act
            bool result = fileProcess.FileExists(fileName);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void FileExists_EmptyFileName_ThrowsArgumentNullException()
        {
            // Arrange
            var fileProcess = new FileProcess();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => fileProcess.FileExists(string.Empty));
        }

        [Fact]
        public void FileExists_NullFileName_ThrowsArgumentNullException()
        {
            // Arrange
            var fileProcess = new FileProcess();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => fileProcess.FileExists(null));
        }

        [Fact]
        public void CreateFile_ValidFileName_CreatesFile()
        {
            // Arrange
            var fileProcess = new FileProcess();
            string fileName = "newfile.txt";
            string content = "New file content";

            // Act
            fileProcess.CreateFile(fileName, content);

            // Assert
            Assert.True(File.Exists(fileName));
            Assert.Equal(content, File.ReadAllText(fileName));

            // Cleanup
            File.Delete(fileName);
        }

        [Fact]
        public void CreateFile_EmptyFileName_ThrowsArgumentNullException()
        {
            // Arrange
            var fileProcess = new FileProcess();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => fileProcess.CreateFile(string.Empty, "Content"));
        }

        [Fact]
        public void CreateFile_NullFileName_ThrowsArgumentNullException()
        {
            // Arrange
            var fileProcess = new FileProcess();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => fileProcess.CreateFile(null, "Content"));
        }

        [Fact]
        public void ReadFile_ValidFileName_ReturnsContent()
        {
            // Arrange
            var fileProcess = new FileProcess();
            string fileName = "readfile.txt";
            string content = "File content";
            File.WriteAllText(fileName, content);

            // Act
            string result = fileProcess.ReadFile(fileName);

            // Assert
            Assert.Equal(content, result);

            // Cleanup
            File.Delete(fileName);
        }

        [Fact]
        public void ReadFile_FileNotFound_ThrowsFileNotFoundException()
        {
            // Arrange
            var fileProcess = new FileProcess();
            string fileName = "nonexistentfile.txt";

            // Act & Assert
            Assert.Throws<FileNotFoundException>(() => fileProcess.ReadFile(fileName));
        }

        [Fact]
        public void WriteToFile_ValidFileName_OverwritesContent()
        {
            // Arrange
            var fileProcess = new FileProcess();
            string fileName = "writefile.txt";
            string initialContent = "Initial content";
            string newContent = "New content";
            File.WriteAllText(fileName, initialContent);

            // Act
            fileProcess.WriteToFile(fileName, newContent);

            // Assert
            Assert.Equal(newContent, File.ReadAllText(fileName));

            // Cleanup
            File.Delete(fileName);
        }

        [Fact]
        public void WriteToFile_FileNotFound_ThrowsFileNotFoundException()
        {
            // Arrange
            var fileProcess = new FileProcess();
            string fileName = "nonexistentfile.txt";

            // Act & Assert
            Assert.Throws<FileNotFoundException>(() => fileProcess.WriteToFile(fileName, "Content"));
        }

        [Fact]
        public void DeleteFile_ValidFileName_DeletesFile()
        {
            // Arrange
            var fileProcess = new FileProcess();
            string fileName = "deletefile.txt";
            File.WriteAllText(fileName, "Content");

            // Act
            fileProcess.DeleteFile(fileName);

            // Assert
            Assert.False(File.Exists(fileName));
        }

        [Fact]
        public void DeleteFile_FileNotFound_ThrowsFileNotFoundException()
        {
            // Arrange
            var fileProcess = new FileProcess();
            string fileName = "nonexistentfile.txt";

            // Act & Assert
            Assert.Throws<FileNotFoundException>(() => fileProcess.DeleteFile(fileName));
        }

    }
}
