namespace AutoHouse.View
{
    partial class Form11
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
            this.btnRemoveCar = new System.Windows.Forms.Button();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.btnStatistic = new System.Windows.Forms.Button();
            this.btnRemoveAH = new System.Windows.Forms.Button();
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.Location = new System.Drawing.Point(1112, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(208, 66);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "GoBack";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRemoveCar
            // 
            this.btnRemoveCar.Location = new System.Drawing.Point(942, 260);
            this.btnRemoveCar.Name = "btnRemoveCar";
            this.btnRemoveCar.Size = new System.Drawing.Size(263, 158);
            this.btnRemoveCar.TabIndex = 17;
            this.btnRemoveCar.Text = "Remove Car";
            this.btnRemoveCar.UseVisualStyleBackColor = true;
            this.btnRemoveCar.Click += new System.EventHandler(this.btnRemoveCar_Click);
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(631, 260);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(263, 158);
            this.btnAddCar.TabIndex = 16;
            this.btnAddCar.Text = "Add Car";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // btnStatistic
            // 
            this.btnStatistic.Location = new System.Drawing.Point(287, 260);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(263, 158);
            this.btnStatistic.TabIndex = 15;
            this.btnStatistic.Text = "Statistic";
            this.btnStatistic.UseVisualStyleBackColor = true;
            this.btnStatistic.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // btnRemoveAH
            // 
            this.btnRemoveAH.Location = new System.Drawing.Point(782, 476);
            this.btnRemoveAH.Name = "btnRemoveAH";
            this.btnRemoveAH.Size = new System.Drawing.Size(263, 158);
            this.btnRemoveAH.TabIndex = 19;
            this.btnRemoveAH.Text = "Remove AutoHouse";
            this.btnRemoveAH.UseVisualStyleBackColor = true;
            this.btnRemoveAH.Click += new System.EventHandler(this.btnRemoveAH_Click);
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.Location = new System.Drawing.Point(465, 476);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(263, 158);
            this.btnRemoveUser.TabIndex = 20;
            this.btnRemoveUser.Text = "Remove User";
            this.btnRemoveUser.UseVisualStyleBackColor = true;
            this.btnRemoveUser.Click += new System.EventHandler(this.btnRemoveUser_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 698);
            this.Controls.Add(this.btnRemoveUser);
            this.Controls.Add(this.btnRemoveAH);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRemoveCar);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.btnStatistic);
            this.Name = "Form11";
            this.Text = "Admin Panel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRemoveCar;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnStatistic;
        private System.Windows.Forms.Button btnRemoveAH;
        private System.Windows.Forms.Button btnRemoveUser;
    }
}