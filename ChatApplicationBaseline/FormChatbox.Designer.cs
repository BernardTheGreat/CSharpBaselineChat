namespace ChatApplicationBaseline
{
    partial class FormChatbox
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
            this.chatBoxRichTxtBox = new System.Windows.Forms.RichTextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.messageTxtbox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // chatBoxRichTxtBox
            // 
            this.chatBoxRichTxtBox.Location = new System.Drawing.Point(31, 34);
            this.chatBoxRichTxtBox.Name = "chatBoxRichTxtBox";
            this.chatBoxRichTxtBox.ReadOnly = true;
            this.chatBoxRichTxtBox.Size = new System.Drawing.Size(330, 164);
            this.chatBoxRichTxtBox.TabIndex = 5;
            this.chatBoxRichTxtBox.Text = "";
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(31, 230);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(146, 41);
            this.sendBtn.TabIndex = 4;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // messageTxtbox
            // 
            this.messageTxtbox.Location = new System.Drawing.Point(31, 204);
            this.messageTxtbox.Name = "messageTxtbox";
            this.messageTxtbox.Size = new System.Drawing.Size(330, 20);
            this.messageTxtbox.TabIndex = 3;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // FormChatbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 284);
            this.Controls.Add(this.chatBoxRichTxtBox);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.messageTxtbox);
            this.Name = "FormChatbox";
            this.Text = "Chatbox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormChatbox_FormClosing);
            this.Shown += new System.EventHandler(this.FormChatbox_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox chatBoxRichTxtBox;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.TextBox messageTxtbox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

