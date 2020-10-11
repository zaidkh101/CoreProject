using CoreProjectRemasterd.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProjectRemasterd.ViewComponents
{
    public class ProductViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext dbContext;

        public ProductViewComponent(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IViewComponentResult Invoke()
        {
            return View(dbContext.Products.ToList());
        }

    }
}
