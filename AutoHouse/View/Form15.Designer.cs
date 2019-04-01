namespace AutoHouse.View
{
    partial class Form15
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form15));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDeleteSelectedCar = new System.Windows.Forms.Button();
            this.comboBoxAutoHouse = new System.Windows.Forms.ComboBox();
            this.btnPrintCars = new System.Windows.Forms.Button();
            this.radioBtnAllCars = new System.Windows.Forms.RadioButton();
            this.radioBtnSellCars = new System.Windows.Forms.RadioButton();
            this.radioBtnRentaCars = new System.Windows.Forms.RadioButton();
            this.listBoxCars = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnBack.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(759, 284);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(156, 54);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "GoBack";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDeleteSelectedCar
            // 
            this.btnDeleteSelectedCar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnDeleteSelectedCar.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSelectedCar.Location = new System.Drawing.Point(760, 188);
            this.btnDeleteSelectedCar.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteSelectedCar.Name = "btnDeleteSelectedCar";
            this.btnDeleteSelectedCar.Size = new System.Drawing.Size(156, 54);
            this.btnDeleteSelectedCar.TabIndex = 20;
            this.btnDeleteSelectedCar.Text = "Delete selected car";
            this.btnDeleteSelectedCar.UseVisualStyleBackColor = false;
            this.btnDeleteSelectedCar.Click += new System.EventHandler(this.btnDeleteSelectedCar_Click);
            // 
            // comboBoxAutoHouse
            // 
            this.comboBoxAutoHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxAutoHouse.FormattingEnabled = true;
            this.comboBoxAutoHouse.Location = new System.Drawing.Point(72, 43);
            this.comboBoxAutoHouse.Name = "comboBoxAutoHouse";
            this.comboBoxAutoHouse.Size = new System.Drawing.Size(347, 33);
            this.comboBoxAutoHouse.TabIndex = 19;
            this.comboBoxAutoHouse.Text = "Избери автокъща.";
            this.comboBoxAutoHouse.SelectedIndexChanged += new System.EventHandler(this.comboBoxAutoHouse_SelectedIndexChanged);
            // 
            // btnPrintCars
            // 
            this.btnPrintCars.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnPrintCars.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintCars.Location = new System.Drawing.Point(886, 44);
            this.btnPrintCars.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrintCars.Name = "btnPrintCars";
            this.btnPrintCars.Size = new System.Drawing.Size(104, 32);
            this.btnPrintCars.TabIndex = 18;
            this.btnPrintCars.Text = "Print Cars";
            this.btnPrintCars.UseVisualStyleBackColor = false;
            this.btnPrintCars.Click += new System.EventHandler(this.btnPrintCars_Click);
            // 
            // radioBtnAllCars
            // 
            this.radioBtnAllCars.AutoSize = true;
            this.radioBtnAllCars.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnAllCars.Location = new System.Drawing.Point(757, 44);
            this.radioBtnAllCars.Margin = new System.Windows.Forms.Padding(2);
            this.radioBtnAllCars.Name = "radioBtnAllCars";
            this.radioBtnAllCars.Size = new System.Drawing.Size(82, 26);
            this.radioBtnAllCars.TabIndex = 17;
            this.radioBtnAllCars.TabStop = true;
            this.radioBtnAllCars.Text = "All cars";
            this.radioBtnAllCars.UseVisualStyleBackColor = true;
            // 
            // radioBtnSellCars
            // 
            this.radioBtnSellCars.AutoSize = true;
            this.radioBtnSellCars.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnSellCars.Location = new System.Drawing.Point(642, 44);
            this.radioBtnSellCars.Margin = new System.Windows.Forms.Padding(2);
            this.radioBtnSellCars.Name = "radioBtnSellCars";
            this.radioBtnSellCars.Size = new System.Drawing.Size(88, 26);
            this.radioBtnSellCars.TabIndex = 16;
            this.radioBtnSellCars.TabStop = true;
            this.radioBtnSellCars.Text = "Sell cars";
            this.radioBtnSellCars.UseVisualStyleBackColor = true;
            // 
            // radioBtnRentaCars
            // 
            this.radioBtnRentaCars.AutoSize = true;
            this.radioBtnRentaCars.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnRentaCars.Location = new System.Drawing.Point(504, 44);
            this.radioBtnRentaCars.Margin = new System.Windows.Forms.Padding(2);
            this.radioBtnRentaCars.Name = "radioBtnRentaCars";
            this.radioBtnRentaCars.Size = new System.Drawing.Size(108, 26);
            this.radioBtnRentaCars.TabIndex = 15;
            this.radioBtnRentaCars.TabStop = true;
            this.radioBtnRentaCars.Text = "Renta cars ";
            this.radioBtnRentaCars.UseVisualStyleBackColor = true;
            // 
            // listBoxCars
            // 
            this.listBoxCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxCars.FormattingEnabled = true;
            this.listBoxCars.ItemHeight = 22;
            this.listBoxCars.Location = new System.Drawing.Point(28, 108);
            this.listBoxCars.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxCars.Name = "listBoxCars";
            this.listBoxCars.Size = new System.Drawing.Size(674, 400);
            this.listBoxCars.TabIndex = 14;
            // 
            // Form15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(999, 567);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDeleteSelectedCar);
            this.Controls.Add(this.comboBoxAutoHouse);
            this.Controls.Add(this.btnPrintCars);
            this.Controls.Add(this.radioBtnAllCars);
            this.Controls.Add(this.radioBtnSellCars);
            this.Controls.Add(this.radioBtnRentaCars);
            this.Controls.Add(this.listBoxCars);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form15";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete cars";
            this.Load += new System.EventHandler(this.Form15_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDeleteSelectedCar;
        private System.Windows.Forms.ComboBox comboBoxAutoHouse;
        private System.Windows.Forms.Button btnPrintCars;
        private System.Windows.Forms.RadioButton radioBtnAllCars;
        private System.Windows.Forms.RadioButton radioBtnSellCars;
        private System.Windows.Forms.RadioButton radioBtnRentaCars;
        private System.Windows.Forms.ListBox listBoxCars;
    }
}