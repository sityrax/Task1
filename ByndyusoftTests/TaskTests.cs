using Microsoft.VisualStudio.TestTools.UnitTesting;
using Byndyusoft;
using System;


namespace Byndyusoft.Tests
{
    [TestClass()]
    public class TaskTests
    {
        [TestMethod()]
        public void Sum_base()
        {
            //arrange
            int[] input = new[] { 4, 0, 3, 19, 492, -10, 1 };
            int expected = -10;

            //act
            int actual = Task.Sum(input);

            //assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void Sum_0and0_0returned()
        {
            //arrange
            int[] input = new int[2] { 0, 0 };
            int expected = 0;

            //act
            int actual = Task.Sum(input);

            //assert
            Assert.AreEqual(expected, actual);
        }


        [ExpectedException(typeof(IndexOutOfRangeException))]
        [TestMethod()]
        public void Sum_IndexOutOfRangeException_zeroValue()
        {
            int actual = Task.Sum(0);
        }


        [ExpectedException(typeof(IndexOutOfRangeException))]
        [TestMethod()]
        public void Sum_IndexOutOfRangeException_emptyArray()
        {
            int actual = Task.Sum(new int[0]);
        }


        [ExpectedException(typeof(OverflowException))]
        [TestMethod()]
        public void Sum_OverflowException_value()
        {
            int actual = Task.Sum(new int[] { int.MaxValue, int.MaxValue });
        }


        [ExpectedException(typeof(OverflowException))]
        [TestMethod()]
        public void Sum_OverflowException_range()
        {
            int actual = Task.Sum(new int[ulong.MaxValue]);
        }


        [ExpectedException(typeof(NullReferenceException))]
        [TestMethod()]
        public void Sum_NullReferenceException()
        {
            int actual = Task.Sum(null);
        }
    }
}