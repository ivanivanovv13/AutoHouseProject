namespace AutoHouse
{
    partial class Form2
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
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnRent = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAdminPanel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnLogOut.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F);
            this.btnLogOut.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.Location = new System.Drawing.Point(1172, 12);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(148, 31);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnRent
            // 
            this.btnRent.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnRent.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRent.ForeColor = System.Drawing.Color.Black;
            this.btnRent.Location = new System.Drawing.Point(357, 160);
            this.btnRent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(263, 158);
            this.btnRent.TabIndex = 1;
            this.btnRent.Text = "Rent";
            this.btnRent.UseVisualStyleBackColor = false;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnBuy.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.ForeColor = System.Drawing.Color.Black;
            this.btnBuy.Location = new System.Drawing.Point(709, 160);
            this.btnBuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(245, 159);
            this.btnBuy.TabIndex = 2;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSlateGray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 13.8F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 651);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Create new AutoHouse";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSlateGray;
            this.button1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(357, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(263, 158);
            this.button1.TabIndex = 4;
            this.button1.Text = "My Auto House";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdminPanel
            // 
            this.btnAdminPanel.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnAdminPanel.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminPanel.ForeColor = System.Drawing.Color.Black;
            this.btnAdminPanel.Location = new System.Drawing.Point(709, 380);
            this.btnAdminPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdminPanel.Name = "btnAdminPanel";
            this.btnAdminPanel.Size = new System.Drawing.Size(245, 159);
            this.btnAdminPanel.TabIndex = 5;
            this.btnAdminPanel.Text = "Admin Panel";
            this.btnAdminPanel.UseVisualStyleBackColor = false;
            this.btnAdminPanel.Click += new System.EventHandler(this.btnAdminPanel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1332, 698);
            this.Controls.Add(this.btnAdminPanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.btnLogOut);
            this.ForeColor = System.Drawing.Color.Red;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAdminPanel;
    }
}