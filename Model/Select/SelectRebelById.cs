using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Select
{
    public class SelectRebelByID
    {
        public string FindRebel(int id)
        {
            try
            {
                int ID = id;
                string codename = String.Empty;
                using (var context = new RebellionDataEntities())
                {
                    codename = context.Rebels.Find(ID).code_name;
                }
                return codename;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
