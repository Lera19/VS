using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL.Model;
using BusinessLayer.Models;

namespace BusinessLayer.Managers
{
    public class EmplManager
    {
        public readonly EmplRepository _repository;

        public readonly Mapper _mapper;

        public EmplManager()
        {
            _repository = new EmplRepository();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Employee, EmployeeModel>();
                cfg.CreateMap<EmployeeModel, Employee>();

            });
            _mapper = new Mapper(config);
        }

        
        public void AddEmployee(EmployeeModel employeeModel)
        {
            var employee = _mapper.Map<Employee>(employeeModel);
            _repository.AddEmployee(employee);
        }

        public IEnumerable<EmployeeModel> GetAllEmployees()
        {
            var employees = _repository.GetAllEmployees();
            var result = _mapper.Map<IList<EmployeeModel>>(employees);
            return result;
        }

       

        //public IList<HomeModel> GetAllHomes()
        //{
        //    var result = _mapper.Map<IList<HomeModel>>(_repository.GetAllHomes());
        //    return result;
        //}
    }
}
