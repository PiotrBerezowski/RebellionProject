using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DeleteRebelByID
    {
        public static string DeleteRebel(int id)
        {
            try
            {
                int ID = id;
                string codename = String.Empty;
                using (var context = new RebellionDataEntities())
                {
                    List<Rebel> rebelList = context.Rebels.Where<Rebel>(t => t.rebel_id == ID).ToList();
                    foreach (Rebel rebel in rebelList)
                    {
                        codename = context.Rebels.Find(ID).code_name;
                        context.Rebels.Remove(rebel);
                    }
                    context.SaveChanges();
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
