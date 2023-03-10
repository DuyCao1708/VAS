using EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VAS_UI.Controllers
{
    public class KhoController : Controller
    {
        // GET: Kho
        public ActionResult TongKho()
        {
            List<NguyenVatLieu> NguyenVatLieuList = VAS_DBInstance.Instance.Database.NguyenVatLieu.ToList();
            return View(NguyenVatLieuList);
        }

        // GET: Kho/Details/5
        public ActionResult Details(string id)
        {
            var NguyenVatLieu = VAS_DBInstance.Instance.Database.NguyenVatLieu.FirstOrDefault(x => x.Ma_nguyen_vat_lieu == id);
            return View(NguyenVatLieu);
        }

        // GET: Kho/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Kho/Create
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

        // GET: Kho/Edit/5
        public ActionResult Edit(string id)
        {
            var NguyenVatLieu = VAS_DBInstance.Instance.Database.NguyenVatLieu.FirstOrDefault(x => x.Ma_nguyen_vat_lieu == id);

            #region ViewBag
            var phanLoai = VAS_DBInstance.Instance.Database.NguyenVatLieu.Select(x => x.Phan_loai.ToString()).Distinct().ToList();
            List<SelectListItem> PhanLoai = new List<SelectListItem>();
            foreach (string loai in phanLoai)
            {
                PhanLoai.Add(new SelectListItem
                {
                    Text = loai,
                    Value = loai,
                });
            };
            ViewBag.PhanloaiList = PhanLoai;
            #endregion

            return View(NguyenVatLieu);
        }

        // POST: Kho/Edit/5
        [HttpPost]
        public ActionResult Edit(NguyenVatLieu item)
        {
            try
            {
                // TODO: Add update logic here
                var NguyenVatLieu = VAS_DBInstance.Instance.Database.NguyenVatLieu.FirstOrDefault(x => x.Ma_nguyen_vat_lieu == item.Ma_nguyen_vat_lieu);

                NguyenVatLieu.Ten = item.Ten;
                NguyenVatLieu.Phan_loai = item.Phan_loai;
                NguyenVatLieu.Nha_san_xuat = item.Nha_san_xuat;
                NguyenVatLieu.Ton_kho = item.Ton_kho;
                NguyenVatLieu.Gia_don_vi = item.Gia_don_vi;
                NguyenVatLieu.Gia_tri_tong = (item.Gia_don_vi) * (item.Ton_kho);
                NguyenVatLieu.Mo_ta = item.Mo_ta;
                NguyenVatLieu.Thoi_gian = DateTime.Now;
                VAS_DBInstance.Instance.Database.Entry(NguyenVatLieu).State = System.Data.Entity.EntityState.Modified;
                VAS_DBInstance.Instance.Database.SaveChanges();
                return RedirectToAction("TongKho");

            }
            catch
            {
                return View();
            }
        }

        // GET: Kho/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Kho/Delete/5
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
