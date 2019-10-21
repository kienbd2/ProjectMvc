using Model.method;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.Areas.Admin.Controllers
{
    public class UserController : BaseController
    {
        // GET: Admin/User
        
        public ActionResult Index(string searchString, int page = 1, int pageSize = 10)
        {
            var dao = new SearchProduct();
            var model = dao.ListUser(searchString, page, pageSize);

            ViewBag.SearchString = searchString;

            return View(model);
        }
        public ActionResult AllCustomer( long id)
        {
            var dao = new SearchProduct();
            var model = dao.ListUserCustomer(id);
          


            return View(model);
        }
        public ActionResult AllTele(long id)
        {
            var dao = new SearchProduct();
            var model = dao.ListTele(id);



            return View(model);
        }
        [HttpPost]
        public JsonResult ChangeStatus(int id)
        {
            var result = new SearchProduct().ChangeStatus(id);
            return Json(new
            {
                status = result
            });
        }
        public ActionResult Tele(string searchString, int page = 1, int pageSize = 10)
        {
            var dao = new SearchProduct();
            var model = dao.ListUser(searchString, page, pageSize);

            ViewBag.SearchString = searchString;

            return View(model);
        }
        //[HttpPost]
        //public JsonResult ChangeStatusCustomer(int id)
        //{
        //    var result = new SearchProduct().ChangeStatusCustomer(id);
        //    return Json(new
        //    {
        //        status = result
        //    });
        //}
    }
}