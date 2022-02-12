using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppLab4
{
    public partial class FormTwoDimensionalArr : Form
    {
        public FormTwoDimensionalArr()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int amount_workshop, amount_plots;
            try
            {
                amount_workshop = Convert.ToInt32(textBoxRow.Text);
                amount_plots = Convert.ToInt32(textBoxCol.Text);
                DataGridViewTextBoxColumn dgvCol;

                for (int i = 0; i < amount_plots; i++)
                {
                    dgvCol = new DataGridViewTextBoxColumn();
                    dgvCol.Width = 40;
                    dataGridView1.Columns.Add(dgvCol);
                }
                dataGridView1.Rows.Clear();
                dataGridView1.RowCount = amount_workshop;
                dataGridView1.ColumnCount = amount_plots;

                TwoDimensionalArray array = new TwoDimensionalArray(amount_workshop,amount_plots);
                for (int i = 0; i < amount_workshop; i++)
                {
                    for (int j = 0; j < amount_plots; j++)
                    {
                        array[i, j] = random.Next(1, 100);
                        dataGridView1.Rows[i].Cells[j].Value = array[i, j].ToString();
                    }
                }

                textBoxNumberWorkshop.Text = array.NumberWorkshopWithMinAmount.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
