using EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;

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
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var VatTu = VAS_DBInstance.Instance.Database.DanhMucVatTu.FirstOrDefault(x => x.Ma_vat_tu == id);
            return View(VatTu);
        }

        // GET: DanhMucVatTu/Create
        public ActionResult Create()
        {
            #region ViewBag
            var quyChuan = VAS_DBInstance.Instance.Database.DanhMucVatTu.Select(x => x.Quy_chuan.ToString()).Distinct().ToList();
            var QuyChuan = DropDownList.DdList(quyChuan);
            ViewBag.QuyChuanList = QuyChuan;

            var chungLoai = VAS_DBInstance.Instance.Database.DanhMucVatTu.Select(x => x.Chung_loai.ToString()).Distinct().ToList();
            var ChungLoai = DropDownList.DdList(chungLoai);
            ViewBag.ChungLoaiList = ChungLoai;

            var donVi = VAS_DBInstance.Instance.Database.DanhMucVatTu.Select(x => x.Don_vi_tinh.ToString()).Distinct().ToList();
            var DonVi = DropDownList.DdList(donVi);
            ViewBag.DonViList = DonVi;
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
                newVatTu.Ma_vat_tu = StringConvert.convertToUnSign3(newVatTu.Ten_vat_tu).ToUpper().Replace(" ", "");
                if (!(newVatTu.Quy_chuan is null)) {
                    newVatTu.Ma_vat_tu += StringConvert.convertToUnSign3(newVatTu.Quy_chuan).ToUpper().Replace(" ", "");
                };
                newVatTu.Thoi_gian = DateTime.Now;
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
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var VatTu = VAS_DBInstance.Instance.Database.DanhMucVatTu.FirstOrDefault(x => x.Ma_vat_tu == id);
            #region ViewBag
            var quyChuan = VAS_DBInstance.Instance.Database.DanhMucVatTu.Select(x => x.Quy_chuan.ToString()).Distinct().ToList();
            var QuyChuan = DropDownList.DdList(quyChuan);
            ViewBag.QuyChuanList = QuyChuan;

            var chungLoai = VAS_DBInstance.Instance.Database.DanhMucVatTu.Select(x => x.Chung_loai.ToString()).Distinct().ToList();
            var ChungLoai = DropDownList.DdList(chungLoai);
            ViewBag.ChungLoaiList = ChungLoai;

            var donVi = VAS_DBInstance.Instance.Database.DanhMucVatTu.Select(x => x.Don_vi_tinh.ToString()).Distinct().ToList();
            var DonVi = DropDownList.DdList(donVi);
            ViewBag.DonViList = DonVi;
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
                var VatTu = VAS_DBInstance.Instance.Database.DanhMucVatTu.FirstOrDefault(x => x.Ma_vat_tu == item.Ma_vat_tu);
                VatTu.Ten_vat_tu = item.Ten_vat_tu;
                VatTu.Chung_loai = item.Chung_loai;
                VatTu.Quy_chuan = item.Quy_chuan;
                if (!(item.Quy_chuan is null))
                {
                    VatTu.Ma_vat_tu += StringConvert.convertToUnSign3(item.Quy_chuan).ToUpper().Replace(" ", "");
                };
                VatTu.Don_vi_tinh = item.Don_vi_tinh;
                VatTu.Ghi_chu = item.Ghi_chu;
                VatTu.Thoi_gian = DateTime.Now;
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
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var VatTu = VAS_DBInstance.Instance.Database.DanhMucVatTu.FirstOrDefault(x => x.Ma_vat_tu == id);
            if (VatTu == null)
            {
                return HttpNotFound();
            }
            return View(VatTu);
        }

        // POST: DanhMucVatTu/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(string id)
        {
            try
            {
                //TODO: Add delete logic here

                var VatTu = VAS_DBInstance.Instance.Database.DanhMucVatTu.FirstOrDefault(x => x.Ma_vat_tu == id);
                VAS_DBInstance.Instance.Database.BaoGiaVatTu.RemoveRange(VAS_DBInstance.Instance.Database.BaoGiaVatTu.Where(x => x.Ma_vat_tu == id));
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
