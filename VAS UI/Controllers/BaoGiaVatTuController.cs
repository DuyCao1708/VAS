using EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VAS_UI.Controllers
{
    public class BaoGiaVatTuController : Controller
    {
        // GET: BaoGiaVatTu
        public ActionResult BaoGia()
        {
            List<BaoGiaVatTu> BaoGiaList = VAS_DBInstance.Instance.Database.BaoGiaVatTu.ToList();
            return View(BaoGiaList);
        }

        // GET: BaoGiaVatTu/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BaoGiaVatTu/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BaoGiaVatTu/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: BaoGiaVatTu/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BaoGiaVatTu/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: BaoGiaVatTu/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BaoGiaVatTu/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
