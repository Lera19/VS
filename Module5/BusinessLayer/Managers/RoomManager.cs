using AutoMapper;
using BusinessLayer.Models;
using DAL;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Managers

{
    public class RoomManager
    {
        public readonly EmplRepository _repository;

        public readonly Mapper _mapper;

        public RoomManager()
        {
            _repository = new EmplRepository();

            var config = new MapperConfiguration(cfg =>
            {
              
                cfg.CreateMap<Room, RoomModel>();
                cfg.CreateMap<RoomModel, Room>();
                cfg.CreateMap<Employee, EmployeeModel>();
                cfg.CreateMap<EmployeeModel, Employee>();
            });
            _mapper = new Mapper(config);
        }

        public void AddRoom(RoomModel roomModel)
        {
            var room = _mapper.Map<Room>(roomModel);
            _repository.AddRoom(room);
        }

        public IEnumerable<RoomModel> GetAllRooms()
        {
            var room = _repository.GetAllRooms();
            var result = _mapper.Map<IList<RoomModel>>(room);
            return result;
        }
    }
}
