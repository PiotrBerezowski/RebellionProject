using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF
{
    public class Delete : IDelete
    {
        DeleteRebelByID entitymodelDelete = new DeleteRebelByID();

        public string DeleteRebelWCF(int RebelId)
        {
            string codename = entitymodelDelete.DeleteRebel(RebelId);
            return codename;        
        }

    }
}
