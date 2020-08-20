using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Room
    {
        public Room()
        {
            Employees = new List<Employee>();
        }
        public int Id { get; set; }
        public string Color { get; set; }
        public int Capacity { get; set; }
        public IList<Employee> Employees { get; set; }
    }
}
