namespace AutoHouse.View
{
    partial class Form16
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
            this.listBoxUser = new System.Windows.Forms.ListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDeleteSelectedUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxUser
            // 
            this.listBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxUser.FormattingEnabled = true;
            this.listBoxUser.ItemHeight = 29;
            this.listBoxUser.Location = new System.Drawing.Point(0, 0);
            this.listBoxUser.Name = "listBoxUser";
            this.listBoxUser.Size = new System.Drawing.Size(849, 700);
            this.listBoxUser.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.Location = new System.Drawing.Point(1015, 379);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(208, 66);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "GoBack";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDeleteSelectedUser
            // 
            this.btnDeleteSelectedUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteSelectedUser.Location = new System.Drawing.Point(1016, 261);
            this.btnDeleteSelectedUser.Name = "btnDeleteSelectedUser";
            this.btnDeleteSelectedUser.Size = new System.Drawing.Size(208, 66);
            this.btnDeleteSelectedUser.TabIndex = 15;
            this.btnDeleteSelectedUser.Text = "Delete selected user";
            this.btnDeleteSelectedUser.UseVisualStyleBackColor = true;
            this.btnDeleteSelectedUser.Click += new System.EventHandler(this.btnDeleteSelectedUser_Click);
            // 
            // Form16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 698);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDeleteSelectedUser);
            this.Controls.Add(this.listBoxUser);
            this.Name = "Form16";
            this.Text = "Remove User";
            this.Load += new System.EventHandler(this.Form16_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxUser;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDeleteSelectedUser;
    }
}