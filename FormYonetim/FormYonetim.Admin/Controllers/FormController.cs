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
    public class FormController : Controller
    {
        // GET: Form
        private readonly IFormRepository _formRepository;
        private readonly IKullaniciRepository _kullaniciRepository;
        private readonly IAdminRepository _adminRepository;

        public FormController(IFormRepository formRepository)
        {
            _formRepository = formRepository;
        }

        [LoginFilter]
        public ActionResult FormEkle()
        {
            return View();
        }

        [LoginFilter]
        [HttpPost]
        public ActionResult FormEkle(Form form)
        {
            form.CreatedAt = DateTime.Now;
            string id = Session["AdminId"].ToString();
            form.CreatedById = Convert.ToInt32(id);

            _formRepository.Insert(form);

            _formRepository.Save();
            return View();
        }
    }
}