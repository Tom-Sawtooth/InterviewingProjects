using System;
using InterviewExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VerificationTests
{
    [TestClass]
    public class StringExtensionTests
    {
        [TestMethod]
        public void PadLeft_SimplePasses()
        {
            // arrange
            string input = "text";
            int totalWidth = 5;

            // act
            string padded = input.ExercisePadLeft(totalWidth);

            // assert
            string expected = input.PadLeft(totalWidth);
            Assert.AreEqual(expected, padded);
            expected = " text";
            Assert.AreEqual(expected, padded);
        }

        [TestMethod]
        public void PadLeft_TotalWidthTooSmall()
        {
            // arrange
            string input = "text";
            int totalWidth = 3;

            // act
            string padded = input.ExercisePadLeft(totalWidth);

            // assert
            string expected = input.PadLeft(totalWidth);
            Assert.AreEqual(expected, padded);
            expected = "text";
            Assert.AreEqual(expected, padded);
        }

        [TestMethod]
        public void PadLeft_RandomWidth()
        {
            // arrange
            string input = "text";
            Random rand = new();
            int totalWidth = rand.Next(5, 100);

            // act
            string padded = input.ExercisePadLeft(totalWidth);

            // assert
            string expected = input.PadLeft(totalWidth);
            Assert.AreEqual(expected, padded);
        }
    }
}
