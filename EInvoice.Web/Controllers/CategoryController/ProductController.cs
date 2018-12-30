using AutoMapper;
using EInvoice.Data.Data;
using EInvoice.Data.Services;
using EInvoice.Data.Utilities;
using EInvoice.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace EInvoice.Web.Controllers.CategoryController
{
    [PermissionLogin]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IUnitService _unitService;

        public ProductController(IProductService productService, IUnitService unitService)
        {
            _productService = productService;
            _unitService = unitService;
        }

        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public IEnumerable<Unit> GetAllUnit()
        {
            return _unitService.GetAll();
        }

        [ValidateInput(false)]
        public ActionResult ProductPartial()
        {
            var model = Mapper.Map<List<ProductViewModel>>(_productService.GetAllDesProduct());
            return PartialView("_ProductPartial", model);
        }

        [HttpPost, ValidateInput(true)]
        public void Create(ProductViewModel product)
        {
            try
            {
                var newProduct = Mapper.Map<Product>(product);

                _productService.Add(newProduct);
            }
            catch (Exception e)
            {
                ViewData["EditError"] = e.Message;
            }
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult ProductPartialAddNew(Product product)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _productService.AddProduct(product);
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";

            return ProductPartial();
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult ProductPartialUpdate(Product product)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _productService.Update(product);
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";

            return ProductPartial();
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult ProductPartialDelete(int id)
        {
            if (id >= 0)
            {
                try
                {
                    _productService.DeleteProduct(id);
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }

            return ProductPartial();
        }

        [HttpPost]
        public JsonResult GetProductByCode(string searchKey)
        {
            ////var products = Mapper.Map<List<ProductViewModel>>(_productService.GetProductsSource());
            //var searchProducts1 = products.Where(x => x.Code.Contains(searchKey) && x.isDel == false).ToList();
            //searchProducts1.ForEach(_ => _.Unit.Products = null);
            var productsByCode = Mapper.Map<List<ProductViewModel>>
                (_productService.GetProductByCode(searchKey));
            productsByCode.ForEach(_ => _.Unit.Products = null);
            return Json(productsByCode, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult GetProductByName(string searchKey)
        {
            var productsByName = Mapper.Map<List<ProductViewModel>>
                (_productService.GetProductByName(searchKey));
            productsByName.ForEach(_ => _.Unit.Products = null);
            return Json(productsByName, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult CheckCode(string searchKey)
        {
            var customers = _productService.GetAll();
            var isAny = customers.Any(x => x.Code == searchKey && x.isDel == false);
            if (!isAny)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(true, JsonRequestBehavior.AllowGet);
            }
        }

        public List<SelectListItem> GetUnitName()
        {
            var untiName = _unitService.GetAll();
            var listUnitName = new List<SelectListItem>();
            foreach (var item in untiName)
            {
                var payment = new SelectListItem
                {
                    Text = item.Name,
                    Value = item.ID.ToString()
                };
                listUnitName.Add(payment);
            }

            return listUnitName;
        }
    }
}