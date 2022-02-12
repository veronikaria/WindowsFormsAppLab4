
namespace WindowsFormsAppLab4
{
    partial class FormOneDimensionalArr
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxLen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ColumnArray = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnArray});
            this.dataGridView1.Location = new System.Drawing.Point(35, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(327, 506);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBoxLen
            // 
            this.textBoxLen.Location = new System.Drawing.Point(411, 81);
            this.textBoxLen.Name = "textBoxLen";
            this.textBoxLen.Size = new System.Drawing.Size(163, 22);
            this.textBoxLen.TabIndex = 1;
            this.textBoxLen.Text = "15";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(408, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Кількість елементів у масиві";
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(411, 144);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(163, 53);
            this.buttonCalc.TabIndex = 3;
            this.buttonCalc.Text = "Розрахувати";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // textBoxMin
            // 
            this.textBoxMin.Location = new System.Drawing.Point(411, 277);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.ReadOnly = true;
            this.textBoxMin.Size = new System.Drawing.Size(163, 22);
            this.textBoxMin.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Мінімальне значення у масиві";
            // 
            // ColumnArray
            // 
            this.ColumnArray.HeaderText = "Array";
            this.ColumnArray.MinimumWidth = 6;
            this.ColumnArray.Name = "ColumnArray";
            this.ColumnArray.Width = 125;
            // 
            // FormOneDimensionalArr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 564);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxMin);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxLen);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormOneDimensionalArr";
            this.Text = "FormOneDimensionalArr";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxLen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnArray;
    }
}