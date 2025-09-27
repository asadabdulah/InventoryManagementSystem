namespace InventoryManagementSystem
{
    partial class Home
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
            this.Leftpanel.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.TopRightpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Leftpanel
            // 
            this.Leftpanel.Size = new System.Drawing.Size(251, 450);
            // 
            // RightPanel
            // 
            this.RightPanel.Size = new System.Drawing.Size(549, 450);
            // 
            // TopRightpanel
            // 
            this.TopRightpanel.Size = new System.Drawing.Size(549, 63);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.Leftpanel.ResumeLayout(false);
            this.RightPanel.ResumeLayout(false);
            this.TopRightpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}