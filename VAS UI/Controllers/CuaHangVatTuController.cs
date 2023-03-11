using EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace VAS_UI.Controllers
{
    public class CuaHangVatTuController : Controller
    {
        // GET: CuaHangVatTu
        public ActionResult CuaHang()
        {
            List<CuaHangVatTu> CuaHangList = VAS_DBInstance.Instance.Database.CuaHangVatTu.ToList();
            return View(CuaHangList);
        }

        // GET: CuaHangVatTu/Details/5
        public ActionResult Details(Guid id)
        {
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            var CuaHang = VAS_DBInstance.Instance.Database.CuaHangVatTu.FirstOrDefault(x => x.ID_Cua_hang == id);
            if (CuaHang == null)
            {
                return HttpNotFound();
            }
            return View(CuaHang);
        }

        // GET: CuaHangVatTu/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CuaHangVatTu/Create
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

        // GET: CuaHangVatTu/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CuaHangVatTu/Edit/5
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

        // GET: CuaHangVatTu/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CuaHangVatTu/Delete/5
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
