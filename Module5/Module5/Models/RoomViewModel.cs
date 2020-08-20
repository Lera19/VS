using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5.Models
{
    public class RoomViewModel
    {
        public RoomViewModel()
        {
            Employees = new List<EmployeeViewModel>();
        }
        public int Id { get; set; }
        public string Color { get; set; }
        public int Capacity { get; set; }
        public IList<EmployeeViewModel> Employees { get; set; }
    }
}
