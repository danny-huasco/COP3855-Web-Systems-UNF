using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Libreria.Models;
namespace Libreria.Controllers
{
    public class CartController : Controller
    {
        
        [Route("/Cart")]
        public ActionResult Index()
        {
            Cart cart = new Cart();
            cart.GetItems();
            var items = cart.Items;
            ViewBag.Items = items;
            var subt = cart.GetTotalPrice();
            ViewBag.Sub = subt;

            return View();
        }

        [Route("/Cart/add/{isbn?}")]
        public ActionResult AddToCart(string id)
        {
            Cart cart = new Cart();
            cart.AddItem(id);
            cart.GetItems();
            ViewBag.Items = cart.Items;
            var subt = cart.GetTotalPrice();
            ViewBag.Sub = subt;
            return View("index");            
        }

        [Route("Cart/remove/{isbn?}")]
        public ActionResult RemoveItem(string id)
        {
            Cart cart = new Cart();
            cart.RemoveItem(id);
            cart.GetItems();
            ViewBag.Items = cart.Items;
            var subt = cart.GetTotalPrice();
            ViewBag.Sub = subt;
            return View("index");
        }
    }
}
