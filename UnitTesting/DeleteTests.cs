using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
  [TestClass]
  public class DeleteTests
  {
    [TestMethod]
    public void Test_DeleteRebel_ReturnsStringCodenameWhenGivenAnID()
    {
      //Arrange
      DeleteRebelByID delete = new DeleteRebelByID();
      string expectedValue = "Phoenix";

      //Act
      string actualValue = delete.DeleteRebel(1);

      //Assert
      Assert.AreEqual(expectedValue, actualValue);

    }


  }
}
