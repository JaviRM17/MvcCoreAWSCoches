using MvcCoreAWSCoches.Data;
using MvcCoreAWSCoches.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreAWSCoches.Repositories
{
    public class RepositoryCoches
    {
        CochesContext context;
        public RepositoryCoches(CochesContext context)
        {
            this.context = context;
        }
        public List<Coches> GetCoches()
        {
            return this.context.Coches.ToList();
        }
    }
}
