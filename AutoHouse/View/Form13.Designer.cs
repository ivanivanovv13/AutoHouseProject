namespace AutoHouse.View
{
    partial class Form13
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form13));
            this.btnBack = new System.Windows.Forms.Button();
            this.comboBoxAutoHouse = new System.Windows.Forms.ComboBox();
            this.btnPrintStatistic = new System.Windows.Forms.Button();
            this.radioBtnVsichkiStatistic = new System.Windows.Forms.RadioButton();
            this.radioBtnSellCarsStatistic = new System.Windows.Forms.RadioButton();
            this.radioBtnRentaCarStatistic = new System.Windows.Forms.RadioButton();
            this.listBoxStatistic = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnBack.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(815, 10);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(157, 54);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "GoBack";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // comboBoxAutoHouse
            // 
            this.comboBoxAutoHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxAutoHouse.FormattingEnabled = true;
            this.comboBoxAutoHouse.Location = new System.Drawing.Point(32, 16);
            this.comboBoxAutoHouse.Name = "comboBoxAutoHouse";
            this.comboBoxAutoHouse.Size = new System.Drawing.Size(267, 33);
            this.comboBoxAutoHouse.TabIndex = 20;
            this.comboBoxAutoHouse.Text = "Choose autohouse.";
            // 
            // btnPrintStatistic
            // 
            this.btnPrintStatistic.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnPrintStatistic.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintStatistic.Location = new System.Drawing.Point(682, 20);
            this.btnPrintStatistic.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrintStatistic.Name = "btnPrintStatistic";
            this.btnPrintStatistic.Size = new System.Drawing.Size(105, 32);
            this.btnPrintStatistic.TabIndex = 19;
            this.btnPrintStatistic.Text = "Print Statistic";
            this.btnPrintStatistic.UseVisualStyleBackColor = false;
            this.btnPrintStatistic.Click += new System.EventHandler(this.btnPrintStatistic_Click);
            // 
            // radioBtnVsichkiStatistic
            // 
            this.radioBtnVsichkiStatistic.AutoSize = true;
            this.radioBtnVsichkiStatistic.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnVsichkiStatistic.Location = new System.Drawing.Point(573, 24);
            this.radioBtnVsichkiStatistic.Margin = new System.Windows.Forms.Padding(2);
            this.radioBtnVsichkiStatistic.Name = "radioBtnVsichkiStatistic";
            this.radioBtnVsichkiStatistic.Size = new System.Drawing.Size(82, 26);
            this.radioBtnVsichkiStatistic.TabIndex = 18;
            this.radioBtnVsichkiStatistic.TabStop = true;
            this.radioBtnVsichkiStatistic.Text = "All cars";
            this.radioBtnVsichkiStatistic.UseVisualStyleBackColor = true;
            // 
            // radioBtnSellCarsStatistic
            // 
            this.radioBtnSellCarsStatistic.AutoSize = true;
            this.radioBtnSellCarsStatistic.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnSellCarsStatistic.Location = new System.Drawing.Point(466, 23);
            this.radioBtnSellCarsStatistic.Margin = new System.Windows.Forms.Padding(2);
            this.radioBtnSellCarsStatistic.Name = "radioBtnSellCarsStatistic";
            this.radioBtnSellCarsStatistic.Size = new System.Drawing.Size(88, 26);
            this.radioBtnSellCarsStatistic.TabIndex = 17;
            this.radioBtnSellCarsStatistic.TabStop = true;
            this.radioBtnSellCarsStatistic.Text = "Sell cars";
            this.radioBtnSellCarsStatistic.UseVisualStyleBackColor = true;
            // 
            // radioBtnRentaCarStatistic
            // 
            this.radioBtnRentaCarStatistic.AutoSize = true;
            this.radioBtnRentaCarStatistic.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnRentaCarStatistic.Location = new System.Drawing.Point(339, 22);
            this.radioBtnRentaCarStatistic.Margin = new System.Windows.Forms.Padding(2);
            this.radioBtnRentaCarStatistic.Name = "radioBtnRentaCarStatistic";
            this.radioBtnRentaCarStatistic.Size = new System.Drawing.Size(104, 26);
            this.radioBtnRentaCarStatistic.TabIndex = 16;
            this.radioBtnRentaCarStatistic.TabStop = true;
            this.radioBtnRentaCarStatistic.Text = "Rent  cars ";
            this.radioBtnRentaCarStatistic.UseVisualStyleBackColor = true;
            // 
            // listBoxStatistic
            // 
            this.listBoxStatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxStatistic.FormattingEnabled = true;
            this.listBoxStatistic.ItemHeight = 22;
            this.listBoxStatistic.Location = new System.Drawing.Point(32, 106);
            this.listBoxStatistic.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxStatistic.Name = "listBoxStatistic";
            this.listBoxStatistic.Size = new System.Drawing.Size(914, 400);
            this.listBoxStatistic.TabIndex = 15;
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(981, 567);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.comboBoxAutoHouse);
            this.Controls.Add(this.btnPrintStatistic);
            this.Controls.Add(this.radioBtnVsichkiStatistic);
            this.Controls.Add(this.radioBtnSellCarsStatistic);
            this.Controls.Add(this.radioBtnRentaCarStatistic);
            this.Controls.Add(this.listBoxStatistic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form13";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistic";
            this.Load += new System.EventHandler(this.Form13_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox comboBoxAutoHouse;
        private System.Windows.Forms.Button btnPrintStatistic;
        private System.Windows.Forms.RadioButton radioBtnVsichkiStatistic;
        private System.Windows.Forms.RadioButton radioBtnSellCarsStatistic;
        private System.Windows.Forms.RadioButton radioBtnRentaCarStatistic;
        private System.Windows.Forms.ListBox listBoxStatistic;
    }
}