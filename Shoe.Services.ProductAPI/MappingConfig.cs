using AutoMapper;
using Microsoft.EntityFrameworkCore.Metadata;
using Shoe.Services.ProductAPI.Models;
using Shoe.Services.ProductAPI.Models.Dto;

namespace Shoe.Services.ProductAPI
{
	public class MappingConfig
	{
		public static MapperConfiguration RegisterMaps()
		{
			var mappingConfig = new MapperConfiguration(config => 
			{ 
				config.CreateMap<ProductDto, Product>();
				config.CreateMap<Product, ProductDto>();
			});

			return mappingConfig;
		}
	}
}
