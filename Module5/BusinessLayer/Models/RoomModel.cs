using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public class RoomModel
    {
        public RoomModel()
        {
            Employees = new List<EmployeeModel>();
        }
        public int Id { get; set; }
        public string Color { get; set; }
        public int Capacity { get; set; }
        public IList<EmployeeModel> Employees { get; set; }
    }
}
