using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Model.Add;
using Model;
using Model.Select;
using Model.Update;
//using Model.Delete;

namespace RebellionWcfHost
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RebellionDatabase" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select RebellionDatabase.svc or RebellionDatabase.svc.cs at the Solution Explorer and start debugging.
    public class RebellionDatabase : IRebellionDatabase
    {

        public Dictionary<int, string> ViewGroupDatabase()
        {
            Dictionary<int, string> grpObject = new Dictionary<int, string>();

            using (var dataEntities = new RebellionDataEntities())
            {
                foreach (var grp in dataEntities.Groups)
                {
                    grpObject.Add(grp.group_id, grp.group_name);
                }

            }
            return grpObject;
        }

        public void CreateNewGroup(string GroupName, int GroupID, string Territory)
        {
            AddGroup newgroup = new AddGroup(new RebellionDataEntities());
                newgroup.CreateNewGroup(GroupName, GroupID, Territory);
        }

        public void CreateNewMission(string MissionName, int MissionID, string Type, int GroupID)
        {

            AddMission missiongroup = new AddMission(new RebellionDataEntities());
            missiongroup.CreateNewMission(MissionName, MissionID, Type, GroupID);
        }

        public void createNewRebel(string Codename, int RebelID, int GroupID)
        {
            AddRebel rebel = new AddRebel(new RebellionDataEntities());
            rebel.createNewRebel(Codename, RebelID, GroupID);
        }

        public string DeleteRebel(int id)
        {
            DeleteRebelByID deleteRebelObject = new DeleteRebelByID(new RebellionDataEntities());
          string result=  deleteRebelObject.DeleteRebel(id);
          return result;
        }

        public string FindGroup(int id)
        {
            SelectGroupByID group = new SelectGroupByID(new RebellionDataEntities());
           string result= group.FindGroup(id);

           return result;
        }

        public string FindMission(int id)
        {
            SelectMissionByID group = new SelectMissionByID(new RebellionDataEntities());
           string result= group.FindMission(id);
           return result;
        }

        public string FindRebel(int id)
        {
            SelectRebelByID rebelid = new SelectRebelByID(new RebellionDataEntities());
           string result= rebelid.FindRebel(id);
           return result;
        }

        public void UpdateAGroup(string GroupName, int GroupID, string Territory)
        {
            UpdateGroup group = new UpdateGroup();
            group.UpdateAGroup(GroupName, GroupID, Territory);
        }

        public void UpdateAMission(string MissionName, int MissionID, string Type, int GroupID)
        {
            UpdateMission mission = new UpdateMission();
            mission.UpdateAMission(MissionName, MissionID, Type, GroupID);
        }

        public void UpdateARebel(string NewName, int ID, int GroupID)
        {
            UpdateRebel rebel = new UpdateRebel();
            rebel.UpdateARebel(NewName, ID, GroupID);
        }
    }
}
