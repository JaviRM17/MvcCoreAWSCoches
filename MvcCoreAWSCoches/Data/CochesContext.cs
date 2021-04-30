using Microsoft.EntityFrameworkCore;
using MvcCoreAWSCoches.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreAWSCoches.Data
{
    public class CochesContext: DbContext
    {
        public CochesContext(DbContextOptions<CochesContext> options): base(options) { }
        public DbSet<Coches> Coches { get; set; }
    }
}
