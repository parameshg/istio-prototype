using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Northwind.Services.Product.Model;

namespace NorthWind.Services.Product.Controllers
{
    [Route("")]
    public class ProductController : Controller
    {
        #region Seed Products

        private static List<ProductDetail> Products { get; }

        static ProductController()
        {
            Products = new List<ProductDetail>()
            {
                // Chocolate
                new ProductDetail() { Id = Guid.NewGuid(), Name = "Choceur Coffee Cream Block Chocolate 200g", Price = 2.69 },
                new ProductDetail() { Id = Guid.NewGuid(), Name = "Choceur Milk Chocolate Sticks 200g", Price = 2.79 },
                new ProductDetail() { Id = Guid.NewGuid(), Name = "Choceur Mountain Bar Chocolate 100g", Price = 1.99 },
                new ProductDetail() { Id = Guid.NewGuid(), Name = "Dark Mini Chocolate Bars 5 x 40g", Price = 2.99 },
                new ProductDetail() { Id = Guid.NewGuid(), Name = "White Mini Chocolate Bars 5 x 40g", Price = 2.39 },

                // Cosmetics
                new ProductDetail() { Id = Guid.NewGuid(), Name = "Lacura Essentials BB Cream SPF-15 50ml", Price = 6.69 },
                new ProductDetail() { Id = Guid.NewGuid(), Name = "Lacura Essentials Caring Cleansing Gel 150ml", Price = 3.69 },
                new ProductDetail() { Id = Guid.NewGuid(), Name = "Lacura Essentials Make-up Rounds 80pk", Price = 1.39 },
                new ProductDetail() { Id = Guid.NewGuid(), Name = "Lacura Skin Science Renew Day Cream SPF-15 50ml", Price = 6.99 },
                new ProductDetail() { Id = Guid.NewGuid(), Name = "Lacura Skin Science Revive Hyaluronic Gel 30ml", Price = 9.99 },

                // Liquor
                new ProductDetail() { Id = Guid.NewGuid(), Name = "Blackstone Paddock Margaret River Cabernet Sauvign", Price = 17.99 },
                new ProductDetail() { Id = Guid.NewGuid(), Name = "Veuve Monsigny Brut Champagne", Price = 24.99 },
                new ProductDetail() { Id = Guid.NewGuid(), Name = "Storm Brewing CO Premium Light Lager 6 x 330ml", Price = 7.99 },
                new ProductDetail() { Id = Guid.NewGuid(), Name = "Highland Earl Blended Scotch Whiskey 700ml", Price = 28.99 },
                new ProductDetail() { Id = Guid.NewGuid(), Name = "Darleys London Style Gin 700ml", Price = 26.99 },

                // Laundry
                new ProductDetail() { Id = Guid.NewGuid(), Name = "Trimat Advanced Laundry Liquid Regular 1L", Price = 3.99 },
                new ProductDetail() { Id = Guid.NewGuid(), Name = "Almat Laundry Powder Concentrate 2kg", Price = 4.99 },
                new ProductDetail() { Id = Guid.NewGuid(), Name = "Di San Pre-wash Stain Remover 500ml Degreaser", Price = 1.25 },
                new ProductDetail() { Id = Guid.NewGuid(), Name = "Anco Soft Fabric Softener 4x Concentrate 1L", Price = 3.49 },
                new ProductDetail() { Id = Guid.NewGuid(), Name = "Laundrite Laundry Powder 4kg", Price = 3.69 },
            };
        }

        #endregion Seed Products

        [HttpGet("products/{id}")]
        public ProductDetail GetProductById(string id)
        {
            ProductDetail result = null;

            try
            {
                result = Products.SingleOrDefault(i => i.Id.Equals(Guid.Parse(id)));
            }
            catch
            {
                result = null;
            }

            return result;
        }

        [HttpGet("search")]
        public List<ProductDetail> SearchProducts(string q)
        {
            var result = new List<ProductDetail>();

            try
            {
                if (!string.IsNullOrEmpty(q))
                    result.AddRange(Products.Where(i => i.Name.ToLower().Contains(q.ToLower())).ToList());
            }
            catch
            {
                result = null;
            }

            return result;
        }
    }
}