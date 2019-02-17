using FormYonetimi.Core.Infrastructure;
using FormYonetimi.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormYonetim.Admin.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAdminRepository _adminRepository;

        public AccountController(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormYonetimi.Data.Model.Admin admin)
        {
            var kullaniciVarmi = _adminRepository.GetMany(x => x.UserName == admin.UserName && x.Password == admin.Password).SingleOrDefault();
            if (kullaniciVarmi != null)
            {
                Session["UserName"] = kullaniciVarmi.UserName;
                Session["AdminId"] = kullaniciVarmi.AdminId;
                return RedirectToAction("List", "Home");
            }
            ViewBag.Mesaj = "Kullanıcı Bulunamadı";
            return View();
        }
    }
}