using System;
using System.Collections.Generic;
using System.Linq;

namespace BT_31._10._2024.Models
{
    public class ShoppingCart
    {
        private Dictionary<string, Product> _items = new Dictionary<string, Product>();

        public void AddProduct(Product product)
        {
            if (product.Stock > 0)
            {
                if (_items.ContainsKey(product.Name))
                {
                    if (_items[product.Name].Quantity < product.Stock)
                    {
                        _items[product.Name].Quantity += 1;
                        product.Stock -= 1;
                    }
                }
                else
                {
                    _items[product.Name] = product;
                    _items[product.Name].Quantity = 1;
                    product.Stock -= 1;
                }
            }
        }

        public bool RemoveProduct(Product product)
        {
            if (_items.ContainsKey(product.Name))
            {
                _items[product.Name].Quantity -= 1;
                product.Stock += 1;

                if (_items[product.Name].Quantity <= 0)
                {
                    _items.Remove(product.Name);
                }
                return true;
            }
            return false;
        }

        public decimal GetTotalValue()
        {
            return _items.Values.Sum(p => p.Price * p.Quantity);
        }

        public int GetTotalQuantity()
        {
            return _items.Values.Sum(p => p.Quantity);
        }

        public List<Product> GetProducts()
        {
            return _items.Values.ToList();
        }

        public void ClearCart()
        {
            foreach (var product in _items.Values)
            {
                product.Quantity = 0; // Đặt lại số lượng trong giỏ hàng
            }
            _items.Clear();
        }

    }
}
