using AutoMapper;
using Catalog.API.Entities;
using EventBus.Messages.Events;

namespace Catalog.API.Mapper
{
    public class CatalogProfile:Profile
    {
        public CatalogProfile()
        {
            CreateMap<Product, ProductAddEvent>().ReverseMap();
        }
    }
}
