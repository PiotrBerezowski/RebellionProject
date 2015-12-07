using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

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
            GroupClass newgroup = new GroupClass();
            newgroup.groupName = GroupName;
            newgroup.territory = Territory;
            newgroup.groupID = GroupID;
            using (var context = new RebellionDataEntities())
            {
                Group group = new Group();
                group.group_name = newgroup.groupName;
                group.territory = newgroup.territory;
                group.group_id = newgroup.groupID;
                context.Groups.Add(group);
                context.SaveChanges();
            }
        }

        public void CreateNewMission(string MissionName, int MissionID, string Type, int GroupID)
        {
            string missionName = MissionName;
            int missionId = MissionID;
            string type = Type;
            int groupId = GroupID;
            using (var context = new RebellionDataEntities())
            {
                Mission mission = new Mission();
                mission.mission_name = missionName;
                mission.mission_id = missionId;
                mission.type = type;
                mission.Fk_group_id = groupId;
                context.Missions.Add(mission);
                context.SaveChanges();
            }
        }

        public void createNewRebel(string Codename, int RebelID, int GroupID)
        {
            string codename = Codename;
            int rebelId = RebelID;
            int groupId = GroupID;
            using (var context = new RebellionDataEntities())
            {
                Rebel rebel = new Rebel();
                rebel.code_name = codename;
                rebel.rebel_id = rebelId;
                rebel.Fk_group_id = groupId;
                context.Rebels.Add(rebel);
                context.SaveChanges();
            }
        }

        public string DeleteRebel(int id)
        {
            try
            {
                int ID = id;
                string codename = String.Empty;
                using (var context = new RebellionDataEntities())
                {
                    List<Rebel> rebelList = context.Rebels.Where<Rebel>(t => t.rebel_id == ID).ToList();
                    foreach (Rebel rebel in rebelList)
                    {
                        codename = context.Rebels.Find(ID).code_name;
                        context.Rebels.Remove(rebel);
                    }
                    context.SaveChanges();
                }
                return codename;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string FindGroup(int id)
        {
            try
            {
                int ID = id;
                string groupName = String.Empty;
                using (var context = new RebellionDataEntities())
                {
                    groupName = context.Groups.Find(ID).group_name;
                }
                return groupName;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string FindMission(int id)
        {
            try
            {
                int ID = id;
                string missionName = String.Empty;
                using (var context = new RebellionDataEntities())
                {
                    missionName = context.Missions.Find(ID).mission_name;
                }
                return missionName;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string FindRebel(int id)
        {
            try
            {
                int ID = id;
                string codename = String.Empty;
                using (var context = new RebellionDataEntities())
                {
                    codename = context.Rebels.Find(ID).code_name;
                }
                return codename;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public void UpdateAGroup(string GroupName, int GroupID, string Territory)
        {
            string groupName = GroupName;
            string territory = Territory;
            int groupId = GroupID;
            using (var context = new RebellionDataEntities())
            {
                var group = context.Groups.Find(groupId);
                group.group_name = groupName;
                group.territory = territory;
                group.group_id = groupId;
                context.SaveChanges();
            }
        }

        public void UpdateAMission(string MissionName, int MissionID, string Type, int GroupID)
        {
            string missionName = MissionName;
            int missionId = MissionID;
            string type = Type;
            int groupId = GroupID;
            using (var context = new RebellionDataEntities())
            {
                var mission = context.Missions.Find(missionId);
                mission.mission_name = missionName;
                mission.mission_id = missionId;
                mission.type = type;
                mission.Fk_group_id = groupId;
                context.SaveChanges();
            }
        }

        public void UpdateARebel(string NewName, int ID, int GroupID)
        {
            int id = ID;
            string newName = NewName;
            int groupId = GroupID;
            using (var context = new RebellionDataEntities())
            {
                var rebel = context.Rebels.Find(id);
                rebel.code_name = newName;
                rebel.Fk_group_id = groupId;
                context.SaveChanges();
            }
        }
    }
}
