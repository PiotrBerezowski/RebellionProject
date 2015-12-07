using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Select
{
    public class SelectMissionByID
    {
      private RebellionDataEntities context;
      public SelectMissionByID(RebellionDataEntities Context)
      {
        context = Context;
      }
        public string FindMission(int id)
        {
            try
            {
                using (context)
                {
                  return context.Missions.Where<Mission>(m => m.mission_id == id).First().mission_name;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
