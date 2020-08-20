using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EmplRepository
    {
        public void AddEmployee(Employee employee)
        {
            using(var context=new EmplRoomContext())
            {
                context.Employees.Add(employee);
                context.SaveChanges();
            }
        }

        public void AddRoom(Room room)
        {
            using (var context = new EmplRoomContext())
            {
                context.Rooms.Add(room);
                context.SaveChanges();
            }
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            using (var context = new EmplRoomContext())
            {
                return context.Employees.ToList();
            }
        }
        public IEnumerable<Room> GetAllRooms()
        {
            using (var context = new EmplRoomContext())
            {
                return context.Rooms.ToList();
            }
        }

    }
}
