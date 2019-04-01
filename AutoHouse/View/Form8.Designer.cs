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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
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
            this.listBoxCars.ItemHeight = 22;
            this.listBoxCars.Location = new System.Drawing.Point(28, 105);
            this.listBoxCars.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxCars.Name = "listBoxCars";
            this.listBoxCars.Size = new System.Drawing.Size(687, 422);
            this.listBoxCars.TabIndex = 0;
            // 
            // comboBoxAutoHouse
            // 
            this.comboBoxAutoHouse.FormattingEnabled = true;
            this.comboBoxAutoHouse.Location = new System.Drawing.Point(138, 53);
            this.comboBoxAutoHouse.Name = "comboBoxAutoHouse";
            this.comboBoxAutoHouse.Size = new System.Drawing.Size(277, 21);
            this.comboBoxAutoHouse.TabIndex = 10;
            this.comboBoxAutoHouse.Text = "Избери автокъща.";
            // 
            // btnPrintCars
            // 
            this.btnPrintCars.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnPrintCars.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintCars.Location = new System.Drawing.Point(886, 46);
            this.btnPrintCars.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrintCars.Name = "btnPrintCars";
            this.btnPrintCars.Size = new System.Drawing.Size(104, 32);
            this.btnPrintCars.TabIndex = 9;
            this.btnPrintCars.Text = "Print Cars";
            this.btnPrintCars.UseVisualStyleBackColor = false;
            this.btnPrintCars.Click += new System.EventHandler(this.btnPrintCars_Click);
            // 
            // radioBtnAllCars
            // 
            this.radioBtnAllCars.AutoSize = true;
            this.radioBtnAllCars.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnAllCars.Location = new System.Drawing.Point(786, 47);
            this.radioBtnAllCars.Margin = new System.Windows.Forms.Padding(2);
            this.radioBtnAllCars.Name = "radioBtnAllCars";
            this.radioBtnAllCars.Size = new System.Drawing.Size(90, 30);
            this.radioBtnAllCars.TabIndex = 8;
            this.radioBtnAllCars.TabStop = true;
            this.radioBtnAllCars.Text = "All cars";
            this.radioBtnAllCars.UseVisualStyleBackColor = true;
            // 
            // radioBtnSellCars
            // 
            this.radioBtnSellCars.AutoSize = true;
            this.radioBtnSellCars.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnSellCars.Location = new System.Drawing.Point(671, 47);
            this.radioBtnSellCars.Margin = new System.Windows.Forms.Padding(2);
            this.radioBtnSellCars.Name = "radioBtnSellCars";
            this.radioBtnSellCars.Size = new System.Drawing.Size(97, 30);
            this.radioBtnSellCars.TabIndex = 7;
            this.radioBtnSellCars.TabStop = true;
            this.radioBtnSellCars.Text = "Sell cars";
            this.radioBtnSellCars.UseVisualStyleBackColor = true;
            // 
            // radioBtnRentaCars
            // 
            this.radioBtnRentaCars.AutoSize = true;
            this.radioBtnRentaCars.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnRentaCars.Location = new System.Drawing.Point(533, 47);
            this.radioBtnRentaCars.Margin = new System.Windows.Forms.Padding(2);
            this.radioBtnRentaCars.Name = "radioBtnRentaCars";
            this.radioBtnRentaCars.Size = new System.Drawing.Size(118, 30);
            this.radioBtnRentaCars.TabIndex = 6;
            this.radioBtnRentaCars.TabStop = true;
            this.radioBtnRentaCars.Text = "Renta cars ";
            this.radioBtnRentaCars.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSelectedCar
            // 
            this.btnDeleteSelectedCar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnDeleteSelectedCar.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSelectedCar.Location = new System.Drawing.Point(753, 188);
            this.btnDeleteSelectedCar.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteSelectedCar.Name = "btnDeleteSelectedCar";
            this.btnDeleteSelectedCar.Size = new System.Drawing.Size(156, 37);
            this.btnDeleteSelectedCar.TabIndex = 11;
            this.btnDeleteSelectedCar.Text = "Delete selected car";
            this.btnDeleteSelectedCar.UseVisualStyleBackColor = false;
            this.btnDeleteSelectedCar.Click += new System.EventHandler(this.btnDeleteSelectedCar_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnBack.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(752, 284);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(157, 42);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "GoBack";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1006, 671);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDeleteSelectedCar);
            this.Controls.Add(this.comboBoxAutoHouse);
            this.Controls.Add(this.btnPrintCars);
            this.Controls.Add(this.radioBtnAllCars);
            this.Controls.Add(this.radioBtnSellCars);
            this.Controls.Add(this.radioBtnRentaCars);
            this.Controls.Add(this.listBoxCars);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Your cars";
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