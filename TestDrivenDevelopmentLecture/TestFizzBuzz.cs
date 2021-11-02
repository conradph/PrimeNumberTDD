using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
namespace TestDrivenDevelopmentLecture
{
    public class TestFizzBuzz
    {
        /*[Theory]
        [InlineData(3, "fizz")]
        [InlineData(5, "buzz")]
        [InlineData(10, "buzz")]
        [InlineData(6, "fizz")]
        [InlineData(15, "fizzbuzz")]
        [InlineData(45, "fizzbuzz")]
        [InlineData(345767, "")]
        [InlineData(13, "")]
        public void TestFB(int num, string expected)
        {
            FizzBuzz fb = new FizzBuzz();
            string actual = fb.GetFizzBuzz(num);
            Assert.Equal(expected, actual);
        }*/

        [Theory]
        [InlineData(1, "odd")]
        [InlineData(2, "prime")]
        [InlineData(3, "prime")]
        [InlineData(4, "even")]
        [InlineData(7, "prime")]
        [InlineData(9, "odd")]
        [InlineData(13, "prime")]
        [InlineData(29, "prime")]
        [InlineData(11, "prime")]
        [InlineData(17, "prime")]

        public void TestKata(int num, string expected)
        {
            Primething test = new Primething();
            string actual = test.Kata(num);
            Assert.Equal(expected, actual);
        }
    }
}
