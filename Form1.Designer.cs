namespace BT_31._10._2024
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnAddToCart = new Button();
            btnRemoveFromCart = new Button();
            btnCheckout = new Button();
            lvProducts = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            lvCart = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            lblTotalQuantity = new Label();
            lblTotalValue = new Label();
            imageListProducts = new ImageList(components);
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnAddToCart
            // 
            btnAddToCart.Location = new Point(23, 286);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(160, 42);
            btnAddToCart.TabIndex = 2;
            btnAddToCart.Text = "Thêm vào giỏ hàng";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // btnRemoveFromCart
            // 
            btnRemoveFromCart.Location = new Point(297, 286);
            btnRemoveFromCart.Name = "btnRemoveFromCart";
            btnRemoveFromCart.Size = new Size(160, 42);
            btnRemoveFromCart.TabIndex = 3;
            btnRemoveFromCart.Text = "Xóa khỏi giỏ hàng";
            btnRemoveFromCart.UseVisualStyleBackColor = true;
            btnRemoveFromCart.Click += btnRemoveFromCart_Click;
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new Point(850, 359);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(160, 42);
            btnCheckout.TabIndex = 4;
            btnCheckout.Text = "Thanh toán";
            btnCheckout.UseVisualStyleBackColor = true;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // lvProducts
            // 
            lvProducts.BorderStyle = BorderStyle.FixedSingle;
            lvProducts.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvProducts.FullRowSelect = true;
            lvProducts.GridLines = true;
            lvProducts.Location = new Point(23, 48);
            lvProducts.Name = "lvProducts";
            lvProducts.Size = new Size(434, 215);
            lvProducts.TabIndex = 7;
            lvProducts.UseCompatibleStateImageBehavior = false;
            lvProducts.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên sản phẩm";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.DisplayIndex = 2;
            columnHeader2.Text = "Giá tiền";
            columnHeader2.Width = 234;
            // 
            // columnHeader3
            // 
            columnHeader3.DisplayIndex = 1;
            columnHeader3.Text = "Số lượng";
            columnHeader3.Width = 80;
            // 
            // lvCart
            // 
            lvCart.BorderStyle = BorderStyle.FixedSingle;
            lvCart.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            lvCart.FullRowSelect = true;
            lvCart.GridLines = true;
            lvCart.Location = new Point(499, 48);
            lvCart.Name = "lvCart";
            lvCart.Size = new Size(553, 215);
            lvCart.TabIndex = 8;
            lvCart.UseCompatibleStateImageBehavior = false;
            lvCart.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Tên sản phẩm";
            columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.DisplayIndex = 2;
            columnHeader5.Text = "Giá tiền";
            columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            columnHeader6.DisplayIndex = 1;
            columnHeader6.Text = "Số lượng";
            columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Thành tiền";
            columnHeader7.Width = 233;
            // 
            // lblTotalQuantity
            // 
            lblTotalQuantity.AutoSize = true;
            lblTotalQuantity.Location = new Point(547, 297);
            lblTotalQuantity.Name = "lblTotalQuantity";
            lblTotalQuantity.Size = new Size(242, 20);
            lblTotalQuantity.TabIndex = 9;
            lblTotalQuantity.Text = "Tổng số lượng sản phẩm trong giỏ:";
            // 
            // lblTotalValue
            // 
            lblTotalValue.AutoSize = true;
            lblTotalValue.Location = new Point(850, 297);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(75, 20);
            lblTotalValue.TabIndex = 10;
            lblTotalValue.Text = "Tổng tiền:";
            // 
            // imageListProducts
            // 
            imageListProducts.ColorDepth = ColorDepth.Depth32Bit;
            imageListProducts.ImageSize = new Size(100, 100);
            imageListProducts.TransparentColor = Color.Transparent;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(499, 9);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 11;
            label1.Text = "Giỏ hàng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 9);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 12;
            label2.Text = "Cửa hàng:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 411);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTotalValue);
            Controls.Add(lblTotalQuantity);
            Controls.Add(lvCart);
            Controls.Add(lvProducts);
            Controls.Add(btnCheckout);
            Controls.Add(btnRemoveFromCart);
            Controls.Add(btnAddToCart);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAddToCart;
        private Button btnRemoveFromCart;
        private Button btnCheckout;
        private ListView lvProducts;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ListView lvCart;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Label lblTotalQuantity;
        private Label lblTotalValue;
        private ColumnHeader columnHeader7;
        private ImageList imageListProducts;
        private Label label1;
        private Label label2;
    }
}
