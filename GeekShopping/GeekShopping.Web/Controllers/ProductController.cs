using GeekShopping.Web.Models;
using GeekShopping.Web.Service.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GeekShopping.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
        }

        public async Task<IActionResult> ProductIndex()
        {
            var products = await _productService.FindAllProducts();
            return View(products);
        }

        public async Task<IActionResult> ProductCreate()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ProductCreate(ProductModel model)
        {
            var response = await _productService.CreateProduct(model);
            if (ModelState.IsValid)
            {
                if (response != null) return RedirectToAction(nameof(ProductIndex));
            }
            return View(model);
        }

        public async Task<IActionResult> ProductUpdate(long id)
        {
            var model = await _productService.FindProductById(id);
            if (model != null) return View(model);
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> ProductUpdate(ProductModel model)
        {
            var response = await _productService.UpdateProduct(model);
            if (ModelState.IsValid)
            {
                if (response != null) return RedirectToAction(nameof(ProductIndex));
            }
            return View(model);
        }


        public async Task<IActionResult> ProductDelete(long id)
        {
            var model = await _productService.FindProductById(id);
            if (model != null) return View(model);
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> ProductDelete(ProductModel model)
        {
            var response = await _productService.DeleteProductById(model.Id);
                if (response) return RedirectToAction(nameof(ProductIndex));
            return View(model);
        }
    }
}
