using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portal.Models;
using BOL;
using BLL;

namespace Portal.Controllers;
//namespace System.Collections;
public class ProductsController : Controller
{
    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }

   public IActionResult Index(){
        CatalogueManager mgr = new CatalogueManager();
        List<Product> product = mgr.GetAllProducts();
        ViewData ["allproducts"]  = product;
        return View();
   }
}