using AirSystem.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSystem.Repositories
{
    public class AcessoRepository
    {

        public AcessoRepository()
        {

        }

        public List<Acesso> BuscarTodos()
        {
            using (AirSystemEntities ent = new AirSystemEntities())
            {
                
                
                return ent.Acesso.ToList();
            }
        }
    }
}
