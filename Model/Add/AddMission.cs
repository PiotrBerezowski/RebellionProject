using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Add
{
    class AddMission
    {
        RebellionDataEntities context;

        public AddMission(RebellionDataEntities Context)
        {
            context = Context;
        }

        public void CreateNewMission(string MissionName, int MissionID, string Type, int GroupID)
        {
            string missionName = MissionName;
            int missionId = MissionID;
            string type = Type;
            int groupId = GroupID;
            using (context)
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
    }
}
