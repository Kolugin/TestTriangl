using GeometryLibrary;
using Xunit.Sdk;

namespace TestProject1
{
    [TestClass]
    public class GeometryTests
    {
        [TestMethod]
        public void Circle_CalculateArea_ShouldReturnCorrectValue()
        {
            var circle = new Circle(5);
            double expectedArea = Math.PI * 25;
            Assert.AreEqual(expectedArea, circle.CalculateArea(), 1e-10);
        }

        [TestMethod]
        public void Triangle_CalculateArea_ShouldReturnCorrectValue()
        {
            var triangle = new Triangle(3, 4, 5);
            double expectedArea = 6;
            Assert.AreEqual(expectedArea, triangle.CalculateArea(), 1e-10);
        }

        [TestMethod]
        public void Triangle_IsRightTriangle_ShouldReturnTrue()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.IsRightTriangle());
        }

        [TestMethod]
        public void Triangle_IsRightTriangle_ShouldReturnFalse()
        {
            var triangle = new Triangle(3, 4, 6);
            Assert.IsFalse(triangle.IsRightTriangle());
        }

        [TestMethod]
        public void ShapeProcessor_GetArea_ShouldWorkForCircle()
        {
            var processor = new ShapeProcessor();
            var circle = new Circle(5);
            double expectedArea = Math.PI * 25;
            Assert.AreEqual(expectedArea, processor.GetArea(circle), 1e-10);
        }

        [TestMethod]
        public void ShapeProcessor_GetArea_ShouldWorkForTriangle()
        {
            var processor = new ShapeProcessor();
            var triangle = new Triangle(3, 4, 5);
            double expectedArea = 6;
            Assert.AreEqual(expectedArea, processor.GetArea(triangle), 1e-10);
        }
    }
}
