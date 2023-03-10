using EF;
using System;
using System.Collections.Generic;
using System.Net;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VAS_UI.Controllers
{
    public class DropDownList
    {
        public static List<SelectListItem> DdList(List<string> ListItem)
        {
            //var ListItem = VAS_DBInstance.Instance.Database.DanhMucVatTu.Select(x => x.Quy_chuan.ToString()).Distinct().ToList();
            List<SelectListItem> List = new List<SelectListItem>();
            foreach (string item in ListItem)
            {
                List.Add(new SelectListItem
                {
                    Text = item,
                    Value = item,
                });
            };
            return List;
        }
    }    
}