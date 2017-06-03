using NUnit.Framework;
using SnakeApplication;

namespace SnakeTest
{
    [TestFixture]
    public class DotAndHelpersTest
    {
        [TestCase(2, 2, 0)]
        [TestCase(3, 2, 1)]
        [TestCase(12, 5, 2)]
        [TestCase(-12, 5, 3)]
        [TestCase(-150,25,0)]
        public void ShouldBehaveLikeARealModulo(int a, int b, int expected)
        {
            Assert.AreEqual(expected, a.Modulo(b));
        }

        [TestCase(-6)]
        [TestCase(-150)]
        [TestCase(500)]
        [TestCase(6)]
        public void NoMatterWhatXShouldStayBetween0AndMaxValue(int x)
        {
            var dot = new Dot
            {
                X = x
            };
            Assert.IsTrue(dot.X >= 0 && dot.X < SnakeConstants.FrameMaxSize);
        }
    }
}