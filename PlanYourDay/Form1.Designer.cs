namespace PlanYourDay.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.grpBox_SyncWithFriends = new System.Windows.Forms.GroupBox();
            this.txtBox_Mail = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.grpBox_SyncWithFriends.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(578, 18);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // grpBox_SyncWithFriends
            // 
            this.grpBox_SyncWithFriends.Controls.Add(this.btnFind);
            this.grpBox_SyncWithFriends.Controls.Add(this.txtBox_Mail);
            this.grpBox_SyncWithFriends.Location = new System.Drawing.Point(578, 192);
            this.grpBox_SyncWithFriends.Name = "grpBox_SyncWithFriends";
            this.grpBox_SyncWithFriends.Size = new System.Drawing.Size(227, 109);
            this.grpBox_SyncWithFriends.TabIndex = 1;
            this.grpBox_SyncWithFriends.TabStop = false;
            this.grpBox_SyncWithFriends.Text = "Sync with your friends";
            // 
            // txtBox_Mail
            // 
            this.txtBox_Mail.Location = new System.Drawing.Point(6, 22);
            this.txtBox_Mail.Name = "txtBox_Mail";
            this.txtBox_Mail.Size = new System.Drawing.Size(215, 23);
            this.txtBox_Mail.TabIndex = 0;
            this.txtBox_Mail.Text = "Mail";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(68, 51);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 766);
            this.Controls.Add(this.grpBox_SyncWithFriends);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpBox_SyncWithFriends.ResumeLayout(false);
            this.grpBox_SyncWithFriends.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.GroupBox grpBox_SyncWithFriends;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtBox_Mail;
    }
}