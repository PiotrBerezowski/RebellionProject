using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Update
{
    public class UpdateGroup
    {
        private UpdateGroup(string GroupName, int GroupID, string Territory)
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
    }
}
