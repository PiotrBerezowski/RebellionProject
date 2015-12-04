using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Add
{
    public class AddRebel
    {
        RebellionDataEntities context;

        public AddRebel(RebellionDataEntities Context)
        {
            context = Context;
        }

        public void createNewRebel(string Codename, int RebelID, int GroupID)
        {
            string codename = Codename;
            int rebelId = RebelID;
            int groupId = GroupID;
            using (context)
            {
                Rebel rebel = new Rebel();
                rebel.code_name = codename;
                rebel.rebel_id = rebelId;
                rebel.Fk_group_id = groupId;
                context.Rebels.Add(rebel);
                context.SaveChanges();
            }
        }
        
    }
}
