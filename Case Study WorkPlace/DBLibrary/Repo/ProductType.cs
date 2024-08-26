﻿using DBLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLibrary.Repo
{
    public class ProductType: IProduct
    {
        private readonly ShopeaseContext _context;
        public ProductType(ShopeaseContext context)
        {
            _context = context;
        }
        public IEnumerable<Product> GetProduct()
        {
            return _context.Products
                .Include(p => p.Category)
                .Include(p => p.Inventory)
                .Include(p => p.Discounts)
                .Include(p => p.CartItems)
                .Include(p => p.WishlistItems)
                .Include(p => p.OrderItems)
                .Include(p => p.Reviews)
                .ToList();
        }
        public Product GetProductById(int id)
        {
            return _context.Products
                .Include(p => p.Category)
                .Include(p => p.Inventory)
                .Include(p => p.Discounts)
                .Include(p => p.CartItems)
                .Include(p => p.WishlistItems)
                .Include(p => p.OrderItems)
                .Include(p => p.Reviews)
                .ToList()
                .Find(p => p.ProductId==id);
        }
        public void AddProduct(Product w)
        {
            _context.Products.Add(w);
            _context.SaveChanges();
        }
        public void DeleteProduct(int id)
        {
            Product ca = _context.Products.Find(id);
            _context.Products.Remove(ca);
            _context.SaveChanges();
        }
        public void UpdateProduct(int id, Product w)
        {
            _context.Products.Update(w);
            _context.SaveChanges();
        }
    }
}
