namespace CalcPOO
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel2 = new Panel();
            tableLayoutPanel5 = new TableLayoutPanel();
            label1 = new Label();
            rbCelsius = new RadioButton();
            rbFahrenheit = new RadioButton();
            rbKelvin = new RadioButton();
            txtEntrada = new TextBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            label2 = new Label();
            rbCelsius2 = new RadioButton();
            rbFahrenheit2 = new RadioButton();
            rbKelvin2 = new RadioButton();
            txtSaída = new TextBox();
            btnConverter = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.AppWorkspace;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 22F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(btnConverter, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(17);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 82.72059F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.2794113F));
            tableLayoutPanel1.Size = new Size(482, 335);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(20, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(442, 242);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 480F));
            tableLayoutPanel2.Size = new Size(442, 242);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = SystemColors.GradientActiveCaption;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 22F));
            tableLayoutPanel3.Controls.Add(panel2, 0, 0);
            tableLayoutPanel3.Controls.Add(txtEntrada, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 79.375F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20.625F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tableLayoutPanel3.Size = new Size(215, 236);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel5);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(209, 181);
            panel2.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.BackColor = SystemColors.GradientInactiveCaption;
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(label1, 0, 0);
            tableLayoutPanel5.Controls.Add(rbCelsius, 0, 1);
            tableLayoutPanel5.Controls.Add(rbFahrenheit, 0, 2);
            tableLayoutPanel5.Controls.Add(rbKelvin, 0, 3);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.Padding = new Padding(17);
            tableLayoutPanel5.RowCount = 4;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.Size = new Size(209, 181);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.Location = new Point(20, 17);
            label1.Name = "label1";
            label1.Size = new Size(69, 23);
            label1.TabIndex = 0;
            label1.Text = "Entrada";
            // 
            // rbCelsius
            // 
            rbCelsius.AutoSize = true;
            rbCelsius.Location = new Point(20, 56);
            rbCelsius.Name = "rbCelsius";
            rbCelsius.Size = new Size(83, 27);
            rbCelsius.TabIndex = 1;
            rbCelsius.TabStop = true;
            rbCelsius.Text = "Celsius";
            rbCelsius.UseVisualStyleBackColor = true;
            // 
            // rbFahrenheit
            // 
            rbFahrenheit.AutoSize = true;
            rbFahrenheit.Location = new Point(20, 92);
            rbFahrenheit.Name = "rbFahrenheit";
            rbFahrenheit.Size = new Size(111, 27);
            rbFahrenheit.TabIndex = 2;
            rbFahrenheit.TabStop = true;
            rbFahrenheit.Text = "Fahrenheit";
            rbFahrenheit.UseVisualStyleBackColor = true;
            // 
            // rbKelvin
            // 
            rbKelvin.AutoSize = true;
            rbKelvin.Location = new Point(20, 128);
            rbKelvin.Name = "rbKelvin";
            rbKelvin.Size = new Size(76, 27);
            rbKelvin.TabIndex = 3;
            rbKelvin.TabStop = true;
            rbKelvin.Text = "Kelvin";
            rbKelvin.UseVisualStyleBackColor = true;
            // 
            // txtEntrada
            // 
            txtEntrada.Dock = DockStyle.Fill;
            txtEntrada.Location = new Point(3, 190);
            txtEntrada.Name = "txtEntrada";
            txtEntrada.Size = new Size(209, 30);
            txtEntrada.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = SystemColors.GradientActiveCaption;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 22F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel6, 0, 0);
            tableLayoutPanel4.Controls.Add(txtSaída, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(224, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 79.09091F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20.90909F));
            tableLayoutPanel4.Size = new Size(215, 236);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.BackColor = SystemColors.GradientInactiveCaption;
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 22F));
            tableLayoutPanel6.Controls.Add(label2, 0, 0);
            tableLayoutPanel6.Controls.Add(rbCelsius2, 0, 1);
            tableLayoutPanel6.Controls.Add(rbFahrenheit2, 0, 2);
            tableLayoutPanel6.Controls.Add(rbKelvin2, 0, 3);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.Padding = new Padding(17);
            tableLayoutPanel6.RowCount = 4;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel6.Size = new Size(209, 180);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.Location = new Point(20, 17);
            label2.Name = "label2";
            label2.Size = new Size(51, 23);
            label2.TabIndex = 0;
            label2.Text = "Saída";
            // 
            // rbCelsius2
            // 
            rbCelsius2.AutoSize = true;
            rbCelsius2.Location = new Point(20, 56);
            rbCelsius2.Name = "rbCelsius2";
            rbCelsius2.Size = new Size(83, 27);
            rbCelsius2.TabIndex = 1;
            rbCelsius2.TabStop = true;
            rbCelsius2.Text = "Celsius";
            rbCelsius2.UseVisualStyleBackColor = true;
            // 
            // rbFahrenheit2
            // 
            rbFahrenheit2.AutoSize = true;
            rbFahrenheit2.Location = new Point(20, 92);
            rbFahrenheit2.Name = "rbFahrenheit2";
            rbFahrenheit2.Size = new Size(111, 27);
            rbFahrenheit2.TabIndex = 2;
            rbFahrenheit2.TabStop = true;
            rbFahrenheit2.Text = "Fahrenheit";
            rbFahrenheit2.UseVisualStyleBackColor = true;
            // 
            // rbKelvin2
            // 
            rbKelvin2.AutoSize = true;
            rbKelvin2.Location = new Point(20, 128);
            rbKelvin2.Name = "rbKelvin2";
            rbKelvin2.Size = new Size(76, 27);
            rbKelvin2.TabIndex = 3;
            rbKelvin2.TabStop = true;
            rbKelvin2.Text = "Kelvin";
            rbKelvin2.UseVisualStyleBackColor = true;
            // 
            // txtSaída
            // 
            txtSaída.Dock = DockStyle.Fill;
            txtSaída.Location = new Point(3, 189);
            txtSaída.Name = "txtSaída";
            txtSaída.ReadOnly = true;
            txtSaída.Size = new Size(209, 30);
            txtSaída.TabIndex = 2;
            // 
            // btnConverter
            // 
            btnConverter.Dock = DockStyle.Fill;
            btnConverter.Font = new Font("Segoe UI", 10F);
            btnConverter.Location = new Point(20, 268);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(442, 47);
            btnConverter.TabIndex = 1;
            btnConverter.Text = "Converter";
            btnConverter.UseVisualStyleBackColor = true;
            btnConverter.Click += btnConverter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 335);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 10F);
            Name = "Form1";
            Text = "Conversor de Temperatura";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panel2.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel5;
        private TextBox txtEntrada;
        private Label label1;
        private RadioButton rbCelsius;
        private RadioButton rbFahrenheit;
        private RadioButton rbKelvin;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label2;
        private RadioButton rbCelsius2;
        private RadioButton rbFahrenheit2;
        private RadioButton rbKelvin2;
        private TextBox txtSaída;
        private Button btnConverter;
    }
}
