using SimpleAPI.Controllers;
using System;
using Xunit;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        ValuesController controller = new ValuesController();

        [Fact]
        public void GetReturnsMyName()
        {
            var returnValue = controller.Get(2);

            Assert.Equal("Charlie Brown", returnValue.Value);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
