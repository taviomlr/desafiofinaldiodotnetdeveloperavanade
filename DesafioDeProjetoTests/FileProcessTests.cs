using System;
using Xunit;
using DesafioDeProjetoBiblioteca;


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
    }
}
