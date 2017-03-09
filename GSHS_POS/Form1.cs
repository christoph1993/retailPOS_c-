using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Dynamic;
using System.Data.Linq.Mapping;
using System.Data.Linq.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace GSHS_POS
{
    public partial class GSHSForm : Form
    {
        private sales Sales = new sales();
        private inventories Inventories = new inventories();
        private productsClass Products = new productsClass();
        private utilities Utilities = new utilities();
        private int quantityCellIndex = 2;
        private int costCellIndex = 3;
        private int inventoryCostCellIndex = 5;
        private int inventoryQuantityCellIndex = 4;

        public GSHSForm()
        {
            InitializeComponent();
        }

        private void salesDataGrid_MouseDown(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == MouseButtons.Right)
            {
                var hti = salesDataGrid.HitTest(me.X, me.Y);
                salesDataGrid.ClearSelection();
                try
                {
                    salesDataGrid.Rows[hti.RowIndex].Selected = true;
                }
                catch(Exception exc)
                {
                    datagridviewContext.Close();
                }
            }
        }

        private void removeItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilities.removeItemRowToolStringOnClick(sender, e, salesDataGrid);
        }

        private void addItemTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addItem_Click(this, new EventArgs());
            }
        }

        private void addInvoiceProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                addItemInvoiceBtn_Click(this, new EventArgs());
            }
        }

        private void addItem_Click(object sender, EventArgs e)
        {
            string productCode = addItemTextBox.Text;
            if(productCode.Length == 0 || !productCode.All(char.IsDigit))
            {
                Utilities.textBoxMessageError("Product Code should be only numbers", "Product Code Error", addItemTextBox);
            }
            else
            {
                List<Product> products = Products.selectProductsWhere(code:long.Parse(productCode));
                if (products.Count == 0)
                {
                    Utilities.textBoxMessageError("Please add a valid product", "Invalid Product", addItemTextBox);
                }
                else
                {
                    string descriptionString = products.ElementAt(0).style + " " + products.ElementAt(0).category + " " + products.ElementAt(0).size;
                    int rowIndex = Utilities.getRowIndex(salesDataGrid, "productCode", productCode);
                    int quantity = 1;
                    if (rowIndex >= 0)
                    {
                        DataGridViewRow currentRow = salesDataGrid.Rows[rowIndex];
                        quantity = int.Parse(salesDataGrid.Rows[rowIndex].Cells[quantityCellIndex].Value.ToString()) + 1;
                        double productCost = products.ElementAt(0).cost * quantity;
                        currentRow.Cells[quantityCellIndex].Value = quantity;
                        currentRow.Cells[costCellIndex].Value = productCost;
                    }
                    else
                    {
                        string[] row = { productCode, descriptionString, quantity.ToString(), products.ElementAt(0).cost.ToString() };
                        salesDataGrid.Rows.Add(row);
                    }
                    double total = salesDataGrid.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDouble(t.Cells[costCellIndex].Value));
                    runningTotal.Text = total.ToString();
                    addItemTextBox.ResetText();
                    addItemTextBox.Focus();
                }
            }
        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            if (salesDataGrid.Rows.Count == 1 && salesDataGrid.Rows[0].Cells[0].Value == null)
            {
                MessageBox.Show("There are no Products", "No Products", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string transactionId = Guid.NewGuid().ToString();
                var productCodes = salesDataGrid.Rows.Cast<DataGridViewRow>().Select(pc => pc.Cells[0]).ToList();
                var quantity = salesDataGrid.Rows.Cast<DataGridViewRow>().Select(q => q.Cells[quantityCellIndex]).ToList();
                double total = Convert.ToDouble(runningTotal.Text);
                var items = salesDataGrid.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[quantityCellIndex].Value));
                List<Tuple<string, int, int>> recieptItems = new List<Tuple<string, int, int>>();
                List<Tuple<int, int>> updateProducts = new List<Tuple<int, int>>();
                for (int i = 0; i < productCodes.Count; i++)
                {
                    recieptItems.Add(new Tuple<string, int, int>(transactionId, Convert.ToInt32(productCodes.ElementAt(i).Value), Convert.ToInt32(quantity.ElementAt(i).Value)));
                    updateProducts.Add(new Tuple<int, int>(Convert.ToInt32(productCodes.ElementAt(i).Value), Convert.ToInt32(quantity.ElementAt(i).Value)));
                }
                Sales.insertTransaction(transactionId, total, items);
                Sales.insertRecieptItems(recieptItems);
                Products.updateProducts(updateProducts, false);
                MessageBox.Show("Sale Successful", "Successful Sale", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                salesDataGrid.Rows.Clear();
                runningTotal.ResetText();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchedProductCode = (String.IsNullOrEmpty(productCodeSearchBox.Text) || String.IsNullOrWhiteSpace(productCodeSearchBox.Text)) ? null : productCodeSearchBox.Text.ToString();
            if (!String.IsNullOrEmpty(searchedProductCode) && !searchedProductCode.All(char.IsDigit))
            {
                Utilities.textBoxMessageError("Product Code should be only numbers", "Product Code Error", productCodeSearchBox);
            }
            else
            {
                long longSearchedProductCode;
                try
                {
                    longSearchedProductCode = Int64.Parse(searchedProductCode);
                }
                catch(Exception exc)
                {
                    longSearchedProductCode = -1;
                }
                string category = (String.IsNullOrEmpty(categoriesSearchBox.Text) || String.IsNullOrWhiteSpace(categoriesSearchBox.Text)) ? null : categoriesSearchBox.Text;
                string style = (String.IsNullOrEmpty(styleSearchBox.Text) || String.IsNullOrWhiteSpace(styleSearchBox.Text)) ? null : styleSearchBox.Text;
                string size = (String.IsNullOrEmpty(sizeSearchBox.Text) || String.IsNullOrWhiteSpace(sizeSearchBox.Text)) ? null : sizeSearchBox.Text;
                char gender = '\0';
                if (genderMaleRadioButton.Checked)
                     gender = 'M';
                if (genderFemaleRB.Checked)
                    gender = 'F';
                if (genderNeutralRB.Checked)
                    gender = 'N';
                if (genderAnyRB.Checked)
                    gender = '\0';
                bool instock = instockCB.Checked;
                bool? secondHand = true;
                if (!secondHandCB.Checked)
                    secondHand = null;
                List<Product> searchProducts = Products.selectProductsWhere(category, longSearchedProductCode, gender, instock, secondHand, size, style);
                foreach(Product product in searchProducts)
                {
                    string[] row = { product.category, product.style, product.size, product.gender.ToString(), product.instock.ToString(), product.second_hand.ToString() };
                    searchResultGridView.Rows.Add(row);
                }
                Utilities.toggleVisibility(new Control[] { searchResultGridView, newSearch, searchButton, searchTermsBox });
            }
        }

        private void newSearch_Click(object sender, EventArgs e)
        {
            Utilities.toggleVisibility(new Control[] { searchResultGridView, newSearch, searchButton, searchTermsBox });
            searchResultGridView.Rows.Clear();
        }

        private void removeItemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Utilities.changeItemToolStripMenuItemOnClick(sender, e, salesDataGrid, runningTotal, new int[] { costCellIndex, quantityCellIndex });
        }

        private void removeLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilities.removeItemRowToolStringOnClick(sender, e, inventoryGridView);
        }

        private void removeItemToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Utilities.changeItemToolStripMenuItemOnClick(sender, e, inventoryGridView, inventoryRunningTotal, new int[] { inventoryCostCellIndex, inventoryQuantityCellIndex }, quantityText:inventoryQuantityTotal);
        }

        private void addQuantityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string addquantity = Utilities.textMessageBox("Add Items", "Quantity", this);
            if (!String.IsNullOrWhiteSpace(addquantity))
            {
                int add = Convert.ToInt32(addquantity);
                Utilities.changeItemToolStripMenuItemOnClick(sender, e, inventoryGridView, inventoryRunningTotal, new int[] { inventoryCostCellIndex, inventoryQuantityCellIndex }, add, inventoryQuantityTotal, true);
            }
        }

        private void newInvoiceButton_Click(object sender, EventArgs e)
        {
            string invoiceTotal = Utilities.textMessageBox("Invoice Total", "Total", this);
            string invoiceQuantity = Utilities.textMessageBox("Invoice Quantity", "Quantity", this);
            invoiceCostTotal.Text = invoiceTotal;
            invoiceQuantityTotal.Text = invoiceQuantity;
            Utilities.toggleVisibility(new Control[] { inventoryGroupBox, newInvoiceButton, clearInventoryButton, loadInvoiceButton });
        }

        private void addItemInvoiceBtn_Click(object sender, EventArgs e)
        {
            string productCode = addInvoiceProduct.Text;
            if (productCode.Length == 0 || !productCode.All(char.IsDigit))
            {
                Utilities.textBoxMessageError("Product Code should be only numbers", "Product Code Error", addInvoiceProduct);
            }
            else
            {
                List<Product> products = Products.selectProductsWhere(code: long.Parse(productCode));
                if (products.Count == 0)
                {
                    Utilities.textBoxMessageError("Please add a valid product", "Invalid Product", addInvoiceProduct);
                }
                else
                {
                    int rowIndex = Utilities.getRowIndex(inventoryGridView, "invoiceProductCode", productCode);
                    int quantity = 1;
                    if (rowIndex >= 0)
                    {
                        DataGridViewRow currentRow = inventoryGridView.Rows[rowIndex];
                        quantity = int.Parse(inventoryGridView.Rows[rowIndex].Cells[inventoryQuantityCellIndex].Value.ToString()) + 1;
                        double productCost = products.ElementAt(0).cost * quantity;
                        currentRow.Cells[inventoryQuantityCellIndex].Value = quantity;
                        currentRow.Cells[inventoryCostCellIndex].Value = productCost;
                    }
                    else
                    {
                        string[] row = { productCode, products.ElementAt(0).category, products.ElementAt(0).style, products.ElementAt(0).size, quantity.ToString(), products.ElementAt(0).cost.ToString() };
                        inventoryGridView.Rows.Add(row);
                    }
                    double totalCost = inventoryGridView.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDouble(t.Cells[inventoryCostCellIndex].Value));
                    int totalQuantity = inventoryGridView.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[inventoryQuantityCellIndex].Value));
                    inventoryRunningTotal.Text = totalCost.ToString();
                    inventoryQuantityTotal.Text = totalQuantity.ToString();
                    addInvoiceProduct.ResetText();
                    addInvoiceProduct.Focus();
                }
            }
        }

        private void clearInventoryButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This will remove everything to date. \nAre you sure?", "Clear Invoice", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(result == DialogResult.OK)
            {
                this.clearInventory();
            }
        }

        private void changeInvoiceTotalBtn_Click(object sender, EventArgs e)
        {
            string newInvoiceTotal = Utilities.textMessageBox("Change Invoice Total", "Total", this);
            if(!String.IsNullOrEmpty(newInvoiceTotal))
                invoiceCostTotal.Text = newInvoiceTotal;
        }

        private void changeInvoiceQuantityBtn_Click(object sender, EventArgs e)
        {
            string newInvoiceQuantity = Utilities.textMessageBox("Change Invoice Quantity", "Quantity", this);
            if(!String.IsNullOrEmpty(newInvoiceQuantity))
                invoiceQuantityTotal.Text = newInvoiceQuantity;
        }

        private void saveDraftButton_Click(object sender, EventArgs e)
        {
            string filename = null;
            DataTable dt = new DataTable("Draft");
            foreach (DataGridViewColumn column in inventoryGridView.Columns)
                dt.Columns.Add(column.Name, typeof(string));
            foreach(DataGridViewRow row in inventoryGridView.Rows)
            {
                DataRow dtr = dt.NewRow();
                for(int i = 0; i < inventoryGridView.ColumnCount; i++)
                {
                    dtr[i] = row.Cells[i].Value.ToString();
                }
                dt.Rows.Add(dtr);
            }
            if (String.IsNullOrEmpty(currentSaveFile.Text))
            {
                //ID_Date_Cost_Quantity
                filename = String.Format(@"{0}_{1}_{2}_{3}.xml", Guid.NewGuid().ToString().GetHashCode(), invoiceDatePicker.Value.ToFileTime().ToString(), invoiceCostTotal.Text.ToString(), invoiceQuantityTotal.Text.ToString());
            }
            else
            {
                filename = currentSaveFile.Text;
                try
                {
                    File.Delete(String.Format(@"{0}\{1}\{2}", Directory.GetCurrentDirectory().ToString(), "Drafts", filename));
                }
                catch(Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                }
            }
            dt.WriteXml(String.Format(@"{0}\{1}\{2}", Directory.GetCurrentDirectory().ToString(), "Drafts",filename));
            MessageBox.Show("Draft Has Been Saved", "Draft Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clearInventory();
        }

        private void clearInventory()
        {
            inventoryGridView.Rows.Clear();
            inventoryRunningTotal.Clear();
            inventoryQuantityTotal.Clear();
            invoiceCostTotal.Clear();
            invoiceQuantityTotal.Clear();
            Utilities.toggleVisibility(new Control[] { inventoryGroupBox, newInvoiceButton, clearInventoryButton, loadInvoiceButton });
        }

        private void loadInvoiceButton_Click(object sender, EventArgs e)
        {
            try
            {
                string[] drafts = Directory.GetFiles(String.Format(@"{0}\{1}", Directory.GetCurrentDirectory().ToString(), "Drafts"), "*.xml");
                if(drafts.Length == 0)
                {
                    MessageBox.Show("There are no draft invoices", "No Drafts", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if(drafts.Length == 1)
                    {
                        LoadInvoice(drafts[0].ToString());
                    }
                    else
                    {
                        int fileindex = drafts[0].LastIndexOf(@"\") + 1;
                        string[] draftNames = drafts.Select(s => s.Substring(fileindex)).ToArray();
                        string draft = Utilities.radioButtonBox(drafts, draftNames, "Please select Draft", this);
                        if(!String.IsNullOrEmpty(draft))
                            LoadInvoice(draft);
                    }
                }
            }
            catch(Exception xe)
            {
                MessageBox.Show(xe.ToString());
            }
        }

        private void LoadInvoice(string path)
        {
            int fileindex = path.LastIndexOf(@"\") + 1;
            string filename = path.Substring(fileindex);
            filename = filename.Substring(0, filename.LastIndexOf("."));
            string[] information = filename.Split('_');
            invoiceDatePicker.Value = DateTime.FromFileTime(long.Parse(information[1]));
            invoiceCostTotal.Text = information[2];
            invoiceQuantityTotal.Text = information[3];
            DataTable dt = new DataTable("Draft");
            foreach (DataGridViewColumn column in inventoryGridView.Columns)
                dt.Columns.Add(column.Name, typeof(string));
            dt.ReadXml(path);
            foreach (DataRow dr in dt.Rows)
                inventoryGridView.Rows.Add(dr.ItemArray);
            inventoryRunningTotal.Text = inventoryGridView.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDouble(t.Cells[inventoryCostCellIndex].Value)).ToString();
            inventoryQuantityTotal.Text= inventoryGridView.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[inventoryQuantityCellIndex].Value)).ToString();
            currentSaveFile.Text = filename;
            Utilities.toggleVisibility(new Control[] { inventoryGroupBox, newInvoiceButton, clearInventoryButton, loadInvoiceButton });
        }

        private void submitInvoiceButton_Click(object sender, EventArgs e)
        {
            if (inventoryGridView.Rows.Count == 1 && inventoryGridView.Rows[0].Cells[0].Value == null)
            {
                MessageBox.Show("There are no items currently in this invoice", "No Products", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(inventoryRunningTotal.Text != invoiceCostTotal.Text)
            {
                MessageBox.Show("The costs do not match", "Missmatching Cost", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(inventoryQuantityTotal.Text != invoiceQuantityTotal.Text)
            {
                MessageBox.Show("The quantities do not match", "Missmatching Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string invoiceId = Guid.NewGuid().ToString();
                var productCodes = inventoryGridView.Rows.Cast<DataGridViewRow>().Select(pc => pc.Cells[0]).ToList();
                var quantity = inventoryGridView.Rows.Cast<DataGridViewRow>().Select(q => q.Cells[inventoryQuantityCellIndex]).ToList();
                double total = Convert.ToDouble(invoiceCostTotal.Text);
                int items = Convert.ToInt32(invoiceQuantityTotal.Text);
                DateTime invoiceDate = invoiceDatePicker.Value;
                List<Tuple<string, int, int>> invoiceItems = new List<Tuple<string, int, int>>();
                List<Tuple<int, int>> updateProducts = new List<Tuple<int, int>>();
                for (int i = 0; i < productCodes.Count; i++)
                {
                    invoiceItems.Add(new Tuple<string, int, int>(invoiceId, Convert.ToInt32(productCodes.ElementAt(i).Value), Convert.ToInt32(quantity.ElementAt(i).Value)));
                    updateProducts.Add(new Tuple<int, int>(Convert.ToInt32(productCodes.ElementAt(i).Value), Convert.ToInt32(quantity.ElementAt(i).Value)));
                }
                Inventories.insertInventory(invoiceId, total, items, invoiceDate);
                Inventories.insertInventoryItems(invoiceItems);
                Products.updateProducts(updateProducts, true);
                MessageBox.Show("Invoice successfully inserted", "Invoice successful", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.clearInventory();
            }
        }
    }
}
