using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Select
{
    public class SelectMissionByID
    {
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
    }
}
