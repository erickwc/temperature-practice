using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ECRC.StringManipulator;

namespace ECRC.StringManipulator.UnitTestXUnit
{
    public class StringManipulatorTests
    {
        private readonly StringManipulator manipulator = new StringManipulator();

        [Fact]
        public void ReverseString_Hello_ReturnsOlleh()
        {
            string result = manipulator.ReverseString("Hello");
            Assert.Equal("olleH", result);
        }

        [Fact]
        public void ReverseString_EmptyString_ReturnsEmpty()
        {
            string result = manipulator.ReverseString("");
            Assert.Equal("", result);
        }

        [Fact]
        public void RemoveSpaces_TextWithSpaces_ReturnsTextWithoutSpaces()
        {
            string result = manipulator.RemoveSpaces("Hola mundo");
            Assert.Equal("Holamundo", result);
        }

        [Fact]
        public void RemoveSpaces_EmptyString_ReturnsEmpty()
        {
            string result = manipulator.RemoveSpaces("");
            Assert.Equal("", result);
        }
    }
}

