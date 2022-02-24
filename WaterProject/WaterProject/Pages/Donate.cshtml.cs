using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WaterProject.Infrastructure;
using WaterProject.Models;

namespace WaterProject.Pages
{
    public class DonateModel : PageModel
    {
        private IWaterProjectRepository repo { get; set; }

        public DonateModel (IWaterProjectRepository temp)
        {
            repo = temp;
        }

        public Cart cart { get; set; }
        
        public void OnGet()
        {
            cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
        }

        public IActionResult OnPost(int projectId)
        {
            Project p = repo.Projects.FirstOrDefault(x => x.ProjectId == projectId);

            cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
            cart.AddItem(p, 1);

            HttpContext.Session.SetJson("cart", cart);

            return RedirectToPage();
        }
    }
}
