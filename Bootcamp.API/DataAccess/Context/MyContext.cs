using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class MyContext : DbContext
    {
        public MyContext() : base("MyContext") { } //karena connection stringnya dibuat manual, isi base sesuaikan dengan add name= di app.config, bukan nama database
        public DbSet<Supplier> Suppliers { get; set; }
    }
}
