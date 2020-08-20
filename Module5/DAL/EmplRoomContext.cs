using DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EmplRoomContext: DbContext
    {
        public EmplRoomContext():base("DefaultConnection")
        {
            Database.SetInitializer(new Initializer());
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Room> Rooms { get; set; }
    }
}
