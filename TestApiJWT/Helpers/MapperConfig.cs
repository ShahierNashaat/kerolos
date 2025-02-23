﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApiJWT.Models;

namespace TestApiJWT.Helpers
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            this.CreateMap<Category, CategoryModel>().ReverseMap();
            this.CreateMap<Paypal, PaypalModel>().ReverseMap();
            this.CreateMap<Visa, VisaModel>().ReverseMap();
            this.CreateMap<ShoppingCartProducts, ShoppingCartProductsModel>()
                .ForMember(sh => sh.ProductMaxQuantity, src => src.MapFrom(sh => sh.Product.Quantity))
                .ReverseMap()
                .ForMember(sh => sh.Product, opt => opt.Ignore());
            //mapped when you get, not mapped when you post
            this.CreateMap<Product, ProductModel>().ReverseMap();

            this.CreateMap<FavouriteProducts, FavouriteProductsModel>().ReverseMap();
            this.CreateMap<OrderedProducts, OrderedProductsModel>().ReverseMap();
            this.CreateMap<Order, OrderModel>().ReverseMap();
            this.CreateMap<PaymentMethod, PaymentMethodModel>().ReverseMap();

        }
    }
}
