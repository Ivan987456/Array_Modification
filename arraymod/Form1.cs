using System;
using System.Windows.Forms;

namespace ArrayMod
{
    public partial class Form1 : Form
    {
        int x, y;
        int column, row;

        public Form1()
        {
            InitializeComponent();
        }

        private void buildButton_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(XComboBox.Text);
            y = Convert.ToInt32(YComboBox.Text);
            dataGridView1.ColumnCount = x;
            dataGridView1.RowCount = y;
            dataGridView1.AutoResizeColumns();
            ItemsComboBox(x, y);
        }

        private void rndButton_Click(object sender, EventArgs e)
        {
            ArrayRnd();
        }

        public void ArrayRnd()
        {
            Random rnd = new Random();
            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                {
                    dataGridView1[i, j].Value = rnd.Next(0, 99);
                }
        }

        private void ItemsComboBox(int x, int y)
        {
            for (int i = 1; i < x + 1; i++)
                columnComboBox.Items.Add(i);
            for (int j = 1; j < y + 1; j++)
                rowComboBox.Items.Add(j);
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            if (ColumnRadioButton.Checked)
            {
                if (Int32.TryParse(columnComboBox.Text, out column) && column <= y)
                    ArraySortColumns(column);
                else
                    Error();
            }
            else
            {
                if (Int32.TryParse(rowComboBox.Text, out row) && row <= x)
                    ArraySortRows(row);
                else
                    Error();
            }
        }

        public void Error()
        {
            MessageBox.Show("Некорректные данные!", "Ошибка", MessageBoxButtons.OK);
        }

        public void ArrayMainDiagonal()
        {
            int sumMainDiag = 0;
            long prodMainDiag = 1;
            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                    if (i == j)
                    {
                        sumMainDiag += (Int32)dataGridView1[i, j].Value;
                        prodMainDiag *= (Int32)dataGridView1[i, j].Value;
                    }
            sumMainDiagTextBox.Text = $"{sumMainDiag}";
            productMainDiagTextBox.Text = $"{prodMainDiag}";
        }

        public void ArraySideDiagonal()
        {
            int sumSideDiag = 0;
            long prodSideDiag = 1;
            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                    if (i == x - j +1)
                    {
                        sumSideDiag += (Int32)dataGridView1[i, j].Value;
                        prodSideDiag *= (Int32)dataGridView1[i, j].Value;
                    }
            sumSideDiagTextBox.Text = $"{sumSideDiag}";
            productSideDiagTextBox.Text = $"{prodSideDiag}";
        }

        private void sumDiagButton_Click(object sender, EventArgs e)
        {
            ArrayMainDiagonal();
            ArraySideDiagonal();
        }

        public void ArraySortColumns(int column)
        {
            try
            {
                int temp;
                for (int i = 0; i < y - 1; i++)
                {
                    for (int j = i + 1; j < y; j++)
                        if (checkBox1.Checked == true)
                        {
                            if ((int)dataGridView1[column, i].Value < (int)dataGridView1[column, j].Value)
                            {
                                temp = (Int32)dataGridView1[column, i].Value;
                                dataGridView1[column, i].Value = dataGridView1[column, j].Value;
                                dataGridView1[column, j].Value = temp;
                            }
                        }
                        else
                        {
                            if ((int)dataGridView1[column, i].Value > (int)dataGridView1[column, j].Value)
                            {
                                temp = (Int32)dataGridView1[column, i].Value;
                                dataGridView1[column, i].Value = dataGridView1[column, j].Value;
                                dataGridView1[column, j].Value = temp;
                            }
                        }
                }
            }
            catch
            {
                Error();
            }
        }

        public void ArraySortRows(int row)
        {
            try
            {
                int temp;
                for (int i = 0; i < y - 1; i++)
                {
                    for (int j = i + 1; j < y; j++)
                        if (checkBox1.Checked == true)
                        {
                            if ((int)dataGridView1[i, row].Value < (int)dataGridView1[j, row].Value)
                            {
                                temp = (Int32)dataGridView1[i, row].Value;
                                dataGridView1[i, row].Value = dataGridView1[j, row].Value;
                                dataGridView1[j, row].Value = temp;
                            }
                        }
                        else
                        {
                            if ((int)dataGridView1[i, row].Value > (int)dataGridView1[j, row].Value)
                            {
                                temp = (Int32)dataGridView1[i, row].Value;
                                dataGridView1[i, row].Value = dataGridView1[j, row].Value;
                                dataGridView1[j, row].Value = temp;
                            }
                        }
                }
            }
            catch
            {
                Error();
            }
        }
    }
}
