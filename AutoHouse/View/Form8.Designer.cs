namespace AutoHouse.View
{
    partial class Form8
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
            this.listBoxCars = new System.Windows.Forms.ListBox();
            this.comboBoxAutoHouse = new System.Windows.Forms.ComboBox();
            this.btnPrintCars = new System.Windows.Forms.Button();
            this.radioBtnAllCars = new System.Windows.Forms.RadioButton();
            this.radioBtnSellCars = new System.Windows.Forms.RadioButton();
            this.radioBtnRentaCars = new System.Windows.Forms.RadioButton();
            this.btnDeleteSelectedCar = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxCars
            // 
            this.listBoxCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxCars.FormattingEnabled = true;
            this.listBoxCars.ItemHeight = 29;
            this.listBoxCars.Location = new System.Drawing.Point(37, 129);
            this.listBoxCars.Name = "listBoxCars";
            this.listBoxCars.Size = new System.Drawing.Size(915, 526);
            this.listBoxCars.TabIndex = 0;
            // 
            // comboBoxAutoHouse
            // 
            this.comboBoxAutoHouse.FormattingEnabled = true;
            this.comboBoxAutoHouse.Location = new System.Drawing.Point(184, 65);
            this.comboBoxAutoHouse.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxAutoHouse.Name = "comboBoxAutoHouse";
            this.comboBoxAutoHouse.Size = new System.Drawing.Size(368, 24);
            this.comboBoxAutoHouse.TabIndex = 10;
            this.comboBoxAutoHouse.Text = "Избери автокъща.";
            // 
            // btnPrintCars
            // 
            this.btnPrintCars.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnPrintCars.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintCars.Location = new System.Drawing.Point(1182, 57);
            this.btnPrintCars.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrintCars.Name = "btnPrintCars";
            this.btnPrintCars.Size = new System.Drawing.Size(139, 39);
            this.btnPrintCars.TabIndex = 9;
            this.btnPrintCars.Text = "Print Cars";
            this.btnPrintCars.UseVisualStyleBackColor = false;
            this.btnPrintCars.Click += new System.EventHandler(this.btnPrintCars_Click);
            // 
            // radioBtnAllCars
            // 
            this.radioBtnAllCars.AutoSize = true;
            this.radioBtnAllCars.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnAllCars.Location = new System.Drawing.Point(1048, 58);
            this.radioBtnAllCars.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioBtnAllCars.Name = "radioBtnAllCars";
            this.radioBtnAllCars.Size = new System.Drawing.Size(115, 37);
            this.radioBtnAllCars.TabIndex = 8;
            this.radioBtnAllCars.TabStop = true;
            this.radioBtnAllCars.Text = "All cars";
            this.radioBtnAllCars.UseVisualStyleBackColor = true;
            // 
            // radioBtnSellCars
            // 
            this.radioBtnSellCars.AutoSize = true;
            this.radioBtnSellCars.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnSellCars.Location = new System.Drawing.Point(895, 58);
            this.radioBtnSellCars.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioBtnSellCars.Name = "radioBtnSellCars";
            this.radioBtnSellCars.Size = new System.Drawing.Size(124, 37);
            this.radioBtnSellCars.TabIndex = 7;
            this.radioBtnSellCars.TabStop = true;
            this.radioBtnSellCars.Text = "Sell cars";
            this.radioBtnSellCars.UseVisualStyleBackColor = true;
            // 
            // radioBtnRentaCars
            // 
            this.radioBtnRentaCars.AutoSize = true;
            this.radioBtnRentaCars.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnRentaCars.Location = new System.Drawing.Point(711, 58);
            this.radioBtnRentaCars.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioBtnRentaCars.Name = "radioBtnRentaCars";
            this.radioBtnRentaCars.Size = new System.Drawing.Size(152, 37);
            this.radioBtnRentaCars.TabIndex = 6;
            this.radioBtnRentaCars.TabStop = true;
            this.radioBtnRentaCars.Text = "Renta cars ";
            this.radioBtnRentaCars.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSelectedCar
            // 
            this.btnDeleteSelectedCar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnDeleteSelectedCar.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSelectedCar.Location = new System.Drawing.Point(1004, 231);
            this.btnDeleteSelectedCar.Name = "btnDeleteSelectedCar";
            this.btnDeleteSelectedCar.Size = new System.Drawing.Size(208, 45);
            this.btnDeleteSelectedCar.TabIndex = 11;
            this.btnDeleteSelectedCar.Text = "Delete selected car";
            this.btnDeleteSelectedCar.UseVisualStyleBackColor = false;
            this.btnDeleteSelectedCar.Click += new System.EventHandler(this.btnDeleteSelectedCar_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnBack.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1003, 349);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(209, 52);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "GoBack";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1342, 826);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDeleteSelectedCar);
            this.Controls.Add(this.comboBoxAutoHouse);
            this.Controls.Add(this.btnPrintCars);
            this.Controls.Add(this.radioBtnAllCars);
            this.Controls.Add(this.radioBtnSellCars);
            this.Controls.Add(this.radioBtnRentaCars);
            this.Controls.Add(this.listBoxCars);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCars;
        private System.Windows.Forms.ComboBox comboBoxAutoHouse;
        private System.Windows.Forms.Button btnPrintCars;
        private System.Windows.Forms.RadioButton radioBtnAllCars;
        private System.Windows.Forms.RadioButton radioBtnSellCars;
        private System.Windows.Forms.RadioButton radioBtnRentaCars;
        private System.Windows.Forms.Button btnDeleteSelectedCar;
        private System.Windows.Forms.Button btnBack;
    }
}