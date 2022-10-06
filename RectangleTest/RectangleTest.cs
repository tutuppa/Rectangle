using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rectangle;
using NUnit.Framework;


namespace RectangleTest
{
    [TestFixture]
    public class RectangleTest
    {

        Rectangle.Rectangle r1 = new Rectangle.Rectangle(3, 5);
        [Test]
        public void getLengthTest1()
        {

            //1.Arrange
            int expected = 3;


            //2.Act
            int res = r1.GetLength();

            //3. Assert
            Assert.AreEqual(expected, res, 1);
        }

        [Test]
        public void getLengthTest2()
        {
            //1.Arrange
            int expected = 4;

            //2.Act
            int res = r1.GetLength();

            //3. Assert
            Assert.AreNotEqual(expected, res);
        }
        [Test]
        public void getLengthTest3()
        {

            //1.Arrange
            int expected = 3;


            //2.Act
            int res = r1.GetLength();

            //3. Assert
            Assert.Greater(expected, 1);
        }

        [Test]
        public void getWidthTest1()
        {
            //1.Arrange
            int expected = 5;

            //2.Act
            int res = r1.GetWidth();

            //3. Assert
            Assert.AreEqual(expected, res, 1);
        }
        [Test]
        public void getWidthTest2()
        {
            //1.Arrange
            int expected = 8;

            //2.Act
            int res = r1.GetLength();

            //3. Assert
            Assert.AreNotEqual(expected, res);
        }
        [Test]
        public void getWidthTest3()
        {
            //1.Arrange
            int expected = 5;

            //2.Act
            int res = r1.GetWidth();

            //3. Assert
            Assert.Greater(expected,1);
        }
        [Test]
        public void setLengthTest1()
        {
            //1.Arrange
            int expected = 8;

            //2.Act
            int res = r1.SetLength(8);

            //3. Assert
            Assert.AreEqual(expected, res, 1);
        }
        [Test]
        public void setLengthTest2()
        {
            //1.Arrange
            int expected = 3;

            //2.Act
            int res = r1.SetLength(8);

            //3. Assert
            Assert.AreNotEqual(expected, res);
        }
        [Test]
        public void setLengthTest3()
        {
            //1.Arrange
            int expected = 8;

            //2.Act
            int res = r1.SetLength(8);

            //3. Assert
            Assert.Greater(expected, 1);
        }
        [Test]
        public void setWidthTest1()
        {
            //1.Arrange
            int expected = 7;

            //2.Act
            int res = r1.SetWidth(7);

            //3. Assert
            Assert.AreEqual(expected, res, 1);
        }
        [Test]
        public void setWidthTest2()
        {
            //1.Arrange
            int expected = 5;

            //2.Act
            int res = r1.SetLength(7);

            //3. Assert
            Assert.AreNotEqual(expected, res);
        }
        [Test]
        public void setWidthTest3()
        {
            //1.Arrange
            int expected = 7;

            //2.Act
            int res = r1.SetWidth(7);

            //3. Assert
            Assert.Greater(expected,1);
        }
        [Test]
        public void getPerimeterTest1()
        {
            //1.Arrange
            int expected = 16;

            //2.Act
            int res = r1.GetPerimeter();

            //3. Assert
            Assert.AreEqual(expected, res, 1);
        }
        [Test]
        public void getPerimeterTest2()
        {
            //1.Arrange
            int expected = 10;

            //2.Act
            int res = r1.GetPerimeter();

            //3. Assert
            Assert.AreNotEqual(expected, res);
        }
        [Test]
        public void getPerimeterTest3()
        {
            //1.Arrange
            int expected = 10;

            //2.Act
            int res = r1.GetPerimeter();

            //3. Assert
            Assert.Greater(expected, 1);
        }
        [Test]
        public void getAreaTest1()
        {
            //1.Arrange
            int expected = 15;

            //2.Act
            int res = r1.GetArea();

            //3. Assert
            Assert.AreEqual(expected, res, 1);
        }
        [Test]
        public void getAreaTest2()
        {
            //1.Arrange
            int expected = 8;

            //2.Act
            int res = r1.GetArea();

            //3. Assert
            Assert.AreNotEqual(expected, res);
        }
            [Test]
            public void getAreaTest3()
            {
                //1.Arrange
                int expected = 15;

                //2.Act
                int res = r1.GetArea();

                //3. Assert
                Assert.Greater(expected, 1);
            }
        }


}
