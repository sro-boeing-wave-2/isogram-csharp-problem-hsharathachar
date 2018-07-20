using System;
using Xunit;
using isogram_csharp_problem;

namespace Isogram.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void EmptyString()
        {
            var IsogramChecker = new Class1();
            bool actual = IsogramChecker.IsIsogramOrNot("");
            var expected = true;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Isogram()
        {
            var IsogramChecker = new Class1();
            bool actual = IsogramChecker.IsIsogramOrNot("isogram");
            var expected = true;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Eleven()
        {
            var IsogramChecker = new Class1();
            bool actual = IsogramChecker.IsIsogramOrNot("eleven");
            var expected = false;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Subdermatoglyphic()
        {
            var IsogramChecker = new Class1();
            bool actual = IsogramChecker.IsIsogramOrNot("subdermatoglyphic");
            var expected = true;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Alphabet()
        {
            var IsogramChecker = new Class1();
            bool actual = IsogramChecker.IsIsogramOrNot("Alphabet");
            var expected = true;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ThumbscrewJapingly()
        {
            var IsogramChecker = new Class1();
            bool actual = IsogramChecker.IsIsogramOrNot("thumbscrew-japingly");
            var expected = true;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SixYearOld()
        {
            var IsogramChecker = new Class1();
            bool actual = IsogramChecker.IsIsogramOrNot("six-year-old");
            var expected = true;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void HSA()
        {
            var IsogramChecker = new Class1();
            bool actual = IsogramChecker.IsIsogramOrNot("bnj fre ");
            var expected = true;
            Assert.Equal(expected, actual);
        }
    }
}
