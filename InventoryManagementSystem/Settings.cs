using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class Settings : Sample
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void IntegratedSecurityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(IntegratedSecurityCheckBox.Checked)
            {
                UserIdtextBox.Enabled = false;
                PasswordtextBox.Enabled = false;
                UserIdtextBox.Text = "";
                PasswordtextBox.Text = "";
            }
            else
            {
                UserIdtextBox.Enabled = true;
                PasswordtextBox.Enabled = true;
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string s ;
            string path =Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            if (IntegratedSecurityCheckBox.Checked)
            {
                if (ServertextBox.Text != "" && DbTextbox.Text != "")
                {
                    s = "Data Source=" + ServertextBox.Text + ";intial Catelog=" + DbTextbox.Text + ";Integrated Security=true;";
                    File.WriteAllText(path+"\\connect", s);
                    DialogResult dr = MessageBox.Show("Setting Saved Successfully...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (dr == DialogResult.OK)
                    {
                        login log = new login();
                        Main.showWindow(log, this, MDI.ActiveForm);
                    }
                }
                else
                {
                    MessageBox.Show("Please give complete data to Continue");
                }
            }
            else
            {
                if (ServertextBox.Text != "" && DbTextbox.Text != "" && UserIdtextBox.Text != "" && PasswordtextBox.Text != "")
                {
                    s = "Data Source=" + ServertextBox.Text + ";intial Catelog=" + DbTextbox.Text + ";User Id=" + UserIdtextBox.Text + ";Password=" + PasswordtextBox.Text;
                    File.WriteAllText(path+"\\connect", s);

                    //Message box;
                    DialogResult dr = MessageBox.Show("Setting Saved Successfully...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if(dr == DialogResult.OK)
                    {
                        login log = new login();
                        Main.showWindow(log, this, MDI.ActiveForm);
                    }
                }
                else
                {
                    MessageBox.Show("Please give complete data to Continue...");
                }
            }
        }
            
            
    }
}

