using EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;
using VAS_UI.Logic_Functions;

namespace VAS_UI.Controllers
{
    public class DanhMucVatTuController : Controller
    {
        // GET: DanhMucVatTu
        public ActionResult VatTu()
        {
            List<DanhMucVatTu> VatTuList = VAS_DBInstance.Instance.Database.DanhMucVatTu.ToList();
            return View(VatTuList);
        }

        // GET: DanhMucVatTu/Details/5
        public ActionResult Details(Guid id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var VatTu = VAS_DBInstance.Instance.Database.DanhMucVatTu.FirstOrDefault(x => x.ID_Vat_tu == id);
            if (VatTu == null)
            {
                return HttpNotFound();
            }
            return View(VatTu);
        }

        // GET: DanhMucVatTu/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DanhMucVatTu/Create
        [HttpPost]
        public ActionResult Create(DanhMucVatTu newVatTu)
        {
            try
            {
                // TODO: Add insert logic here
                var checkDuplication = VAS_DBInstance.Instance.Database.DanhMucVatTu.FirstOrDefault(x => x.Ma_vat_tu == newVatTu.Ma_vat_tu);
                if (ModelState.IsValid)
                {
                    if (checkDuplication != null)
                    {
                        ModelState.AddModelError("Ma_vat_tu", "Mã vật tư đã tồn tại");
                    }
                    else
                    {
                        newVatTu.Thoi_gian = DateTime.Now;
                        VAS_DBInstance.Instance.Database.DanhMucVatTu.Add(newVatTu);
                        VAS_DBInstance.Instance.Database.SaveChanges();
                        return RedirectToAction("VatTu");
                    }
                }
                return View(newVatTu);
            }
            catch
            {
                return View();
            }
        }

        // GET: DanhMucVatTu/Edit/5
        public ActionResult Edit(Guid id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var VatTu = VAS_DBInstance.Instance.Database.DanhMucVatTu.FirstOrDefault(x => x.ID_Vat_tu == id);
            if (VatTu == null)
            {
                return HttpNotFound();
            }
            return View(VatTu);
        }

        // POST: DanhMucVatTu/Edit/5
        [HttpPost]
        public ActionResult Edit(DanhMucVatTu item)
        {
            try
            {
                // TODO: Add update logic here
                var VatTu = VAS_DBInstance.Instance.Database.DanhMucVatTu.FirstOrDefault(x => x.ID_Vat_tu == item.ID_Vat_tu);
                if (VatTu == null)
                {
                    return HttpNotFound();
                }
                var checkDuplication = VAS_DBInstance.Instance.Database.DanhMucVatTu.FirstOrDefault(x => x.Ma_vat_tu == item.Ma_vat_tu);
                if (checkDuplication != null)
                {
                    ModelState.AddModelError("Ma_vat_tu", "Mã vật tư đã tồn tại");
                    return View(item);
                }
                else {
                    VatTu.Ma_vat_tu = item.Ma_vat_tu;
                    VatTu.Ten_vat_tu = item.Ten_vat_tu;
                    VatTu.Chung_loai = item.Chung_loai;
                    VatTu.Quy_chuan = item.Quy_chuan;
                    VatTu.Don_vi_tinh = item.Don_vi_tinh;
                    VatTu.Ghi_chu = item.Ghi_chu;
                    VAS_DBInstance.Instance.Database.Entry(VatTu).State = System.Data.Entity.EntityState.Modified;
                    VAS_DBInstance.Instance.Database.SaveChanges();
                    return RedirectToAction("VatTu");
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: DanhMucVatTu/Delete/5
        public ActionResult Delete(Guid id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var VatTu = VAS_DBInstance.Instance.Database.DanhMucVatTu.FirstOrDefault(x => x.ID_Vat_tu == id);
            if (VatTu == null)
            {
                return HttpNotFound();
            }
            return View(VatTu);
        }

        // POST: DanhMucVatTu/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(Guid id)
        {
            try
            {
                //TODO: Add delete logic here

                var VatTu = VAS_DBInstance.Instance.Database.DanhMucVatTu.FirstOrDefault(x => x.ID_Vat_tu == id);
                VAS_DBInstance.Instance.Database.BaoGiaVatTu.RemoveRange(VAS_DBInstance.Instance.Database.BaoGiaVatTu.Where(x => x.ID_Vat_tu == id));
                VAS_DBInstance.Instance.Database.DanhMucVatTu.Remove(VatTu);
                VAS_DBInstance.Instance.Database.SaveChanges();
                return RedirectToAction("VatTu");
            }
            catch
            {
                return View();
            }
        }
    }
}
