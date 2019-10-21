using Model.method;
using Project.Areas.Admin.Models;
using Project.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                
                var dao = new UserMethod();
                var result = dao.Login(model.UserName, Encryptor.MD5Hash(model.Password), true);
                if (result == 1)
                {
                    var user = dao.GetById(model.UserName);
                    var usersession = new UserLogin();
                    usersession.UserName = user.UserName;
                    usersession.UserID = user.ID;
                    //usersession.GroupID = user.GroupID;
                    //var listcredentials = dao.getlistcredential(model.username);

                    //Session.Add(CommonConstants.SESSION_CREDENTIALS, listCredentials);
                    Session.Add(CommonConstants.USER_SESSION, usersession);
                    return RedirectToAction("Index", "Home");
                }
                else if (result == 0)
                {
                    ModelState.AddModelError("", "Tài khoản không tồn tại.");
                }
                else if (result == -1)
                {
                    ModelState.AddModelError("", "Tài khoản đang bị khoá.");
                }
                else if (result == -2)
                {
                    ModelState.AddModelError("", "Mật khẩu không đúng.");
                }
                else if (result == -3)
                {
                    ModelState.AddModelError("", "Tài khoản của bạn không có quyền đăng nhập.");
                }
                else
                {
                    ModelState.AddModelError("", "đăng nhập không đúng.");
                }
            }
            return View("Index");
        }
    }
}