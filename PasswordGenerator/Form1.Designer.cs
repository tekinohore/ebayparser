
namespace PasswordGenerator
{
    partial class PasswordGenerator
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
            this.Labe1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.generateButton = new MetroFramework.Controls.MetroButton();
            this.passwordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // Labe1
            // 
            this.Labe1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.Labe1.AutoSize = true;
            this.Labe1.Location = new System.Drawing.Point(129, 104);
            this.Labe1.Name = "Labe1";
            this.Labe1.Size = new System.Drawing.Size(259, 19);
            this.Labe1.TabIndex = 0;
            this.Labe1.Text = "This app will generate a password for you. ";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(184, 142);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(139, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Click the button below";
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(195, 175);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(122, 53);
            this.generateButton.TabIndex = 2;
            this.generateButton.Text = "Click Me!";
            this.generateButton.UseSelectable = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // passwordTextBox
            // 
            // 
            // 
            // 
            this.passwordTextBox.CustomButton.Image = null;
            this.passwordTextBox.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.passwordTextBox.CustomButton.Name = "";
            this.passwordTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.passwordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passwordTextBox.CustomButton.TabIndex = 1;
            this.passwordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passwordTextBox.CustomButton.UseSelectable = true;
            this.passwordTextBox.CustomButton.Visible = false;
            this.passwordTextBox.Lines = new string[] {
        "Password will update here"};
            this.passwordTextBox.Location = new System.Drawing.Point(184, 234);
            this.passwordTextBox.MaxLength = 32767;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '\0';
            this.passwordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordTextBox.SelectedText = "";
            this.passwordTextBox.SelectionLength = 0;
            this.passwordTextBox.SelectionStart = 0;
            this.passwordTextBox.ShortcutsEnabled = true;
            this.passwordTextBox.Size = new System.Drawing.Size(148, 23);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.Text = "Password will update here";
            this.passwordTextBox.UseSelectable = true;
            this.passwordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passwordTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PasswordGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 334);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.Labe1);
            this.ForeColor = System.Drawing.Color.Crimson;
            this.Name = "PasswordGenerator";
            this.Text = "Password Generator by Itsukami";
            this.TransparencyKey = System.Drawing.Color.LemonChiffon;
            this.Load += new System.EventHandler(this.PasswordGenerator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel Labe1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton generateButton;
        private MetroFramework.Controls.MetroTextBox passwordTextBox;
    }
}

