﻿
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkedListYourM = new System.Windows.Forms.CheckedListBox();
            this.checkedListProposedM = new System.Windows.Forms.CheckedListBox();
            this.checkedListSheduledM = new System.Windows.Forms.CheckedListBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.btnAcceptProposal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "New Meeting";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 42);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Preference";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(378, 99);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 29);
            this.button3.TabIndex = 2;
            this.button3.Text = "Edit Meeting";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "your meetings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "proposed meetings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "scheduled meetings";
            // 
            // checkedListYourM
            // 
            this.checkedListYourM.FormattingEnabled = true;
            this.checkedListYourM.HorizontalScrollbar = true;
            this.checkedListYourM.Location = new System.Drawing.Point(132, 99);
            this.checkedListYourM.Name = "checkedListYourM";
            this.checkedListYourM.Size = new System.Drawing.Size(241, 79);
            this.checkedListYourM.TabIndex = 9;
            this.checkedListYourM.SelectedIndexChanged += new System.EventHandler(this.checkedListYourM_SelectedIndexChanged);
            // 
            // checkedListProposedM
            // 
            this.checkedListProposedM.FormattingEnabled = true;
            this.checkedListProposedM.HorizontalScrollbar = true;
            this.checkedListProposedM.Location = new System.Drawing.Point(132, 218);
            this.checkedListProposedM.Name = "checkedListProposedM";
            this.checkedListProposedM.Size = new System.Drawing.Size(241, 79);
            this.checkedListProposedM.TabIndex = 10;
            // 
            // checkedListSheduledM
            // 
            this.checkedListSheduledM.FormattingEnabled = true;
            this.checkedListSheduledM.HorizontalScrollbar = true;
            this.checkedListSheduledM.Location = new System.Drawing.Point(132, 335);
            this.checkedListSheduledM.Name = "checkedListSheduledM";
            this.checkedListSheduledM.Size = new System.Drawing.Size(241, 79);
            this.checkedListSheduledM.TabIndex = 11;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(203, 69);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 12;
            // 
            // btnAcceptProposal
            // 
            this.btnAcceptProposal.Location = new System.Drawing.Point(378, 218);
            this.btnAcceptProposal.Margin = new System.Windows.Forms.Padding(2);
            this.btnAcceptProposal.Name = "btnAcceptProposal";
            this.btnAcceptProposal.Size = new System.Drawing.Size(79, 29);
            this.btnAcceptProposal.TabIndex = 14;
            this.btnAcceptProposal.Text = "Accept";
            this.btnAcceptProposal.UseVisualStyleBackColor = true;
            this.btnAcceptProposal.Click += new System.EventHandler(this.btnAcceptProposal_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(495, 482);
            this.Controls.Add(this.btnAcceptProposal);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.checkedListSheduledM);
            this.Controls.Add(this.checkedListProposedM);
            this.Controls.Add(this.checkedListYourM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox checkedListYourM;
        private System.Windows.Forms.CheckedListBox checkedListProposedM;
        private System.Windows.Forms.CheckedListBox checkedListSheduledM;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button btnAcceptProposal;
    }
}