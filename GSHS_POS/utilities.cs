using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSHS_POS
{
    class utilities
    {
        public int getRowIndex(DataGridView datagrid, string cell, string searchValue)
        {
            int rowIndex = -1;
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = datagrid.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.Cells[cell].Value.ToString().Equals(searchValue))
                    .First();
                rowIndex = row.Index;
                return rowIndex;
            }
            catch(InvalidOperationException ioe)
            {
                return rowIndex;
            }
        }

        public void changeItemToolStripMenuItemOnClick(object sender, EventArgs e, DataGridView dataGrid, TextBox costText,  int[] indexes, int changeQuantity = 1, TextBox quantityText = null, bool add = false)
        {
            try
            {
                Int32 rowToChange = dataGrid.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                int currentQuantity = Convert.ToInt32(dataGrid.Rows[rowToChange].Cells[indexes[0]].Value);
                double cost = Convert.ToDouble(dataGrid.Rows[rowToChange].Cells[indexes[1]].Value) / currentQuantity;
                dataGrid.Rows[rowToChange].Cells[indexes[0]].Value = (add) ? currentQuantity + changeQuantity : currentQuantity - changeQuantity;
                dataGrid.Rows[rowToChange].Cells[indexes[1]].Value = (currentQuantity - changeQuantity) * cost;
                double total = dataGrid.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDouble(t.Cells[indexes[1]].Value));
                costText.Text = total.ToString();
                if (!quantityText.Text.Equals(null))
                {
                    int totalQuantity = dataGrid.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[indexes[0]].Value));
                    quantityText.Text = totalQuantity.ToString();
                }
            }
            catch(Exception exe)
            {
                MessageBox.Show("Please Right Click a valid Row", "No Product Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(exe.ToString());
            }
        }

        public void removeItemRowToolStringOnClick(object sender, EventArgs e, DataGridView dataGrid)
        {
            try
            {
                Int32 rowToDelete = dataGrid.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                dataGrid.Rows.RemoveAt(rowToDelete);
                dataGrid.ClearSelection();
            }
            catch(Exception exc)
            {
                MessageBox.Show("Please Right Click a valid Row", "No Product Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void toggleVisibility(Control[] inputForms)
        {
            inputForms.ToList().ForEach(c => c.Visible = (c.Visible) ? false : true);
        }

        public void textBoxMessageError(string errorString, string errorName, TextBox textbox)
        {
            MessageBox.Show(errorString, errorName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            textbox.ResetText();
            textbox.Focus();
        }

        public string textMessageBox(string message, string label, Form parent)
        {
            string text = null;
            using (customDialogTextBox messageBox = new customDialogTextBox())
            {
                messageBox.setLabelValue(message, label);
                messageBox.ShowDialog(parent);
                if (messageBox.DialogResult == DialogResult.OK)
                {
                    text = messageBox.getTextBoxValue();
                    if(String.IsNullOrEmpty(text))
                    {
                        MessageBox.Show("Please enter a value or press Cancel", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return (this.textMessageBox(message, label, parent));
                    }
                    else
                    {
                        return text;
                    }
                }
            }
            return text;
        }

        public string radioButtonBox(string[] radioNames, string[] radioText, string label, Form parent)
        {
            string radioName = null;
            using (radioSelect selectDraft = new radioSelect())
            {
                selectDraft.setTitle(label);
                selectDraft.generateRadioButtons(radioNames, radioText);
                selectDraft.ShowDialog();
                if (selectDraft.DialogResult == DialogResult.OK)
                {
                    radioName = selectDraft.getSelectedRadioButton();
                    if (String.IsNullOrEmpty(radioName))
                    {
                        MessageBox.Show("Please make a selection.\nOtherwise press close", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return (this.radioButtonBox(radioNames, radioText, label, parent));
                    }
                    else
                    {
                        return radioName;
                    }
                }
            }
            return radioName;
        }
    }
}
