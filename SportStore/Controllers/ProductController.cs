using Microsoft.AspNetCore.Mvc;
using SportsStore.Models.ViewModels;
using SportStore.Models;
using SportStore.Models.ViewModel;
using System.ComponentModel;

namespace SportStore.Controllers
{
    public class ProductController : Controller
    {
      private IProductRepository repository;
        public int PageSize = 4; // number of products to display on each page 
        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }
        public ViewResult List(string category, int page = 1)
            => View(new ProductsListViewModel
            {
                Products = repository.Products.Where(p=> category == null || p.Category == category).OrderBy(p => p.ProductID).Skip((page - 1) * pageSize).Take(pageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = category == null ?
                    repository.Products.Count() :
                    repository.Products.Where(e =>
                    e.Category == category).Count()
                },
                CurrentCategory = category
            });
    }
}
