using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Guarantee.Models;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Guarantee;

namespace Guarantee.Controllers
{
    public class HomeController : Controller
    {
        GuarContext db;
        public HomeController(GuarContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.TheGuarantors.ToList());
        }
        [HttpGet]
        public IActionResult Buy(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            ViewBag.GuaranteeAgreementId = id;
            return View();
        }
        [HttpPost]
        public string Buy(GuaranteeAgreement guaranteeAgreement)
        {
            db.GuaranteeAgreements.Add(guaranteeAgreement);
            // сохраняем в бд все изменения
            db.SaveChanges();
            return "Спасибо, " + guaranteeAgreement.GuaranteeAgreementId + ", за покупку!";
        }

    }
}
