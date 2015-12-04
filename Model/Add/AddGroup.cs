using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Add
{
    class AddGroup
    {
        RebellionDataEntities context;

        public AddGroup(RebellionDataEntities Context)
        {
            context = Context;
        }

        public void CreateNewGroup(string GroupName, int GroupID, string Territory)
        {
            string groupName = GroupName;
            string territory = Territory;
            int groupId = GroupID;
            using (context)
            {
                Group group = new Group();
                group.group_name = groupName;
                group.territory = territory;
                group.group_id = groupId;
                context.Groups.Add(group);
                context.SaveChanges();
            }
        }
    }
}
