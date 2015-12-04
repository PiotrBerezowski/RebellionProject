using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Update
{
    public class UpdateRebel
    {
        private void UpdateARebel(string NewName, int ID, int GroupID)
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
