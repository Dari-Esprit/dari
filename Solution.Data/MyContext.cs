using Solution.Data.CustomConventions;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Data
{
    public class MyContext:DbContext
    {
        public MyContext():base("name=machaine")
        {

        }
        // dbset
        //public DbSet<Entity> Entities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //ajouter les config + conv
            //modelBuilder.Configurations.Add(new ExempleConfigurations());
            modelBuilder.Conventions.Add(new ExpConvention());
        }
    }
}
