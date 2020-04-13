namespace ChatApplicationBaseline
{
    partial class FormLogin
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
            this.usernameTxtbox = new System.Windows.Forms.TextBox();
            this.passwordTxtbox = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.loginQueryBckgrndWrkr = new System.ComponentModel.BackgroundWorker();
            this.labelcheckUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameTxtbox
            // 
            this.usernameTxtbox.Location = new System.Drawing.Point(84, 52);
            this.usernameTxtbox.Name = "usernameTxtbox";
            this.usernameTxtbox.Size = new System.Drawing.Size(136, 20);
            this.usernameTxtbox.TabIndex = 0;
            // 
            // passwordTxtbox
            // 
            this.passwordTxtbox.Location = new System.Drawing.Point(84, 105);
            this.passwordTxtbox.Name = "passwordTxtbox";
            this.passwordTxtbox.Size = new System.Drawing.Size(136, 20);
            this.passwordTxtbox.TabIndex = 1;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(84, 165);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(136, 44);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // loginQueryBckgrndWrkr
            // 
            this.loginQueryBckgrndWrkr.WorkerReportsProgress = true;
            this.loginQueryBckgrndWrkr.DoWork += new System.ComponentModel.DoWorkEventHandler(this.loginQueryBckgrndWrkr_DoWork);
            this.loginQueryBckgrndWrkr.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.loginQueryBckgrndWrkr_RunWorkerCompleted);
            // 
            // labelcheckUser
            // 
            this.labelcheckUser.AutoSize = true;
            this.labelcheckUser.BackColor = System.Drawing.SystemColors.Control;
            this.labelcheckUser.Font = new System.Drawing.Font("Wingdings", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.labelcheckUser.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelcheckUser.Location = new System.Drawing.Point(56, 55);
            this.labelcheckUser.Name = "labelcheckUser";
            this.labelcheckUser.Size = new System.Drawing.Size(22, 17);
            this.labelcheckUser.TabIndex = 3;
            this.labelcheckUser.Text = "";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.labelcheckUser);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordTxtbox);
            this.Controls.Add(this.usernameTxtbox);
            this.Name = "FormLogin";
            this.Text = "User Login";
            this.Shown += new System.EventHandler(this.FormLogin_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTxtbox;
        private System.Windows.Forms.TextBox passwordTxtbox;
        private System.Windows.Forms.Button loginBtn;
        private System.ComponentModel.BackgroundWorker loginQueryBckgrndWrkr;
        private System.Windows.Forms.Label labelcheckUser;

    }
}