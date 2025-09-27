namespace InventoryManagementSystem
{
    partial class Sample
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
            this.Leftpanel = new System.Windows.Forms.Panel();
            this.TopLeftPanel = new System.Windows.Forms.Panel();
            this.WelcomeLbl = new System.Windows.Forms.Label();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.TopRightpanel = new System.Windows.Forms.Panel();
            this.UserLbl = new System.Windows.Forms.Label();
            this.Leftpanel.SuspendLayout();
            this.TopLeftPanel.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.TopRightpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Leftpanel
            // 
            this.Leftpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Leftpanel.Controls.Add(this.TopLeftPanel);
            this.Leftpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Leftpanel.ForeColor = System.Drawing.Color.White;
            this.Leftpanel.Location = new System.Drawing.Point(0, 0);
            this.Leftpanel.Name = "Leftpanel";
            this.Leftpanel.Size = new System.Drawing.Size(251, 731);
            this.Leftpanel.TabIndex = 0;
            // 
            // TopLeftPanel
            // 
            this.TopLeftPanel.Controls.Add(this.WelcomeLbl);
            this.TopLeftPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.TopLeftPanel.Name = "TopLeftPanel";
            this.TopLeftPanel.Size = new System.Drawing.Size(251, 63);
            this.TopLeftPanel.TabIndex = 0;
            // 
            // WelcomeLbl
            // 
            this.WelcomeLbl.Dock = System.Windows.Forms.DockStyle.Right;
            this.WelcomeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLbl.Location = new System.Drawing.Point(141, 0);
            this.WelcomeLbl.Name = "WelcomeLbl";
            this.WelcomeLbl.Size = new System.Drawing.Size(110, 63);
            this.WelcomeLbl.TabIndex = 1;
            this.WelcomeLbl.Text = "Welcome";
            this.WelcomeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WelcomeLbl.Click += new System.EventHandler(this.label3_Click);
            // 
            // RightPanel
            // 
            this.RightPanel.Controls.Add(this.TopRightpanel);
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightPanel.Location = new System.Drawing.Point(251, 0);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(1407, 731);
            this.RightPanel.TabIndex = 0;
            // 
            // TopRightpanel
            // 
            this.TopRightpanel.Controls.Add(this.UserLbl);
            this.TopRightpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopRightpanel.Location = new System.Drawing.Point(0, 0);
            this.TopRightpanel.Name = "TopRightpanel";
            this.TopRightpanel.Size = new System.Drawing.Size(1407, 63);
            this.TopRightpanel.TabIndex = 0;
            // 
            // UserLbl
            // 
            this.UserLbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.UserLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLbl.Location = new System.Drawing.Point(0, 0);
            this.UserLbl.Name = "UserLbl";
            this.UserLbl.Size = new System.Drawing.Size(127, 63);
            this.UserLbl.TabIndex = 1;
            this.UserLbl.Text = "User";
            this.UserLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserLbl.Click += new System.EventHandler(this.label4_Click);
            // 
            // Sample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1658, 731);
            this.ControlBox = false;
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.Leftpanel);
            this.Name = "Sample";
            this.Leftpanel.ResumeLayout(false);
            this.TopLeftPanel.ResumeLayout(false);
            this.RightPanel.ResumeLayout(false);
            this.TopRightpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel Leftpanel;
        protected System.Windows.Forms.Panel TopLeftPanel;
        protected System.Windows.Forms.Panel RightPanel;
        protected System.Windows.Forms.Panel TopRightpanel;
        private System.Windows.Forms.Label WelcomeLbl;
        protected System.Windows.Forms.Label UserLbl;
    }
}