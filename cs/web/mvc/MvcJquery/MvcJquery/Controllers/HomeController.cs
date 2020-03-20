using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MvcJquery.Models;

namespace MvcJquery.Controllers
{
    public class HomeController : Controller
    {
        MvcJqueryEntities db = new MvcJqueryEntities();

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetStudentList()
        {
            List<StudentViewModel> StuList = db.tblStudents.Where(x => x.IsDeleted == false).Select(x => new StudentViewModel
            {
                StudentId = x.StudentId,
                StudentName = x.StudentName,
                Email = x.Email,
                DepartmentName = x.tblDepartment.DepartmentName
            }).ToList();

            return Json(StuList, JsonRequestBehavior.AllowGet);
        }
    }
}