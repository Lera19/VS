using BusinessLayer;
using BusinessLayer.Managers;
using BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Module5.Controllers
{
    public class EmplRoomController : Controller
    {
        private readonly EmplManager _emplManager;
        private readonly RoomManager _roomManager;

        public EmplRoomController()
        {
            _emplManager = new EmplManager();
            _roomManager = new RoomManager();
        }
        public ActionResult Index()
        {
            var employee = _emplManager.GetAllEmployees();
            return View(employee);
        }

        [HttpGet]
        public ActionResult CreateEmployee()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateEmployee(EmployeeViewModel employeeModel)
        {
            _emplManager.AddEmployee(employeeModel);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult CreateRoom()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateRoom(RoomModel roomModel)
        {
            _roomManager.AddRoom(roomModel);

            return RedirectToAction("Index");
        }

    }
}