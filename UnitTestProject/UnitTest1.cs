using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructureDemo;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [DataRow(30,2)]
        [TestMethod]
        public void TestForPositionInTheLinkedList(int value, int position)
        {
            //Arrange
            LinkedList list = new LinkedList();
            list.InsertLast(70);
            list.InsertLast(30);
            list.InsertLast(56);
            //Act
            int expected = 2;
            int actual = list.SearchValue(30);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
