namespace Matrix.Tests
{
    using System;
    using System.Reflection;
    using Interfaces;
    using Moq;
    using NUnit.Framework;

    [TestFixture]
    public class MatrixTests
    {
        [Test]
        public void RotateMatrix_NegativeMatrixSize_ShouldThrowArgumentOutOfRangeException()
        {
            // Arrange
            var mockedLogger = new Mock<ILogger<string>>();
            var mockedReader = new Mock<IReader>();
            mockedReader.Setup(r => r.ReadInput()).Returns("-10");

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                Matrix.RotateMatrix(mockedLogger.Object, mockedReader.Object);
            });
        }

        [TestCase("1")]
        [TestCase("3")]
        [TestCase("5")]
        public void RotateMatrix_ValidMatrixSize_ShouldReturnMatrixWithSizeOfRowAndColOfPassedOne(string matrixSizeFromConsole)
        {
            // Arrange
            var mockedLogger = new Mock<ILogger<string>>();
            var mockedReader = new Mock<IReader>();
            mockedReader.Setup(r => r.ReadInput()).Returns(matrixSizeFromConsole);

            // Act
            var matrix = Matrix.RotateMatrix(mockedLogger.Object, mockedReader.Object);

            // Assert
            int expectedMatrixSize = int.Parse(matrixSizeFromConsole);
            int actualMatrixSize = matrix.GetLength(0);

            Assert.AreEqual(expectedMatrixSize, actualMatrixSize);
        }

        [Test]
        public void PrintMatrix_ShouldPrintMatrixCorrectly()
        {
            // Arrange
            var mockedLogger = new Mock<ILogger<string>>();
            var mockedReader = new Mock<IReader>();
            string loggedValue = string.Empty;
            mockedReader.Setup(r => r.ReadInput()).Returns("3");
            mockedLogger.Setup(l => l.LogData(It.IsAny<string>())).Callback<string>(str => loggedValue = str);

            // Act
            var matrix = Matrix.RotateMatrix(mockedLogger.Object, mockedReader.Object);
            var printMatrixMethod = typeof(Matrix)
                .GetMethod("PrintMatrix", BindingFlags.NonPublic | BindingFlags.Static);

            printMatrixMethod.Invoke(null, new object[] { matrix, mockedLogger.Object });

            // Assert
            string expected =
                $"  1  7  8{Environment.NewLine}" +
                $"  6  2  9{Environment.NewLine}" +
                $"  5  4  3{Environment.NewLine}";
            string actual = loggedValue;

            StringAssert.AreEqualIgnoringCase(expected, actual);
        }
    }
}