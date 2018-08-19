using discount.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace tests
{
    [TestClass]
    public class OrderControllerTests
    {
        [TestMethod]
        public void can_calculate_total() {
            // arrange
            OrderController target = new OrderController();
            // act
            var result = target.CalculateTotal("9431");
            // assert
            Assert.AreEqual(result,90.67);
        }
    }
}