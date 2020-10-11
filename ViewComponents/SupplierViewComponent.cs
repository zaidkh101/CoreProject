using CoreProjectRemasterd.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProjectRemasterd.ViewComponents
{
    public class SupplierViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext dbContext;

        public SupplierViewComponent(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IViewComponentResult Invoke()
        {
            return View(dbContext.Suppliers.OrderByDescending(s => s.SupplierID).ToList().Take(8));
        }
    }
}
