using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebApplication2017_MVC_GuestBook.Models
{
    public partial class MVC_UserDBContext : DbContext
    {
        public MVC_UserDBContext()
            : base("name=MVC_UserDB")
        {
        }

        public virtual DbSet<UserTable> UserTables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserTable>()
                .Property(e => e.UserSex)
                .IsFixedLength();
        }
    }
}
