using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using Moq;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
  [TestClass]
  public class DeleteTests
  {
    DeleteRebelByID delete;
    Mock<RebellionDataEntities> context;

    [TestInitialize]
    public void TestSetup()
    {
      context = new Mock<RebellionDataEntities>();   
      List<Rebel> rebelList = new List<Rebel>();
      Mock<Rebel> mockRebel = new Mock<Rebel>();
      mockRebel.SetupAllProperties();
      mockRebel.Object.rebel_id = 1;
      mockRebel.Object.code_name = "Phoenix";
      rebelList.Add(mockRebel.Object);

      DbSet<Rebel> mockedRebelSet = GetQueryableMockSet.GetQueryableMockDbSet<Rebel>(rebelList);

      context.SetupAllProperties();
      context.Object.Rebels = mockedRebelSet;
      delete = new DeleteRebelByID(context.Object);
    }

    [TestMethod]
    public void Test_DeleteRebel_ReturnsStringCodenameWhenGivenAnID()
    {
      //Arrange
      string expectedValue = "Phoenix";

      //Act
      string actualValue = delete.DeleteRebel(1);

      //Assert
      Assert.AreEqual(expectedValue, actualValue);

    }

    [TestMethod]
    public void Test_DeleteRebel_RemovesRebelFromDatabaseWhenGivenAnID()
    {
      //Arrange

      //Act
      delete.DeleteRebel(1);

      //Assert
      Assert.AreEqual(0, context.Object.Rebels.Count());
    }
  }
}
