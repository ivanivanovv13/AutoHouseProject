namespace AutoHouse.View
{
    partial class Form17
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
            this.btnDeleteSelectedAutoHouse = new System.Windows.Forms.Button();
            this.listBoxAutoHouses = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnBack.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(761, 306);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(156, 54);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "GoBack";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDeleteSelectedAutoHouse
            // 
            this.btnDeleteSelectedAutoHouse.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnDeleteSelectedAutoHouse.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSelectedAutoHouse.Location = new System.Drawing.Point(762, 210);
            this.btnDeleteSelectedAutoHouse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteSelectedAutoHouse.Name = "btnDeleteSelectedAutoHouse";
            this.btnDeleteSelectedAutoHouse.Size = new System.Drawing.Size(156, 54);
            this.btnDeleteSelectedAutoHouse.TabIndex = 18;
            this.btnDeleteSelectedAutoHouse.Text = "Delete selected AutoHouses";
            this.btnDeleteSelectedAutoHouse.UseVisualStyleBackColor = false;
            this.btnDeleteSelectedAutoHouse.Click += new System.EventHandler(this.btnDeleteSelectedAutoHouse_Click);
            // 
            // listBoxAutoHouses
            // 
            this.listBoxAutoHouses.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxAutoHouses.FormattingEnabled = true;
            this.listBoxAutoHouses.ItemHeight = 22;
            this.listBoxAutoHouses.Location = new System.Drawing.Point(47, 27);
            this.listBoxAutoHouses.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxAutoHouses.Name = "listBoxAutoHouses";
            this.listBoxAutoHouses.Size = new System.Drawing.Size(624, 510);
            this.listBoxAutoHouses.TabIndex = 17;
            // 
            // Form17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(999, 567);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDeleteSelectedAutoHouse);
            this.Controls.Add(this.listBoxAutoHouses);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form17";
            this.Text = "Form17";
            this.Load += new System.EventHandler(this.Form17_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDeleteSelectedAutoHouse;
        private System.Windows.Forms.ListBox listBoxAutoHouses;
    }
}