using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using Model.Select;
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
  public class SelectTests
  {
    Mock<RebellionDataEntities> context;

    [TestInitialize]
    public void TestSetup()
    {
      context = new Mock<RebellionDataEntities>();
    }

    [TestMethod]
    public void Test_SelectRebelById_FindRebel_Returns_StringCodename_WhenGivenAnId()
    {
      //Arrange
      string expectedValue = "Phoenix";
      List<Rebel> rebelList = new List<Rebel>();
      Mock<Rebel> mockRebel = new Mock<Rebel>();
      mockRebel.SetupAllProperties();
      mockRebel.Object.rebel_id = 1;
      mockRebel.Object.code_name = "Phoenix";
      rebelList.Add(mockRebel.Object);

      DbSet<Rebel> mockedRebelSet = GetQueryableMockSet.GetQueryableMockDbSet<Rebel>(rebelList);

      context.SetupAllProperties();
      context.Object.Rebels = mockedRebelSet;
      SelectRebelByID select = new SelectRebelByID(context.Object);


      //Act
      string codename = select.FindRebel(1);

      //Assert
      Assert.AreEqual(expectedValue, codename);
    }

    [TestMethod]
    public void Test_SelectMissionById_FindMission_Returns_StringMissionName_WhenGivenAnId()
    {
      //Arrange
      string expectedValue = "Legends";
      List<Mission> missionList = new List<Mission>();
      Mock<Mission> mockMission = new Mock<Mission>();
      mockMission.SetupAllProperties();
      mockMission.Object.mission_id = 1;
      mockMission.Object.mission_name = "Legends";
      missionList.Add(mockMission.Object);

      DbSet<Mission> mockedMissionSet = GetQueryableMockSet.GetQueryableMockDbSet<Mission>(missionList);

      context.SetupAllProperties();
      context.Object.Missions = mockedMissionSet;

      SelectMissionByID select = new SelectMissionByID(context.Object);

      //Act
      string missionName = select.FindMission(1);

      //Assert
      Assert.AreEqual(expectedValue, missionName);
    }

    [TestMethod]
    public void Test_SelectGroupById_FindGroup_Returns_StringGroupName_WhenGivenAnId()
    {
      //Arrange
      string expectedValue = "Fire and Moonlight";
      List<Group> groupList = new List<Group>();
      Mock<Group> mockGroup = new Mock<Group>();
      mockGroup.SetupAllProperties();
      mockGroup.Object.group_id = 1;
      mockGroup.Object.group_name = "Fire and Moonlight";
      groupList.Add(mockGroup.Object);

      DbSet<Group> mockedGroupSet = GetQueryableMockSet.GetQueryableMockDbSet<Group>(groupList);

      context.SetupAllProperties();
      context.Object.Groups = mockedGroupSet;
      SelectGroupByID select = new SelectGroupByID(context.Object);

      //Act
      string groupName = select.FindGroup(1);

      //Assert
      Assert.AreEqual(expectedValue, groupName);
    }
  }
}
