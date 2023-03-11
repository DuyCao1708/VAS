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
            #region ViewBag
            ViewBag.QuyChuanList = DropDownList.GetData(VAS_DBInstance.Instance.Database.DanhMucVatTu, item => item.Quy_chuan);
            ViewBag.ChungLoaiList = DropDownList.GetData(VAS_DBInstance.Instance.Database.DanhMucVatTu, item => item.Chung_loai);
            ViewBag.DonViList = DropDownList.GetData(VAS_DBInstance.Instance.Database.DanhMucVatTu, item => item.Don_vi_tinh);
            #endregion
            return View();
        }

        // POST: DanhMucVatTu/Create
        [HttpPost]
        public ActionResult Create(DanhMucVatTu newVatTu)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    VAS_DBInstance.Instance.Database.DanhMucVatTu.Add(newVatTu);
                    VAS_DBInstance.Instance.Database.SaveChanges();

                    return RedirectToAction("VatTu");
                }
                else
                {
                    return View(newVatTu);
                }
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
            #region ViewBag
            ViewBag.QuyChuanList = DropDownList.GetData(VAS_DBInstance.Instance.Database.DanhMucVatTu, item => item.Quy_chuan);
            ViewBag.ChungLoaiList = DropDownList.GetData(VAS_DBInstance.Instance.Database.DanhMucVatTu, item => item.Chung_loai);
            ViewBag.DonViList = DropDownList.GetData(VAS_DBInstance.Instance.Database.DanhMucVatTu, item => item.Don_vi_tinh);
            #endregion
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
