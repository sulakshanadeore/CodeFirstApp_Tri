using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibForCodeFirstDemo
{
    public class CompanyDBContext:DbContext
    {

        public CompanyDBContext() : base("name=CompanyCnString") 
        {
            Database.SetInitializer<CompanyDBContext>(new DropCreateDatabaseAlways<CompanyDBContext>());    
        }

        public DbSet<Employee> Emps { get; set; }


    }
}
