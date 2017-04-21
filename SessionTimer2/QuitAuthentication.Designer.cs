namespace SessionTimer2
{
    partial class QuitAuthentication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuitAuthentication));
            this.labelStaticPasswdRequired = new System.Windows.Forms.Label();
            this.adminPass = new System.Windows.Forms.MaskedTextBox();
            this.labelStaticPassword = new System.Windows.Forms.Label();
            this.quitButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelStaticPasswdRequired
            // 
            resources.ApplyResources(this.labelStaticPasswdRequired, "labelStaticPasswdRequired");
            this.labelStaticPasswdRequired.Name = "labelStaticPasswdRequired";
            // 
            // adminPass
            // 
            resources.ApplyResources(this.adminPass, "adminPass");
            this.adminPass.Name = "adminPass";
            this.adminPass.PasswordChar = '*';
            this.adminPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.adminPass_KeyPress);
            // 
            // labelStaticPassword
            // 
            resources.ApplyResources(this.labelStaticPassword, "labelStaticPassword");
            this.labelStaticPassword.Name = "labelStaticPassword";
            // 
            // quitButton
            // 
            resources.ApplyResources(this.quitButton, "quitButton");
            this.quitButton.Name = "quitButton";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // cancelButton
            // 
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // QuitAuthentication
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.labelStaticPassword);
            this.Controls.Add(this.adminPass);
            this.Controls.Add(this.labelStaticPasswdRequired);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuitAuthentication";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStaticPasswdRequired;
        private System.Windows.Forms.MaskedTextBox adminPass;
        private System.Windows.Forms.Label labelStaticPassword;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button cancelButton;
    }
}