using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace WaterProject.Models
{
    public class Cart
    {
        public List<CartLineItem> Items { get; set; } = new List<CartLineItem>(); // Declaration & Instantiation

        public void AddItem(Project proj, int qty)
        {
            CartLineItem line = Items
                .Where(p => p.Project.ProjectId == proj.ProjectId)
                .FirstOrDefault();

            if (line == null)
            {
                Items.Add(new CartLineItem
                {
                    Project = proj,
                    Quantity = qty

                });
            }
            else
            {
                line.Quantity += qty;
            }
        }

        public double CalculateTotal()
        {
            double sum = Items.Sum(x => x.Quantity * 25);

            return sum;
        }
    }


    public class CartLineItem
    {
        public int LineID { get; set; }
        public Project Project { get; set; }
        public int Quantity { get; set; }

    }
}
