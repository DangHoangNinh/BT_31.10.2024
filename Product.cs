using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_31._10._2024.Models
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; } // Số lượng trong giỏ hàng
        public int Stock { get; set; } // Số lượng tồn kho
        public Image Image { get; set; }

        public Product(string name, decimal price, int stock, Image image)
        {
            Name = name;
            Price = price;
            Stock = stock;
            Quantity = 0; // Khởi tạo số lượng trong giỏ hàng là 0
            Image = image;
        }
    }
}