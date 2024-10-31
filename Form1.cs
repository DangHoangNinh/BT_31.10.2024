using BT_31._10._2024.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BT_31._10._2024
{
    public partial class Form1 : Form
    {
        private List<Product> _products;      // Danh sách sản phẩm dùng List
        private ShoppingCart _shoppingCart;   // Giỏ hàng dùng Dictionary trong ShoppingCart

        public Form1()
        {
            InitializeComponent();
            InitializeProducts();
            _shoppingCart = new ShoppingCart();
            LoadProductsToUI();
        }

        private void InitializeProducts()
        {
            _products = new List<Product>
            {
                new Product("Áo thun", 100000, 100, null),
                new Product("Quần jeans", 200000, 100, null),
                new Product("Giày thể thao", 300000, 100, null),
            };
        }

        private void LoadProductsToUI()
        {
            // Hiển thị danh sách sản phẩm lên giao diện
            lvProducts.Items.Clear();
            foreach (var product in _products)
            {
                ListViewItem item = new ListViewItem(product.Name);
                item.SubItems.Add(product.Price.ToString("C"));
                item.SubItems.Add(product.Stock.ToString());
                item.Tag = product;
                lvProducts.Items.Add(item); // Thêm vào ListView hiển thị sản phẩm
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            decimal total = _shoppingCart.GetTotalValue();
            MessageBox.Show($"Tổng giá trị đơn hàng: {total:C}\nCảm ơn bạn đã mua sắm!");
            _shoppingCart.ClearCart();
            UpdateCartUI();
            UpdateProductUI();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (lvProducts.SelectedItems.Count > 0)
            {
                var selectedProduct = (Product)lvProducts.SelectedItems[0].Tag;
                _shoppingCart.AddProduct(selectedProduct);
                UpdateProductUI();
                UpdateCartUI();
            }
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (lvCart.SelectedItems.Count > 0)
            {
                var selectedProduct = (Product)lvCart.SelectedItems[0].Tag;
                _shoppingCart.RemoveProduct(selectedProduct);
                UpdateProductUI();
                UpdateCartUI();
            }
        }

        private void UpdateCartUI()
        {
            lvCart.Items.Clear();
            foreach (var product in _shoppingCart.GetProducts())
            {
                ListViewItem item = new ListViewItem(product.Name);
                item.SubItems.Add(product.Price.ToString("C"));
                item.SubItems.Add(product.Quantity.ToString());
                item.SubItems.Add((product.Price * product.Quantity).ToString("C"));
                item.Tag = product;
                lvCart.Items.Add(item);
            }

            lblTotalQuantity.Text = $"Tổng số lượng: {_shoppingCart.GetTotalQuantity()}";
            lblTotalValue.Text = $"Tổng giá trị: {_shoppingCart.GetTotalValue():C}";
        }

        private void UpdateProductUI()
        {
            lvProducts.Items.Clear();
            foreach (var product in _products)
            {
                ListViewItem item = new ListViewItem(product.Name);
                item.SubItems.Add(product.Price.ToString("C"));
                item.SubItems.Add(product.Stock.ToString());
                item.Tag = product;
                lvProducts.Items.Add(item);
            }
        }
    }
}
