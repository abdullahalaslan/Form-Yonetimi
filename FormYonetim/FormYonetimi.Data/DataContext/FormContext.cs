using FormYonetimi.Data.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormYonetimi.Data.DataContext
{
  public class FormContext : DbContext
    {
        public DbSet<Kullanici> Kullanici { get; set; }

        public DbSet<Form> Form { get; set; }

        public DbSet<Admin> Admin { get; set; }
    }
}
