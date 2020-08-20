using DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Initializer : DropCreateDatabaseIfModelChanges<EmplRoomContext>
    {
        protected override void Seed(EmplRoomContext context)
        {
            //var listEmpl = new List<Employee>()
            //{
        var emp1=   new Employee() { Id = 1, FirstName = "Kira", LastName = "Budmik", Phone = 72875 };
            var emp2 = new Employee() { Id = 2, FirstName = "Lera", LastName = "Budnik", Phone = 34875 };
            var emp3 = new Employee() { Id = 3, FirstName = "Lera", LastName = "Popova", Phone = 72875 };
            var emp4 = new Employee() { Id = 4, FirstName = "Kira", LastName = "Badalova", Phone = 72875 };
            var emp5 = new Employee() { Id = 5, FirstName = "Lada", LastName = "Budnik", Phone = 22875 };
            //};
            // var listEmpl1 = new Employee() { Id = 2, FirstName = "Lera", LastName = "Budnik", Phone = 80953634875 };

            //var listRooms = new List<Room>()
            //{
            var room1 = new Room() { Color = "Red", Capacity = 2};
            var room2 = new Room() { Color = "Black", Capacity = 1 };
           var room3= new Room() { Color = "White", Capacity = 5 };


            //};var room1 

            context.Rooms.Add(room1);
            context.Rooms.Add(room2);
            context.Rooms.Add(room3);

            context.Employees.Add(emp1);
            context.Employees.Add(emp2);
            context.Employees.Add(emp3);
            context.Employees.Add(emp4);
            context.Employees.Add(emp5);

            context.SaveChanges();

        }
    }
}
