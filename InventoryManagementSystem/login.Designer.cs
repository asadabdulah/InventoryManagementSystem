namespace InventoryManagementSystem
{
    partial class login
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
            this.UserNameLbl = new System.Windows.Forms.Label();
            this.UserNametxtBox = new System.Windows.Forms.TextBox();
            this.Passwordlbl = new System.Windows.Forms.Label();
            this.PasswordtextBox = new System.Windows.Forms.TextBox();
            this.Loginbutton = new System.Windows.Forms.Button();
            this.Leftpanel.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.TopRightpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Leftpanel
            // 
            this.Leftpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Leftpanel.Controls.Add(this.Loginbutton);
            this.Leftpanel.Controls.Add(this.PasswordtextBox);
            this.Leftpanel.Controls.Add(this.Passwordlbl);
            this.Leftpanel.Controls.Add(this.UserNametxtBox);
            this.Leftpanel.Controls.Add(this.UserNameLbl);
            this.Leftpanel.Size = new System.Drawing.Size(267, 737);
            this.Leftpanel.Controls.SetChildIndex(this.TopLeftPanel, 0);
            this.Leftpanel.Controls.SetChildIndex(this.UserNameLbl, 0);
            this.Leftpanel.Controls.SetChildIndex(this.UserNametxtBox, 0);
            this.Leftpanel.Controls.SetChildIndex(this.Passwordlbl, 0);
            this.Leftpanel.Controls.SetChildIndex(this.PasswordtextBox, 0);
            this.Leftpanel.Controls.SetChildIndex(this.Loginbutton, 0);
            // 
            // TopLeftPanel
            // 
            this.TopLeftPanel.Size = new System.Drawing.Size(267, 63);
            // 
            // RightPanel
            // 
            this.RightPanel.Location = new System.Drawing.Point(267, 0);
            this.RightPanel.Size = new System.Drawing.Size(1286, 737);
            // 
            // TopRightpanel
            // 
            this.TopRightpanel.Size = new System.Drawing.Size(1286, 63);
            // 
            // UserNameLbl
            // 
            this.UserNameLbl.AutoSize = true;
            this.UserNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLbl.Location = new System.Drawing.Point(18, 238);
            this.UserNameLbl.Name = "UserNameLbl";
            this.UserNameLbl.Size = new System.Drawing.Size(84, 18);
            this.UserNameLbl.TabIndex = 1;
            this.UserNameLbl.Text = "User Name";
            // 
            // UserNametxtBox
            // 
            this.UserNametxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserNametxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNametxtBox.Location = new System.Drawing.Point(21, 259);
            this.UserNametxtBox.MaxLength = 100;
            this.UserNametxtBox.Name = "UserNametxtBox";
            this.UserNametxtBox.Size = new System.Drawing.Size(209, 24);
            this.UserNametxtBox.TabIndex = 2;
            // 
            // Passwordlbl
            // 
            this.Passwordlbl.AutoSize = true;
            this.Passwordlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordlbl.Location = new System.Drawing.Point(18, 296);
            this.Passwordlbl.Name = "Passwordlbl";
            this.Passwordlbl.Size = new System.Drawing.Size(75, 18);
            this.Passwordlbl.TabIndex = 1;
            this.Passwordlbl.Text = "Password";
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordtextBox.Location = new System.Drawing.Point(21, 317);
            this.PasswordtextBox.MaxLength = 120;
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.Size = new System.Drawing.Size(209, 24);
            this.PasswordtextBox.TabIndex = 2;
            this.PasswordtextBox.UseSystemPasswordChar = true;
            // 
            // Loginbutton
            // 
            this.Loginbutton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Loginbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Loginbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Loginbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Loginbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbutton.ForeColor = System.Drawing.Color.White;
            this.Loginbutton.Location = new System.Drawing.Point(21, 364);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.Size = new System.Drawing.Size(209, 36);
            this.Loginbutton.TabIndex = 3;
            this.Loginbutton.Text = "Login\r\n";
            this.Loginbutton.UseVisualStyleBackColor = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1553, 737);
            this.Name = "login";
            this.Text = "login";
            this.Leftpanel.ResumeLayout(false);
            this.Leftpanel.PerformLayout();
            this.RightPanel.ResumeLayout(false);
            this.TopRightpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.TextBox PasswordtextBox;
        protected System.Windows.Forms.Label Passwordlbl;
        protected System.Windows.Forms.TextBox UserNametxtBox;
        protected System.Windows.Forms.Label UserNameLbl;
        private System.Windows.Forms.Button Loginbutton;
    }
}