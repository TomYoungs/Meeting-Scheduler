
namespace Meeting_Scheduler
{
    partial class home
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.userMeetingsCBox = new System.Windows.Forms.ComboBox();
            this.userProposedMeetingsCBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userSheduledMeetingsCBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "New Meeting";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(34, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "Preference";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(494, 269);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 45);
            this.button3.TabIndex = 2;
            this.button3.Text = "Edit Meeting";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // userMeetingsCBox
            // 
            this.userMeetingsCBox.FormattingEnabled = true;
            this.userMeetingsCBox.Location = new System.Drawing.Point(304, 277);
            this.userMeetingsCBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userMeetingsCBox.Name = "userMeetingsCBox";
            this.userMeetingsCBox.Size = new System.Drawing.Size(180, 28);
            this.userMeetingsCBox.TabIndex = 3;
            // 
            // userProposedMeetingsCBox
            // 
            this.userProposedMeetingsCBox.FormattingEnabled = true;
            this.userProposedMeetingsCBox.Location = new System.Drawing.Point(304, 385);
            this.userProposedMeetingsCBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userProposedMeetingsCBox.Name = "userProposedMeetingsCBox";
            this.userProposedMeetingsCBox.Size = new System.Drawing.Size(180, 28);
            this.userProposedMeetingsCBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 277);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "your meetings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 385);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "proposed meetings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 475);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "scheduled meetings";
            // 
            // userSheduledMeetingsCBox
            // 
            this.userSheduledMeetingsCBox.FormattingEnabled = true;
            this.userSheduledMeetingsCBox.Location = new System.Drawing.Point(304, 475);
            this.userSheduledMeetingsCBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userSheduledMeetingsCBox.Name = "userSheduledMeetingsCBox";
            this.userSheduledMeetingsCBox.Size = new System.Drawing.Size(180, 28);
            this.userSheduledMeetingsCBox.TabIndex = 8;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 742);
            this.Controls.Add(this.userSheduledMeetingsCBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userProposedMeetingsCBox);
            this.Controls.Add(this.userMeetingsCBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "home";
            this.Text = "home";
            this.Load += new System.EventHandler(this.home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox userMeetingsCBox;
        private System.Windows.Forms.ComboBox userProposedMeetingsCBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox userSheduledMeetingsCBox;
    }
}