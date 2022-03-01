using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WaterProject.Infrastructure;

namespace WaterProject.Models
{
    public class SessionCart : Cart
    {
        public static Cart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            //Is it an old session or do we need to create a new one?
            SessionCart cart = session?.GetJson<SessionCart>("Cart") ?? new SessionCart();

            cart.Session = session;

            return cart;
        }
        
        [JsonIgnore]
        public ISession Session { get; set; }
        public override void AddItem(Project proj, int qty)
        {
            base.AddItem(proj, qty);

            Session.SetJson("Cart", this);
        }

        public override void RemoveItem(Project proj)
        {
            base.RemoveItem(proj);

            Session.SetJson("Cart", this);
        }

        public override void ClearCart()
        {
            base.ClearCart();
            Session.Remove("Cart");
        }
    }
}
