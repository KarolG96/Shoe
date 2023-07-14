﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Shoe.Web.Models;
using Shoe.Web.Services.IServices;

namespace Shoe.Web.Controllers
{
	public class ProductController : Controller
	{
		private readonly IProductService _productService;
		public ProductController(IProductService productService)
		{
			_productService = productService;
		}

		public async Task<IActionResult> ProductIndex()
		{
			List<ProductDto> list = new();
			var response = await _productService.GetAllProductsAsync<ResponseDto>();
			if(response != null && response.IsSuccess)
			{
				list = JsonConvert.DeserializeObject<List<ProductDto>>(Convert.ToString(response.Result));
			}
			return View(list);
		}
	}
}
