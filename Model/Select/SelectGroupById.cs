using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Select
{
    public class SelectGroupByID
    {
      private RebellionDataEntities context;
      public SelectGroupByID(RebellionDataEntities Context)
      {
        context = Context;
      }
        public string FindGroup(int id)
        {
            try
            {
                using (context)
                {
                  return context.Groups.Where<Group>(m => m.group_id == id).First().group_name;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
