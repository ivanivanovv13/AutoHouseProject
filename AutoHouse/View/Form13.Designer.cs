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
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.Location = new System.Drawing.Point(1087, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(209, 66);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "GoBack";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // comboBoxAutoHouse
            // 
            this.comboBoxAutoHouse.FormattingEnabled = true;
            this.comboBoxAutoHouse.Location = new System.Drawing.Point(63, 38);
            this.comboBoxAutoHouse.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxAutoHouse.Name = "comboBoxAutoHouse";
            this.comboBoxAutoHouse.Size = new System.Drawing.Size(161, 24);
            this.comboBoxAutoHouse.TabIndex = 20;
            this.comboBoxAutoHouse.Text = "Избери автокъща.";
            // 
            // btnPrintStatistic
            // 
            this.btnPrintStatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPrintStatistic.Location = new System.Drawing.Point(803, 27);
            this.btnPrintStatistic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrintStatistic.Name = "btnPrintStatistic";
            this.btnPrintStatistic.Size = new System.Drawing.Size(140, 39);
            this.btnPrintStatistic.TabIndex = 19;
            this.btnPrintStatistic.Text = "Print Statistic";
            this.btnPrintStatistic.UseVisualStyleBackColor = true;
            this.btnPrintStatistic.Click += new System.EventHandler(this.btnPrintStatistic_Click);
            // 
            // radioBtnVsichkiStatistic
            // 
            this.radioBtnVsichkiStatistic.AutoSize = true;
            this.radioBtnVsichkiStatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioBtnVsichkiStatistic.Location = new System.Drawing.Point(679, 32);
            this.radioBtnVsichkiStatistic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioBtnVsichkiStatistic.Name = "radioBtnVsichkiStatistic";
            this.radioBtnVsichkiStatistic.Size = new System.Drawing.Size(97, 29);
            this.radioBtnVsichkiStatistic.TabIndex = 18;
            this.radioBtnVsichkiStatistic.TabStop = true;
            this.radioBtnVsichkiStatistic.Text = "All cars";
            this.radioBtnVsichkiStatistic.UseVisualStyleBackColor = true;
            // 
            // radioBtnSellCarsStatistic
            // 
            this.radioBtnSellCarsStatistic.AutoSize = true;
            this.radioBtnSellCarsStatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioBtnSellCarsStatistic.Location = new System.Drawing.Point(526, 32);
            this.radioBtnSellCarsStatistic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioBtnSellCarsStatistic.Name = "radioBtnSellCarsStatistic";
            this.radioBtnSellCarsStatistic.Size = new System.Drawing.Size(108, 29);
            this.radioBtnSellCarsStatistic.TabIndex = 17;
            this.radioBtnSellCarsStatistic.TabStop = true;
            this.radioBtnSellCarsStatistic.Text = "Sell cars";
            this.radioBtnSellCarsStatistic.UseVisualStyleBackColor = true;
            // 
            // radioBtnRentaCarStatistic
            // 
            this.radioBtnRentaCarStatistic.AutoSize = true;
            this.radioBtnRentaCarStatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioBtnRentaCarStatistic.Location = new System.Drawing.Point(342, 32);
            this.radioBtnRentaCarStatistic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioBtnRentaCarStatistic.Name = "radioBtnRentaCarStatistic";
            this.radioBtnRentaCarStatistic.Size = new System.Drawing.Size(131, 29);
            this.radioBtnRentaCarStatistic.TabIndex = 16;
            this.radioBtnRentaCarStatistic.TabStop = true;
            this.radioBtnRentaCarStatistic.Text = "Renta cars ";
            this.radioBtnRentaCarStatistic.UseVisualStyleBackColor = true;
            // 
            // listBoxStatistic
            // 
            this.listBoxStatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxStatistic.FormattingEnabled = true;
            this.listBoxStatistic.ItemHeight = 29;
            this.listBoxStatistic.Location = new System.Drawing.Point(0, 137);
            this.listBoxStatistic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxStatistic.Name = "listBoxStatistic";
            this.listBoxStatistic.Size = new System.Drawing.Size(1346, 555);
            this.listBoxStatistic.TabIndex = 15;
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 698);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.comboBoxAutoHouse);
            this.Controls.Add(this.btnPrintStatistic);
            this.Controls.Add(this.radioBtnVsichkiStatistic);
            this.Controls.Add(this.radioBtnSellCarsStatistic);
            this.Controls.Add(this.radioBtnRentaCarStatistic);
            this.Controls.Add(this.listBoxStatistic);
            this.Name = "Form13";
            this.Text = "Statistik";
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