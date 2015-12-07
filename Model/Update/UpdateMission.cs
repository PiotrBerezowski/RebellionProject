using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Update
{
    public class UpdateMission
    {
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
    }
}
