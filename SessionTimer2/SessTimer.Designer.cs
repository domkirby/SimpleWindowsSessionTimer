using System.Windows.Forms;
namespace SessionTimer2
{
    partial class SessTimer
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
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_NOCLOSE = 0x200;

                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_NOCLOSE;
                return cp;
            }
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SessTimer));
            this.labelStaticInfo = new System.Windows.Forms.Label();
            this.labelStaticTR = new System.Windows.Forms.Label();
            this.labelDynamicTimeLeft = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelStaticInfo
            // 
            this.labelStaticInfo.AutoSize = true;
            this.labelStaticInfo.Location = new System.Drawing.Point(12, 9);
            this.labelStaticInfo.Name = "labelStaticInfo";
            this.labelStaticInfo.Size = new System.Drawing.Size(381, 26);
            this.labelStaticInfo.TabIndex = 0;
            this.labelStaticInfo.Text = "NOTICE: Your session is time limited, please pay attention to the time remaining." +
    "\r\nYou will be signed out at the conclusion of your session.";
            // 
            // labelStaticTR
            // 
            this.labelStaticTR.AutoSize = true;
            this.labelStaticTR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStaticTR.Location = new System.Drawing.Point(36, 47);
            this.labelStaticTR.Name = "labelStaticTR";
            this.labelStaticTR.Size = new System.Drawing.Size(105, 13);
            this.labelStaticTR.TabIndex = 1;
            this.labelStaticTR.Text = "Time Remaining: ";
            this.labelStaticTR.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelDynamicTimeLeft
            // 
            this.labelDynamicTimeLeft.AutoSize = true;
            this.labelDynamicTimeLeft.Location = new System.Drawing.Point(147, 47);
            this.labelDynamicTimeLeft.Name = "labelDynamicTimeLeft";
            this.labelDynamicTimeLeft.Size = new System.Drawing.Size(13, 13);
            this.labelDynamicTimeLeft.TabIndex = 2;
            this.labelDynamicTimeLeft.Text = "e";
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(399, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Quit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(399, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Logout Now";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // SessTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 81);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelDynamicTimeLeft);
            this.Controls.Add(this.labelStaticTR);
            this.Controls.Add(this.labelStaticInfo);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SessTimer";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Time Limit Manager";
            this.Load += new System.EventHandler(this.SessTimer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStaticInfo;
        private System.Windows.Forms.Label labelStaticTR;
        private System.Windows.Forms.Label labelDynamicTimeLeft;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private Timer timer2;
        private Button button2;
    }
}

