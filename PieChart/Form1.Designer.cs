namespace PieChart
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblEntertainment = new Label();
            lblGas = new Label();
            lblGroceries = new Label();
            lblBills = new Label();
            btnPieChart = new Button();
            txtEntertainment = new TextBox();
            txtGas = new TextBox();
            txtGroceries = new TextBox();
            txtBills = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(136, 86);
            label1.Name = "label1";
            label1.Size = new Size(584, 86);
            label1.TabIndex = 0;
            label1.Text = "Monthly Expenses";
            // 
            // lblEntertainment
            // 
            lblEntertainment.AutoSize = true;
            lblEntertainment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEntertainment.Location = new Point(168, 237);
            lblEntertainment.Name = "lblEntertainment";
            lblEntertainment.Size = new Size(233, 45);
            lblEntertainment.TabIndex = 1;
            lblEntertainment.Text = "Entertainment";
            // 
            // lblGas
            // 
            lblGas.AutoSize = true;
            lblGas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGas.Location = new Point(168, 332);
            lblGas.Name = "lblGas";
            lblGas.Size = new Size(74, 45);
            lblGas.TabIndex = 2;
            lblGas.Text = "Gas";
            // 
            // lblGroceries
            // 
            lblGroceries.AutoSize = true;
            lblGroceries.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGroceries.Location = new Point(168, 439);
            lblGroceries.Name = "lblGroceries";
            lblGroceries.Size = new Size(161, 45);
            lblGroceries.TabIndex = 3;
            lblGroceries.Text = "Groceries";
            // 
            // lblBills
            // 
            lblBills.AutoSize = true;
            lblBills.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBills.Location = new Point(168, 540);
            lblBills.Name = "lblBills";
            lblBills.Size = new Size(82, 45);
            lblBills.TabIndex = 4;
            lblBills.Text = "Bills";
            // 
            // btnPieChart
            // 
            btnPieChart.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPieChart.Location = new Point(252, 689);
            btnPieChart.Name = "btnPieChart";
            btnPieChart.Size = new Size(258, 66);
            btnPieChart.TabIndex = 5;
            btnPieChart.Text = "Pie Chart";
            btnPieChart.UseVisualStyleBackColor = true;
            btnPieChart.Click += btnPieChart_Click;
            // 
            // txtEntertainment
            // 
            txtEntertainment.Location = new Point(432, 244);
            txtEntertainment.Name = "txtEntertainment";
            txtEntertainment.Size = new Size(200, 39);
            txtEntertainment.TabIndex = 6;
            // 
            // txtGas
            // 
            txtGas.Location = new Point(432, 338);
            txtGas.Name = "txtGas";
            txtGas.Size = new Size(200, 39);
            txtGas.TabIndex = 7;
            // 
            // txtGroceries
            // 
            txtGroceries.Location = new Point(432, 439);
            txtGroceries.Name = "txtGroceries";
            txtGroceries.Size = new Size(200, 39);
            txtGroceries.TabIndex = 8;
            // 
            // txtBills
            // 
            txtBills.Location = new Point(432, 540);
            txtBills.Name = "txtBills";
            txtBills.Size = new Size(200, 39);
            txtBills.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(1607, 974);
            Controls.Add(txtBills);
            Controls.Add(txtGroceries);
            Controls.Add(txtGas);
            Controls.Add(txtEntertainment);
            Controls.Add(btnPieChart);
            Controls.Add(lblBills);
            Controls.Add(lblGroceries);
            Controls.Add(lblGas);
            Controls.Add(lblEntertainment);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Monthly Expenses";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblEntertainment;
        private Label lblGas;
        private Label lblGroceries;
        private Label lblBills;
        private Button btnPieChart;
        private TextBox txtEntertainment;
        private TextBox txtGas;
        private TextBox txtGroceries;
        private TextBox txtBills;
    }
}
