using Xunit;
using ClassLibrary;
using System;

namespace LengthTest
{
    public class UnitTest1
    {
        LengthCounter obj = new LengthCounter();
        [Fact]
        public void NullCheck()
        {
            Assert.Equal(0, obj.counter(""));
        }
        [Fact]
        public void StringCheck()
        {
            Assert.Equal(3, obj.counter("123"));
        }

        [Fact]
        public void NumberCheck()
        {
            Assert.Equal(12, obj.counter("123456789010"));
        }

    }
}