using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxType.SelectedIndex = 0;
            dataGridViewInputMatrix.RowCount = 4;
            dataGridViewInputMatrix.ColumnCount = 3;
            dataGridViewInputMatrix[0, 3].Value = "-";
            dataGridViewInputMatrix[0, 3].ReadOnly = true;
        }

        private void numericUpDownRows_ValueChanged(object sender, EventArgs e)
        {
            var countRows = Convert.ToInt32(numericUpDownRows.Value);
            dataGridViewInputMatrix.RowCount = countRows;
            if (countRows > 1)
            {
                dataGridViewInputMatrix[0, dataGridViewInputMatrix.RowCount - 2].Value = null;
                dataGridViewInputMatrix[0, dataGridViewInputMatrix.RowCount - 2].ReadOnly = false;
            }
            dataGridViewInputMatrix[0, dataGridViewInputMatrix.RowCount - 1].Value = "-";
            dataGridViewInputMatrix[0, dataGridViewInputMatrix.RowCount - 1].ReadOnly = true;
        }

        private void numericUpDownColumns_ValueChanged(object sender, EventArgs e)
        {
            var countColumns = Convert.ToInt32(numericUpDownColumns.Value);
            dataGridViewInputMatrix.ColumnCount = countColumns;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            var countRows = Convert.ToInt32(numericUpDownRows.Value);
            var countColumns = Convert.ToInt32(numericUpDownColumns.Value);
            var source = new Fraction[countRows, countColumns];
            for (int i = 0; i < countRows; i++)
            {
                for (int j = 0; j < countColumns; j++)
                {
                    if (dataGridViewInputMatrix.Rows[i].Cells[j].Value.ToString() == "-")
                    {
                        source[i, j] = new Fraction(0);
                        continue;
                    }
                    if (i == countRows - 1)
                    {
                        source[i, j] = new Fraction(Convert.ToInt64(dataGridViewInputMatrix.Rows[i].Cells[j].Value) * -1);
                        continue;
                    }
                    source[i, j] = new Fraction(Convert.ToInt64(dataGridViewInputMatrix.Rows[i].Cells[j].Value));
                }
            }

            new Result(source, comboBoxType.Text).Show();
        }

        private void dataGridViewInputMatrix_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);

            TextBox tb = e.Control as TextBox;
            if (tb != null)
            {
                tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
            }
        }

        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }
    }
}
