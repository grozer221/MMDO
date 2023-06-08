using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Result : Form
    {
        Fraction[,] source;
        int countRows;
        int countColumns;
        string action;

        public Result(Fraction[,] source, string action)
        {
            InitializeComponent();

            this.source = source;
            this.countRows = source.GetLength(0);
            this.countColumns = source.GetLength(1);
            this.action = action;
            Calculate();
        }

        private void Calculate()
        {
            try
            {

                var result = new Fraction[source.GetLength(1) - 1];
                List<Fraction[,]> tablesResult;

                var simplex = new Simplex(source);
                tablesResult = simplex.Calculate(result);

                for (int i = 0; i < result.Length; i++)
                {
                    var labelResult = new Label();
                    labelResult.Text = $"x{i + 1} = {result[i]}";
                    labelResult.Font = new Font("Microsoft Sans Serif", 14);
                    labelResult.Location = new Point(18, i * 30 + 330);
                    labelResult.Width = 125;
                    tabPageMain.Controls.Add(labelResult);
                }

                labelResultF.Text = $"F{action} = {simplex.GetF()}";
                var tabPages = new TabPage[tablesResult.Count];
                var gridViewsTables = new DataGridView[tablesResult.Count];

                for (int i = 0; i < tablesResult.Count; i++)
                {
                    string title;
                    if (i == tablesResult.Count - 1)
                    {
                        title = "Вихідна";
                    }
                    else
                        title = $"Проміжна №{i + 1}";

                    tabPages[i] = new TabPage(title);
                    tabControlTables.TabPages.Add(tabPages[i]);
                    gridViewsTables[i] = GetStyleDataGridView();

                    for (int j = 0; j < countRows; j++)
                    {
                        for (int k = 0; k < countColumns * 2; k++)
                        {
                            if (i == tablesResult.Count - 1 && k == 0)
                            {
                                foreach (var res in result)
                                {
                                    if (tablesResult[i][j, k] == res)
                                    {
                                        gridViewsTables[i].Rows[j].Cells[k].Style.BackColor = Color.Blue;
                                        break;
                                    }
                                }
                            }
                            try
                            {
                                gridViewsTables[i].Rows[j].Cells[k].Value = tablesResult[i][j, k];
                            }
                            catch { }
                        }
                    }
                    if (i == tablesResult.Count - 1)
                        gridViewsTables[i].Rows[countRows - 1].Cells[0].Style.BackColor = Color.Yellow;

                    tabPages[i].Controls.Add(gridViewsTables[i]);
                    gridViewsTables[i].ClearSelection();
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Введено не всі значення", "Сталася помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Сталася помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataGridView GetStyleDataGridView()
        {
            var dataGridView = new DataGridView();
            dataGridView.ReadOnly = true;
            dataGridView.ColumnCount = countColumns * 2;
            dataGridView.RowCount = countRows;
            dataGridView.Size = new Size(345, 170);
            dataGridView.AllowUserToResizeRows = true;
            dataGridView.AllowUserToResizeColumns = true;
            dataGridView.AutoResizeColumns();
            dataGridView.ColumnHeadersVisible = false;
            dataGridView.RowHeadersVisible = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.MultiSelect = false;
            return dataGridView;
        }
    }
}
