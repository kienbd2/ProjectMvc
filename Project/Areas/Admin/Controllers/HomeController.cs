using Model.method;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace Project.Areas.Admin.Controllers
{
    public class HomeController : BaseController
    {
        // GET: Admin/Home
        public ActionResult Index(string searchString, int page = 1, int pageSize = 10)
        {
            var dao = new SearchProduct();
            var model = dao.ListAllPaging(searchString, page, pageSize);

            ViewBag.SearchString = searchString;

            return View(model);
        }
        //[HttpPost]
        //public JsonResult ChangeStatus(int id)
        //{
        //    var result = new SearchProduct().ChangeStatus(id);
        //    return Json(new
        //    {
        //        status = result
        //    });
        //}

    }
}