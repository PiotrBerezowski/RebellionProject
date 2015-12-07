using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Select
{
    public class SelectRebelByID
    {
      private RebellionDataEntities context;

      public SelectRebelByID(RebellionDataEntities Context)
      {
        context = Context;
      }
        public string FindRebel(int id)
        {
            try
            {
                using (context )
                {
                  return context.Rebels.Where<Rebel>(m => m.rebel_id == id).First().code_name;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
