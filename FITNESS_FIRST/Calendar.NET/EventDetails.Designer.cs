namespace Calendar.NET
{
    partial class EventDetails
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
            this.eventName = new System.Windows.Forms.TextBox();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.gbBasics = new System.Windows.Forms.GroupBox();
            this.gbRecurringOptions = new System.Windows.Forms.GroupBox();
            this.chkThisDayForwardOnly = new System.Windows.Forms.CheckBox();
            this.cbRecurringFrequency = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btnOk = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.gbBasics.SuspendLayout();
            this.gbRecurringOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event Name:";
            // 
            // eventName
            // 
            this.eventName.Location = new System.Drawing.Point(111, 64);
            this.eventName.Name = "eventName";
            this.eventName.Size = new System.Drawing.Size(200, 20);
            this.eventName.TabIndex = 1;
            // 
            // startDate
            // 
            this.startDate.CustomFormat = "M/d/yyyy h:mm tt";
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDate.Location = new System.Drawing.Point(111, 13);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(200, 20);
            this.startDate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Event Start Date:";
            // 
            // gbBasics
            // 
            this.gbBasics.Controls.Add(this.label4);
            this.gbBasics.Controls.Add(this.endDate);
            this.gbBasics.Controls.Add(this.label2);
            this.gbBasics.Controls.Add(this.label1);
            this.gbBasics.Controls.Add(this.startDate);
            this.gbBasics.Controls.Add(this.eventName);
            this.gbBasics.Location = new System.Drawing.Point(12, 12);
            this.gbBasics.Name = "gbBasics";
            this.gbBasics.Size = new System.Drawing.Size(317, 102);
            this.gbBasics.TabIndex = 4;
            this.gbBasics.TabStop = false;
            this.gbBasics.Text = "Basics";
            // 
            // gbRecurringOptions
            // 
            this.gbRecurringOptions.Controls.Add(this.chkThisDayForwardOnly);
            this.gbRecurringOptions.Controls.Add(this.cbRecurringFrequency);
            this.gbRecurringOptions.Controls.Add(this.label3);
            this.gbRecurringOptions.Location = new System.Drawing.Point(12, 133);
            this.gbRecurringOptions.Name = "gbRecurringOptions";
            this.gbRecurringOptions.Size = new System.Drawing.Size(323, 68);
            this.gbRecurringOptions.TabIndex = 5;
            this.gbRecurringOptions.TabStop = false;
            this.gbRecurringOptions.Text = "Recurring Options";
            // 
            // chkThisDayForwardOnly
            // 
            this.chkThisDayForwardOnly.AutoSize = true;
            this.chkThisDayForwardOnly.Location = new System.Drawing.Point(8, 48);
            this.chkThisDayForwardOnly.Name = "chkThisDayForwardOnly";
            this.chkThisDayForwardOnly.Size = new System.Drawing.Size(109, 17);
            this.chkThisDayForwardOnly.TabIndex = 2;
            this.chkThisDayForwardOnly.Text = "This Day Forward";
            this.chkThisDayForwardOnly.UseVisualStyleBackColor = true;
            // 
            // cbRecurringFrequency
            // 
            this.cbRecurringFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRecurringFrequency.FormattingEnabled = true;
            this.cbRecurringFrequency.Location = new System.Drawing.Point(117, 17);
            this.cbRecurringFrequency.Name = "cbRecurringFrequency";
            this.cbRecurringFrequency.Size = new System.Drawing.Size(200, 21);
            this.cbRecurringFrequency.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Recurring Frequency:";
            // 
            // fontDialog1
            // 
            this.fontDialog1.ScriptsOnly = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(12, 216);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "&OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOkClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(261, 216);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Event End Date:";
            // 
            // endDate
            // 
            this.endDate.CustomFormat = "M/d/yyyy h:mm tt";
            this.endDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDate.Location = new System.Drawing.Point(111, 38);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(200, 20);
            this.endDate.TabIndex = 4;
            // 
            // EventDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 257);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.gbRecurringOptions);
            this.Controls.Add(this.gbBasics);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EventDetails";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EventDetails";
            this.gbBasics.ResumeLayout(false);
            this.gbBasics.PerformLayout();
            this.gbRecurringOptions.ResumeLayout(false);
            this.gbRecurringOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox eventName;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbBasics;
        private System.Windows.Forms.GroupBox gbRecurringOptions;
        private System.Windows.Forms.ComboBox cbRecurringFrequency;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkThisDayForwardOnly;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker endDate;
    }
}