using InterfaceExample2;
using System;
using Xunit;

namespace InterfaceExample22.Tests
{
    public class DeskFanTests
    {
        [Fact]
        public void PowerLowerThanZero_OK()
        {
            DeskFan fan = new DeskFan(new PowerSupplyLowerThanZero());
            var expected = "Won't work.";
            var actual = fan.Work();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PowerLowerThanZero_Warning()
        {
            DeskFan fan = new DeskFan(new PowerSupplyLowerThan200());
            var expected = "Warning!";
            var actual = fan.Work();
            Assert.Equal(expected, actual);
        }
    }

    class PowerSupplyLowerThanZero : IPowerSupply
    {
        public int GetPower()
        {
            return 0;
        }
    }

    class PowerSupplyLowerThan200 : IPowerSupply
    {
        public int GetPower()
        {
            return 221;
        }
    }
}
