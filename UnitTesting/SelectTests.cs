using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model.Select;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    [TestClass]
    public class SelectTests
    {
        [TestMethod]
        public void Test_SelectRebelById_FindRebel_Returns_StringCodename_WhenGivenAnId()
        {
            //Arrange
            SelectRebelByID select = new SelectRebelByID();

            //Act
            string codename = select.FindRebel(1);

            //Assert
            Assert.AreEqual("Phoenix", codename);
        }

        [TestMethod]
        public void Test_SelectMissionById_FindMission_Returns_StringMissionName_WhenGivenAnId()
        {
            //Arrange
            SelectMissionByID select = new SelectMissionByID();

            //Act
            string missionName = select.FindMission(1);

            //Assert
            Assert.AreEqual("Legends", missionName);
        }

        [TestMethod]
        public void Test_SelectGroupById_FindGroup_Returns_StringGroupName_WhenGivenAnId()
        {
            //Arrange
            SelectGroupByID select = new SelectGroupByID();

            //Act
            string groupName = select.FindGroup(1);

            //Assert
            Assert.AreEqual("Fire and Moonlight", groupName);
        }
    }
}
