using FormYonetim.Admin.AutofacClass;
using FormYonetim.Admin.CustomFilter;
using FormYonetimi.Core.Infrastructure;
using FormYonetimi.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormYonetim.Admin.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFormRepository _formRepository;
        public HomeController(IFormRepository formRepository)
        {
            _formRepository = formRepository;
        }

        [LoginFilter]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [LoginFilter]
        public ActionResult List()
        {
            return View(_formRepository.GetAll().OrderByDescending(x => x.FormId));
        }

        [HttpGet]
        [LoginFilter]
        public ActionResult Detay(int id)
        {
            Form detayForm = _formRepository.GetById(id);
            return View(detayForm);
        }

        [HttpPost]
        [LoginFilter]
        public ActionResult KullaniciForm(int kullaniciSayisi)
        {
            return View(kullaniciSayisi);
        }
    }
}