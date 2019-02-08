using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestNotTableWithTwoTrue()
        {
            bool a = true;
            bool b = true;
            bool actual = NorTable(a,b);
            bool expected = true;
            Assert.Equal(expected,actual);
        }
        [Fact]
        public void TestGreatestOfThree()
        {
            int a = 6;
            int b = 2;
            int c = 5;
            int expected = GreatestNumber(a,b,c);
            int actual = 6;
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4,4, 2, 2)]
        [InlineData(-5,-12, -7, -5)]
        [InlineData(2,-2, -8, 2)]
        public void GreatestNumber_WorksWithManyInputs(int exp,int a, int b, int c)
        {
            Assert.Equal(exp, GreatestNumber(a, b,c));
        }


        bool NorTable(bool a, bool b) {
            if (a || b == true)
            {
                return true;

            }
            else {
                return false;
            }

        }

        int GreatestNumber(int a,int b,int c) {
            if (a >= b)
            {
                if (a >= c)
                    return a;
                else
                    return c;
            }
            else
            {
                if (b >= c)
                    return b;
                else
                    return c;
            }
        }
    }
}
