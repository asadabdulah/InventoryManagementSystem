namespace InventoryManagementSystem
{
    partial class Settings
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
            this.UserIdLbl = new System.Windows.Forms.Label();
            this.UserIdtextBox = new System.Windows.Forms.TextBox();
            this.IntegratedSecurityCheckBox = new System.Windows.Forms.CheckBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.PasswordtextBox = new System.Windows.Forms.TextBox();
            this.Serverlbl = new System.Windows.Forms.Label();
            this.ServertextBox = new System.Windows.Forms.TextBox();
            this.DBlabl = new System.Windows.Forms.Label();
            this.DbTextbox = new System.Windows.Forms.TextBox();
            this.Leftpanel.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.TopRightpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Leftpanel
            // 
            this.Leftpanel.Controls.Add(this.SaveBtn);
            this.Leftpanel.Controls.Add(this.IntegratedSecurityCheckBox);
            this.Leftpanel.Controls.Add(this.DbTextbox);
            this.Leftpanel.Controls.Add(this.PasswordtextBox);
            this.Leftpanel.Controls.Add(this.DBlabl);
            this.Leftpanel.Controls.Add(this.PasswordLbl);
            this.Leftpanel.Controls.Add(this.ServertextBox);
            this.Leftpanel.Controls.Add(this.Serverlbl);
            this.Leftpanel.Controls.Add(this.UserIdtextBox);
            this.Leftpanel.Controls.Add(this.UserIdLbl);
            this.Leftpanel.Size = new System.Drawing.Size(251, 654);
            this.Leftpanel.Controls.SetChildIndex(this.TopLeftPanel, 0);
            this.Leftpanel.Controls.SetChildIndex(this.UserIdLbl, 0);
            this.Leftpanel.Controls.SetChildIndex(this.UserIdtextBox, 0);
            this.Leftpanel.Controls.SetChildIndex(this.Serverlbl, 0);
            this.Leftpanel.Controls.SetChildIndex(this.ServertextBox, 0);
            this.Leftpanel.Controls.SetChildIndex(this.PasswordLbl, 0);
            this.Leftpanel.Controls.SetChildIndex(this.DBlabl, 0);
            this.Leftpanel.Controls.SetChildIndex(this.PasswordtextBox, 0);
            this.Leftpanel.Controls.SetChildIndex(this.DbTextbox, 0);
            this.Leftpanel.Controls.SetChildIndex(this.IntegratedSecurityCheckBox, 0);
            this.Leftpanel.Controls.SetChildIndex(this.SaveBtn, 0);
            // 
            // RightPanel
            // 
            this.RightPanel.Size = new System.Drawing.Size(1040, 654);
            // 
            // TopRightpanel
            // 
            this.TopRightpanel.Size = new System.Drawing.Size(1040, 63);
            // 
            // UserIdLbl
            // 
            this.UserIdLbl.AutoSize = true;
            this.UserIdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserIdLbl.Location = new System.Drawing.Point(21, 296);
            this.UserIdLbl.Name = "UserIdLbl";
            this.UserIdLbl.Size = new System.Drawing.Size(58, 18);
            this.UserIdLbl.TabIndex = 1;
            this.UserIdLbl.Text = "User ID";
            // 
            // UserIdtextBox
            // 
            this.UserIdtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserIdtextBox.Location = new System.Drawing.Point(22, 320);
            this.UserIdtextBox.MaxLength = 100;
            this.UserIdtextBox.Name = "UserIdtextBox";
            this.UserIdtextBox.Size = new System.Drawing.Size(207, 24);
            this.UserIdtextBox.TabIndex = 2;
            // 
            // IntegratedSecurityCheckBox
            // 
            this.IntegratedSecurityCheckBox.AutoSize = true;
            this.IntegratedSecurityCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntegratedSecurityCheckBox.Location = new System.Drawing.Point(23, 421);
            this.IntegratedSecurityCheckBox.Name = "IntegratedSecurityCheckBox";
            this.IntegratedSecurityCheckBox.Size = new System.Drawing.Size(151, 22);
            this.IntegratedSecurityCheckBox.TabIndex = 3;
            this.IntegratedSecurityCheckBox.Text = "Integrated Security";
            this.IntegratedSecurityCheckBox.UseVisualStyleBackColor = true;
            this.IntegratedSecurityCheckBox.CheckedChanged += new System.EventHandler(this.IntegratedSecurityCheckBox_CheckedChanged);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Location = new System.Drawing.Point(23, 458);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(207, 42);
            this.SaveBtn.TabIndex = 4;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLbl.Location = new System.Drawing.Point(21, 356);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(75, 18);
            this.PasswordLbl.TabIndex = 1;
            this.PasswordLbl.Text = "Password";
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordtextBox.Location = new System.Drawing.Point(22, 378);
            this.PasswordtextBox.MaxLength = 100;
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.Size = new System.Drawing.Size(207, 24);
            this.PasswordtextBox.TabIndex = 2;
            // 
            // Serverlbl
            // 
            this.Serverlbl.AutoSize = true;
            this.Serverlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Serverlbl.Location = new System.Drawing.Point(20, 170);
            this.Serverlbl.Name = "Serverlbl";
            this.Serverlbl.Size = new System.Drawing.Size(51, 18);
            this.Serverlbl.TabIndex = 1;
            this.Serverlbl.Text = "Server";
            this.Serverlbl.Click += new System.EventHandler(this.label3_Click);
            // 
            // ServertextBox
            // 
            this.ServertextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServertextBox.Location = new System.Drawing.Point(22, 193);
            this.ServertextBox.MaxLength = 100;
            this.ServertextBox.Name = "ServertextBox";
            this.ServertextBox.Size = new System.Drawing.Size(207, 24);
            this.ServertextBox.TabIndex = 2;
            // 
            // DBlabl
            // 
            this.DBlabl.AutoSize = true;
            this.DBlabl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DBlabl.Location = new System.Drawing.Point(20, 231);
            this.DBlabl.Name = "DBlabl";
            this.DBlabl.Size = new System.Drawing.Size(71, 18);
            this.DBlabl.TabIndex = 1;
            this.DBlabl.Text = "Database";
            // 
            // DbTextbox
            // 
            this.DbTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DbTextbox.Location = new System.Drawing.Point(22, 254);
            this.DbTextbox.MaxLength = 100;
            this.DbTextbox.Name = "DbTextbox";
            this.DbTextbox.Size = new System.Drawing.Size(207, 24);
            this.DbTextbox.TabIndex = 2;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 654);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Leftpanel.ResumeLayout(false);
            this.Leftpanel.PerformLayout();
            this.RightPanel.ResumeLayout(false);
            this.TopRightpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.CheckBox IntegratedSecurityCheckBox;
        private System.Windows.Forms.TextBox UserIdtextBox;
        private System.Windows.Forms.Label UserIdLbl;
        private System.Windows.Forms.TextBox DbTextbox;
        private System.Windows.Forms.TextBox PasswordtextBox;
        private System.Windows.Forms.Label DBlabl;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.TextBox ServertextBox;
        private System.Windows.Forms.Label Serverlbl;
    }
}