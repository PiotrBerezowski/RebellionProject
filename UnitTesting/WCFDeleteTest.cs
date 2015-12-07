using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WCF;
using Moq;
using Model;

namespace UnitTesting
{

    [TestClass]
    public class WCFDeleteTest
    {
        [TestMethod]
        public void WCFDeleteTest_CheckIfDeleteRebelWCFCallsDeleteRebel_WhenCalled()
        {
            // Arrange
            Delete delete = new Delete();
            int ID = 1;
            Mock<DeleteRebelByID> mockEntityFrameworkDelete = new Mock<DeleteRebelByID>();

            // Act
            delete.DeleteRebelWCF(ID);

            // Assert
            mockEntityFrameworkDelete.Verify(x => x.DeleteRebel(It.IsAny<int>()), Times.Once);
        }
    }
}
