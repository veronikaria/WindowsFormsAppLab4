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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ToolStripMenuItem fileItem = new ToolStripMenuItem("Класи з масивами");

            ToolStripMenuItem oneDimensionalArr = new ToolStripMenuItem("Одномірний масив");
            ToolStripMenuItem twoDimensionalArr = new ToolStripMenuItem("Двомірний масив");
            fileItem.DropDownItems.Add(oneDimensionalArr);
            fileItem.DropDownItems.Add(twoDimensionalArr);

            menuStrip.Items.Add(fileItem);

            oneDimensionalArr.Click += oneDimensionalArr_Click;
            twoDimensionalArr.Click += twoDimensionalArr_Click;
        }

        private void oneDimensionalArr_Click(object sender, EventArgs e)
        {
            Form FormOneDimensionalArr = new FormOneDimensionalArr();
            FormOneDimensionalArr.Show();
        }

        private void twoDimensionalArr_Click(object sender, EventArgs e)
        {
            Form FormOneDimensionalArr = new FormTwoDimensionalArr();
            FormOneDimensionalArr.Show();
        }
    }
}
