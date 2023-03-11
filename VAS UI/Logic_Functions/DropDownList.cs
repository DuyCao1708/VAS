using EF;
using System;
using System.Collections.Generic;
using System.Net;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Linq.Expressions;

namespace VAS_UI.Logic_Functions
{
    public class DropDownList
    {
        public static IList<SelectListItem> GetData<TEntity>(DbSet<TEntity> tableTarget, Expression<Func<TEntity, string>> selectColumn) where TEntity : class
        {
            return tableTarget.Select(selectColumn).Distinct().Select(item => new SelectListItem { Value = item, Text = item }).ToList();
        }
    }
}