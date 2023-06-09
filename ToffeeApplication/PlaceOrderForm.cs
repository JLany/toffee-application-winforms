﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToffeeSystemPrototype.AccountComponent;
using ToffeeSystemPrototype;
using ToffeeSystemPrototype.AccountComponent;
using ToffeeSystemPrototype.InventoryComponent;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ToffeeApplication
{
    public partial class PlaceOrderForm : Form
    {
        private UserSession CurrentSession { get; set; }
        private Dictionary<int, Item> inventoryItems;

        /// <summary>
        /// Stores <see cref="Item"/>, SelectedQuantity pairs
        /// </summary>
        private Dictionary<Item, int> shoppingCartItems = new Dictionary<Item, int>(); 

        public PlaceOrderForm(UserSession session)
        {
            InitializeComponent();

            CurrentSession = session;
            inventoryItems = Program.Inventory.GetItemCatalog();

            // set up catalog
            var catalog = this.itemCatalogListView;
            var cart = this.shoppingCartListView;

            SetUpItemCatalog();

            // set up shopping cart
            cart.View = View.Details;
            cart.GridLines = true;
            cart.FullRowSelect = true;
            cart.Columns.Add("ID").Width = 40;
            cart.Columns.Add("Name").Width = 100;
            cart.Columns.Add("Sale Price").Width = 120;
            cart.Columns.Add("Quantity").Width = 70;
            cart.MultiSelect = false;

            // populate catalog
            PopulateItemCatalog();
            

            this.addSelectedItemButton.Click += AddSelectedItemButton_Click;
            this.removeSelectedItemButton.Click += RemoveSelectedItemButton_Click;
            this.placeOrderButton.Click += PlaceOrderButton_Click;
            this.FormClosed += PlaceOrderForm_FormClosed;
        }

        private void SetUpShoppingCart()
        {
            var cart = this.shoppingCartListView;

            cart.View = View.Details;
            cart.GridLines = true;
            cart.FullRowSelect = true;
            cart.Columns.Add("ID").Width = 40;
            cart.Columns.Add("Name").Width = 100;
            cart.Columns.Add("Sale Price").Width = 120;
            cart.Columns.Add("Quantity").Width = 70;
            cart.MultiSelect = false;
        }

        private void SetUpItemCatalog()
        {
            var catalog = this.itemCatalogListView;

            catalog.View = View.Details;
            catalog.GridLines = true;
            catalog.FullRowSelect = true;
            catalog.Columns.Add("ID").Width = 40;
            catalog.Columns.Add("Name").Width = 100;
            catalog.Columns.Add("Description").Width = 140;
            catalog.Columns.Add("Price").Width = 45;
            catalog.Columns.Add("Discount").Width = 70;
            catalog.MultiSelect = false;
        }

        private void PopulateItemCatalog()
        {
            var catalog = this.itemCatalogListView;
            catalog.Items.Clear();

            foreach (var item in inventoryItems.Values)
            {
                if (item.Status == ItemStatus.OnSale)
                {
                    catalog.Items.Add(new ListViewItem(
                        new string[] { $"{item.Id}", item.Name, item.Description, $"${item.Price}", $"{item.DiscountPercentage}%" }));
                }
            }
        }

        private void PlaceOrderForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            (new LoginForm()).Show();
        }

        private void PlaceOrderButton_Click(object? sender, EventArgs e)
        {
            var itemIdQuantityPairs = new Dictionary<int, int>();

            foreach (var itemQuantitiyPair in shoppingCartItems)
            {
                itemIdQuantityPairs.Add(itemQuantitiyPair.Key.Id, itemQuantitiyPair.Value);
            }

            Program.OrderComponent.PlaceOrder(itemIdQuantityPairs, CurrentSession.UserEmail);

            shoppingCartItems.Clear();
            PopulateShoppingCart();
            PopulateItemCatalog();
        }

        private void RemoveSelectedItemButton_Click(object? sender, EventArgs e)
        {
            var cart = this.shoppingCartListView;

            if (cart.SelectedItems.Count <= 0) { return; }

            var selectedItem = (ListViewItem)cart.SelectedItems[0].Clone();
            int id = int.Parse(selectedItem.SubItems[0].Text);

            shoppingCartItems.Remove(inventoryItems[id]);

            PopulateShoppingCart();
        }

        private void AddSelectedItemButton_Click(object? sender, EventArgs e)
        {
            var catalog = this.itemCatalogListView;
            var cart = this.shoppingCartListView;

            // catalog.Focus();

            if (catalog.SelectedItems.Count <= 0) { return; }
            
            var selectedItem = (ListViewItem)catalog.SelectedItems[0].Clone();
            int id = int.Parse(selectedItem.SubItems[0].Text);

            int selectedQuantity;
            bool notEmpty = int.TryParse(this.quantityTextBox.Text, out selectedQuantity);
            selectedQuantity = (notEmpty ? selectedQuantity : 1);

            if (selectedQuantity > inventoryItems[id].AvailableQuantity)
            {
                // issue an error for the user, stop execution 
            }

            if (shoppingCartItems.ContainsKey(inventoryItems[id]))
            {
                shoppingCartItems[inventoryItems[id]] += selectedQuantity;
            }
            else
            {
                shoppingCartItems.Add(inventoryItems[id], selectedQuantity);
            }

            PopulateShoppingCart();

        this.quantityTextBox.Clear();            
        }

        private void PopulateShoppingCart()
        {
            var cart = this.shoppingCartListView;
            cart.Items.Clear();

            foreach (var entry in shoppingCartItems)
            {
                cart.Items.Add(
                    new ListViewItem(
                        new string[] { entry.Key.Id.ToString(), entry.Key.Name
                        , $"${entry.Key.SalePrice}", entry.Value.ToString() }
                        )
                    );
            }

            // calc order total (should be inside poplate shopping cart method)
            decimal orderTotal = CalculateOrderTotal();            
            this.orderTotalTextBox.Text = $"${orderTotal}";
        }

        private decimal CalculateOrderTotal()
        {
            decimal orderTotal = 0m;
            foreach (var entry in shoppingCartItems)
            {
                orderTotal += (entry.Key.SalePrice * entry.Value);
            }

            return orderTotal;
        }
    }
}
