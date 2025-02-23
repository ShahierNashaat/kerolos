﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestApiJWT.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        
    }

    public class PaypalModel
    {
        public int Id { get; set; }
        [Required]
        public string Account { get; set; }
    }

    public class VisaModel
    {
        public int Id { get; set; }
        [Required]
        public long Number { get; set; }
        public string Expire { get; set; }
        public int SequreCode { get; set; }
    }

    public class ShoppingCartProductsModel
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int productId { get; set; }
        public string UserId { get; set; }
        public string ProductImage { get; set; }
        public double ProductPrice { get; set; }
        public string ProductName { get; set; }
        public string ProductMaxQuantity { get; set; }

    }

    //public class ShoppingCartModel
    //{
    //    public string Id { get; set; }
    //    public double totalPrice { get; set; }
    //}

    public class ProductModel
    {
        public int Id { get; set; }
        [Required, MinLength(3)]
        public string Name { get; set; }
        public string Details { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public int Quantity { get; set; }
        public Nullable<int> CategoryId { get; set; }
    }
    public class FavouriteProductsModel
    {
        public int Id { get; set; }

        public string userId { get; set; }

        public int productId { get; set; }

        public ProductModel product { get; set; }

    }

    public class OrderedProductsModel
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        
        public int productId { get; set; }
        
        public int orderId { get; set; }
    }

    public class OrderModel
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public double totalPrice { get; set; }
        public string userId { get; set; }
        public virtual PaymentMethodModel PaymentMethod { get; set; }


    }

    public class PaymentMethodModel
    {
        public int Id { get; set; }
        public string Method { get; set; }
    }


}
