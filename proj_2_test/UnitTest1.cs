using NUnit.Framework;

namespace proj_2_test
{
    
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.That(proj_2.Math.MyMath(10, 5), Is.EqualTo(50));
        }
        [Test]
        public void Test2()
        {
            Assert.That(proj_2.Math.MyMath(-50, 4), Is.EqualTo(-200));
        }
    }
}