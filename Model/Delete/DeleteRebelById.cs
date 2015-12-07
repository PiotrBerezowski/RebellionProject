using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
  public class DeleteRebelByID
  {
    private RebellionDataEntities context;

    public DeleteRebelByID(RebellionDataEntities Context)
    {
      context = Context;
    }
    public string DeleteRebel(int id)
    {
      try
      {
        int ID = id;
        string codename = String.Empty;
        using (context)
        {
          Rebel rebel = context.Rebels.Where<Rebel>(t => t.rebel_id == ID).First();
          codename = rebel.code_name;
          context.Rebels.Remove(rebel);
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
