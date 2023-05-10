namespace ToffeeApplication
{
    partial class PlaceOrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            itemCatalogListView = new ListView();
            itemCatalogLabel = new Label();
            headerLabel = new Label();
            shoppingCartListView = new ListView();
            shoppingCartLabel = new Label();
            addSelectedItemButton = new Button();
            removeSelectedItemButton = new Button();
            quantityLabel = new Label();
            quantityTextBox = new TextBox();
            placeOrderButton = new Button();
            orderTotalLabel = new Label();
            orderTotalTextBox = new TextBox();
            SuspendLayout();
            // 
            // itemCatalogListView
            // 
            itemCatalogListView.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            itemCatalogListView.Location = new Point(12, 140);
            itemCatalogListView.Name = "itemCatalogListView";
            itemCatalogListView.Size = new Size(382, 477);
            itemCatalogListView.TabIndex = 0;
            itemCatalogListView.UseCompatibleStateImageBehavior = false;
            // 
            // itemCatalogLabel
            // 
            itemCatalogLabel.AutoSize = true;
            itemCatalogLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            itemCatalogLabel.ForeColor = SystemColors.HotTrack;
            itemCatalogLabel.Location = new Point(144, 100);
            itemCatalogLabel.Name = "itemCatalogLabel";
            itemCatalogLabel.Size = new Size(110, 37);
            itemCatalogLabel.TabIndex = 1;
            itemCatalogLabel.Text = "Catalog";
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.Location = new Point(12, 9);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(229, 50);
            headerLabel.TabIndex = 2;
            headerLabel.Text = "Toffee Sweets";
            // 
            // shoppingCartListView
            // 
            shoppingCartListView.BorderStyle = BorderStyle.FixedSingle;
            shoppingCartListView.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            shoppingCartListView.Location = new Point(622, 140);
            shoppingCartListView.Name = "shoppingCartListView";
            shoppingCartListView.Size = new Size(371, 477);
            shoppingCartListView.TabIndex = 3;
            shoppingCartListView.UseCompatibleStateImageBehavior = false;
            // 
            // shoppingCartLabel
            // 
            shoppingCartLabel.AutoSize = true;
            shoppingCartLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            shoppingCartLabel.ForeColor = SystemColors.HotTrack;
            shoppingCartLabel.Location = new Point(707, 100);
            shoppingCartLabel.Name = "shoppingCartLabel";
            shoppingCartLabel.Size = new Size(188, 37);
            shoppingCartLabel.TabIndex = 4;
            shoppingCartLabel.Text = "Shopping Cart";
            // 
            // addSelectedItemButton
            // 
            addSelectedItemButton.ForeColor = Color.RoyalBlue;
            addSelectedItemButton.Location = new Point(428, 262);
            addSelectedItemButton.Name = "addSelectedItemButton";
            addSelectedItemButton.Size = new Size(149, 84);
            addSelectedItemButton.TabIndex = 5;
            addSelectedItemButton.Text = "Add Selected Item";
            addSelectedItemButton.UseVisualStyleBackColor = true;
            // 
            // removeSelectedItemButton
            // 
            removeSelectedItemButton.ForeColor = Color.IndianRed;
            removeSelectedItemButton.Location = new Point(428, 385);
            removeSelectedItemButton.Name = "removeSelectedItemButton";
            removeSelectedItemButton.Size = new Size(149, 84);
            removeSelectedItemButton.TabIndex = 6;
            removeSelectedItemButton.Text = "Remove Selected Item";
            removeSelectedItemButton.UseVisualStyleBackColor = true;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.ForeColor = Color.MediumBlue;
            quantityLabel.Location = new Point(400, 192);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(98, 30);
            quantityLabel.TabIndex = 7;
            quantityLabel.Text = "Quantity:";
            // 
            // quantityTextBox
            // 
            quantityTextBox.BorderStyle = BorderStyle.FixedSingle;
            quantityTextBox.Location = new Point(504, 191);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(100, 35);
            quantityTextBox.TabIndex = 8;
            // 
            // placeOrderButton
            // 
            placeOrderButton.Location = new Point(778, 646);
            placeOrderButton.Name = "placeOrderButton";
            placeOrderButton.Size = new Size(215, 101);
            placeOrderButton.TabIndex = 9;
            placeOrderButton.Text = "Place Order";
            placeOrderButton.UseVisualStyleBackColor = true;
            // 
            // orderTotalLabel
            // 
            orderTotalLabel.AutoSize = true;
            orderTotalLabel.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            orderTotalLabel.Location = new Point(345, 676);
            orderTotalLabel.Name = "orderTotalLabel";
            orderTotalLabel.Size = new Size(153, 37);
            orderTotalLabel.TabIndex = 10;
            orderTotalLabel.Text = "Order Total";
            // 
            // orderTotalTextBox
            // 
            orderTotalTextBox.BorderStyle = BorderStyle.FixedSingle;
            orderTotalTextBox.Enabled = false;
            orderTotalTextBox.Location = new Point(504, 679);
            orderTotalTextBox.Name = "orderTotalTextBox";
            orderTotalTextBox.ReadOnly = true;
            orderTotalTextBox.Size = new Size(175, 35);
            orderTotalTextBox.TabIndex = 11;
            // 
            // PlaceOrderForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(1005, 760);
            Controls.Add(orderTotalTextBox);
            Controls.Add(orderTotalLabel);
            Controls.Add(placeOrderButton);
            Controls.Add(quantityTextBox);
            Controls.Add(quantityLabel);
            Controls.Add(removeSelectedItemButton);
            Controls.Add(addSelectedItemButton);
            Controls.Add(shoppingCartLabel);
            Controls.Add(shoppingCartListView);
            Controls.Add(headerLabel);
            Controls.Add(itemCatalogLabel);
            Controls.Add(itemCatalogListView);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "PlaceOrderForm";
            Text = "PlaceOrderForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView itemCatalogListView;
        private Label itemCatalogLabel;
        private Label headerLabel;
        private ListView shoppingCartListView;
        private Label shoppingCartLabel;
        private Button addSelectedItemButton;
        private Button removeSelectedItemButton;
        private Label quantityLabel;
        private TextBox quantityTextBox;
        private Button placeOrderButton;
        private Label orderTotalLabel;
        private TextBox orderTotalTextBox;
    }
}