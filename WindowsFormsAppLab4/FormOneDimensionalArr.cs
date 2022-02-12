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
    public partial class FormOneDimensionalArr : Form
    {
        public FormOneDimensionalArr()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                int length = Convert.ToInt32(textBoxLen.Text);
                OneDimensionalArray arr = new OneDimensionalArray(length);
                Random random = new Random();

                for (int i = 0; i < length; i++)
                {
                    arr[i] = random.Next(-100, 100);
                    dataGridView1.Rows.Add(arr[i].ToString());
                }

                textBoxMin.Text = arr.Min.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
    }
}
