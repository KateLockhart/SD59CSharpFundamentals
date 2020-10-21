﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Setters
{
    [TestClass]
    public class RoomTests
    {
        [TestMethod]
        public void ConstructRoom_ShouldSetProperties()
        {
            var myRoom = new Room(8, 9, 12);

            Assert.AreEqual(8, myRoom.Length);
            Assert.AreEqual(9, myRoom.Width);
            Assert.AreEqual(12, myRoom.Height);
        }

        [DataTestMethod]
        [DataRow(4, 10, 10)]
        [DataRow(31, 10, 10)]
        public void CreateInvalidLength_ShouldThrowException(double l, double w, double h)
        {
            // Arrange
            Exception thrownException = null;

            // Act
            // learn more about try and catch https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch
            // try catch block to try and check code
            try
            {
                var room = new Room(l, w, h);
            }
            catch (Exception err)
            {
                thrownException = err;
            }

            // Assert
            Assert.IsNotNull(thrownException);
            Assert.IsInstanceOfType(thrownException, typeof(ArgumentException));
        }
    }
}
