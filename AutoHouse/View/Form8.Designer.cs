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
            this.listBoxCars.Location = new System.Drawing.Point(1, 177);
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
            this.btnPrintCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPrintCars.Location = new System.Drawing.Point(1181, 55);
            this.btnPrintCars.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrintCars.Name = "btnPrintCars";
            this.btnPrintCars.Size = new System.Drawing.Size(139, 39);
            this.btnPrintCars.TabIndex = 9;
            this.btnPrintCars.Text = "Print Cars";
            this.btnPrintCars.UseVisualStyleBackColor = true;
            this.btnPrintCars.Click += new System.EventHandler(this.btnPrintCars_Click);
            // 
            // radioBtnAllCars
            // 
            this.radioBtnAllCars.AutoSize = true;
            this.radioBtnAllCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioBtnAllCars.Location = new System.Drawing.Point(1057, 60);
            this.radioBtnAllCars.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioBtnAllCars.Name = "radioBtnAllCars";
            this.radioBtnAllCars.Size = new System.Drawing.Size(97, 29);
            this.radioBtnAllCars.TabIndex = 8;
            this.radioBtnAllCars.TabStop = true;
            this.radioBtnAllCars.Text = "All cars";
            this.radioBtnAllCars.UseVisualStyleBackColor = true;
            // 
            // radioBtnSellCars
            // 
            this.radioBtnSellCars.AutoSize = true;
            this.radioBtnSellCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioBtnSellCars.Location = new System.Drawing.Point(904, 60);
            this.radioBtnSellCars.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioBtnSellCars.Name = "radioBtnSellCars";
            this.radioBtnSellCars.Size = new System.Drawing.Size(108, 29);
            this.radioBtnSellCars.TabIndex = 7;
            this.radioBtnSellCars.TabStop = true;
            this.radioBtnSellCars.Text = "Sell cars";
            this.radioBtnSellCars.UseVisualStyleBackColor = true;
            // 
            // radioBtnRentaCars
            // 
            this.radioBtnRentaCars.AutoSize = true;
            this.radioBtnRentaCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioBtnRentaCars.Location = new System.Drawing.Point(720, 60);
            this.radioBtnRentaCars.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioBtnRentaCars.Name = "radioBtnRentaCars";
            this.radioBtnRentaCars.Size = new System.Drawing.Size(131, 29);
            this.radioBtnRentaCars.TabIndex = 6;
            this.radioBtnRentaCars.TabStop = true;
            this.radioBtnRentaCars.Text = "Renta cars ";
            this.radioBtnRentaCars.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSelectedCar
            // 
            this.btnDeleteSelectedCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteSelectedCar.Location = new System.Drawing.Point(1013, 233);
            this.btnDeleteSelectedCar.Name = "btnDeleteSelectedCar";
            this.btnDeleteSelectedCar.Size = new System.Drawing.Size(208, 66);
            this.btnDeleteSelectedCar.TabIndex = 11;
            this.btnDeleteSelectedCar.Text = "Delete selected car";
            this.btnDeleteSelectedCar.UseVisualStyleBackColor = true;
            this.btnDeleteSelectedCar.Click += new System.EventHandler(this.btnDeleteSelectedCar_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.Location = new System.Drawing.Point(1012, 351);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(208, 66);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "GoBack";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 698);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDeleteSelectedCar);
            this.Controls.Add(this.comboBoxAutoHouse);
            this.Controls.Add(this.btnPrintCars);
            this.Controls.Add(this.radioBtnAllCars);
            this.Controls.Add(this.radioBtnSellCars);
            this.Controls.Add(this.radioBtnRentaCars);
            this.Controls.Add(this.listBoxCars);
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