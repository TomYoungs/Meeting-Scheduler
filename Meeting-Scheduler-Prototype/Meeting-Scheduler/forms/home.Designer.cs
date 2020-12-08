
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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "New Meeting";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(31, 52);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "Preference";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(393, 122);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 36);
            this.button3.TabIndex = 2;
            this.button3.Text = "Edit Meeting";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "your meetings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 268);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "proposed meetings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 412);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "scheduled meetings";
            // 
            // checkedListYourM
            // 
            this.checkedListYourM.FormattingEnabled = true;
            this.checkedListYourM.Location = new System.Drawing.Point(227, 122);
            this.checkedListYourM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkedListYourM.Name = "checkedListYourM";
            this.checkedListYourM.Size = new System.Drawing.Size(159, 106);
            this.checkedListYourM.TabIndex = 9;
            this.checkedListYourM.SelectedIndexChanged += new System.EventHandler(this.checkedListYourM_SelectedIndexChanged);
            // 
            // checkedListProposedM
            // 
            this.checkedListProposedM.FormattingEnabled = true;
            this.checkedListProposedM.Location = new System.Drawing.Point(227, 268);
            this.checkedListProposedM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkedListProposedM.Name = "checkedListProposedM";
            this.checkedListProposedM.Size = new System.Drawing.Size(159, 106);
            this.checkedListProposedM.TabIndex = 10;
            this.checkedListProposedM.SelectedIndexChanged += new System.EventHandler(this.checkedListProposedM_SelectedIndexChanged);
            // 
            // checkedListSheduledM
            // 
            this.checkedListSheduledM.FormattingEnabled = true;
            this.checkedListSheduledM.Location = new System.Drawing.Point(227, 412);
            this.checkedListSheduledM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkedListSheduledM.Name = "checkedListSheduledM";
            this.checkedListSheduledM.Size = new System.Drawing.Size(159, 106);
            this.checkedListSheduledM.TabIndex = 11;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(271, 85);
            this.errorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 17);
            this.errorLabel.TabIndex = 12;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(660, 593);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
    }
}