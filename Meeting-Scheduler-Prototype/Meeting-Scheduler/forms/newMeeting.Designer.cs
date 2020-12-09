
namespace Meeting_Scheduler
{
    partial class newMeeting
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.checkedListParticipants = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEquipment = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.checkedListSlots = new System.Windows.Forms.CheckedListBox();
            this.timeSlotError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Meeting Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Participants";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 273);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prefered time slot";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(11, 24);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(202, 20);
            this.txtTitle.TabIndex = 5;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(11, 60);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(202, 20);
            this.txtDesc.TabIndex = 6;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(9, 469);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // checkedListParticipants
            // 
            this.checkedListParticipants.FormattingEnabled = true;
            this.checkedListParticipants.Location = new System.Drawing.Point(9, 193);
            this.checkedListParticipants.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkedListParticipants.Name = "checkedListParticipants";
            this.checkedListParticipants.Size = new System.Drawing.Size(202, 49);
            this.checkedListParticipants.TabIndex = 11;
            this.checkedListParticipants.SelectedIndexChanged += new System.EventHandler(this.checkedListParticipants_SelectedIndexChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Equipment";
            // 
            // txtEquipment
            // 
            this.txtEquipment.Location = new System.Drawing.Point(11, 96);
            this.txtEquipment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEquipment.Name = "txtEquipment";
            this.txtEquipment.Size = new System.Drawing.Size(202, 20);
            this.txtEquipment.TabIndex = 13;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(11, 140);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(202, 20);
            this.txtLocation.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 125);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Location";
            // 
            // dataTimePicker
            // 
            this.dataTimePicker.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dataTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataTimePicker.Location = new System.Drawing.Point(9, 292);
            this.dataTimePicker.Name = "dataTimePicker";
            this.dataTimePicker.Size = new System.Drawing.Size(202, 20);
            this.dataTimePicker.TabIndex = 18;
            this.dataTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(217, 292);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(43, 20);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // checkedListSlots
            // 
            this.checkedListSlots.FormattingEnabled = true;
            this.checkedListSlots.Location = new System.Drawing.Point(9, 317);
            this.checkedListSlots.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkedListSlots.Name = "checkedListSlots";
            this.checkedListSlots.Size = new System.Drawing.Size(202, 94);
            this.checkedListSlots.TabIndex = 20;
            // 
            // timeSlotError
            // 
            this.timeSlotError.AutoSize = true;
            this.timeSlotError.Location = new System.Drawing.Point(217, 319);
            this.timeSlotError.Name = "timeSlotError";
            this.timeSlotError.Size = new System.Drawing.Size(0, 13);
            this.timeSlotError.TabIndex = 21;
            // 
            // newMeeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(455, 513);
            this.Controls.Add(this.timeSlotError);
            this.Controls.Add(this.checkedListSlots);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtEquipment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkedListParticipants);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "newMeeting";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.newMeeting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.CheckedListBox checkedListParticipants;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEquipment;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dataTimePicker;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckedListBox checkedListSlots;
        private System.Windows.Forms.Label timeSlotError;
    }
}