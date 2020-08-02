namespace HelloworldOutlook
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxProject = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTaskDescription = new System.Windows.Forms.TextBox();
            this.labelHours = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.checkBoxBillable = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFromTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerToTime = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // comboBoxProject
            // 
            this.comboBoxProject.FormattingEnabled = true;
            this.comboBoxProject.Items.AddRange(new object[] {
            resources.GetString("comboBoxProject.Items"),
            resources.GetString("comboBoxProject.Items1"),
            resources.GetString("comboBoxProject.Items2")});
            resources.ApplyResources(this.comboBoxProject, "comboBoxProject");
            this.comboBoxProject.Name = "comboBoxProject";
            this.comboBoxProject.SelectedIndexChanged += new System.EventHandler(this.comboBoxProject_SelectedIndexChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // textBoxTaskDescription
            // 
            resources.ApplyResources(this.textBoxTaskDescription, "textBoxTaskDescription");
            this.textBoxTaskDescription.Name = "textBoxTaskDescription";
            this.textBoxTaskDescription.TextChanged += new System.EventHandler(this.textBoxTaskDesc_TextChanged);
            // 
            // labelHours
            // 
            resources.ApplyResources(this.labelHours, "labelHours");
            this.labelHours.Name = "labelHours";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            resources.ApplyResources(this.buttonSubmit, "buttonSubmit");
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonCancel
            // 
            resources.ApplyResources(this.buttonCancel, "buttonCancel");
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // checkBoxBillable
            // 
            resources.ApplyResources(this.checkBoxBillable, "checkBoxBillable");
            this.checkBoxBillable.Name = "checkBoxBillable";
            this.checkBoxBillable.UseVisualStyleBackColor = true;
            this.checkBoxBillable.CheckedChanged += new System.EventHandler(this.checkBoxBillable_CheckedChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // dateTimePickerDate
            // 
            resources.ApplyResources(this.dateTimePickerDate, "dateTimePickerDate");
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.ValueChanged += new System.EventHandler(this.dateTimePickerDate_ValueChanged);
            // 
            // dateTimePickerFromTime
            // 
            this.dateTimePickerFromTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            resources.ApplyResources(this.dateTimePickerFromTime, "dateTimePickerFromTime");
            this.dateTimePickerFromTime.Name = "dateTimePickerFromTime";
            this.dateTimePickerFromTime.ShowUpDown = true;
            this.dateTimePickerFromTime.UseWaitCursor = true;
            this.dateTimePickerFromTime.ValueChanged += new System.EventHandler(this.dateTimePickerFromTime_ValueChanged);
            // 
            // dateTimePickerToTime
            // 
            this.dateTimePickerToTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            resources.ApplyResources(this.dateTimePickerToTime, "dateTimePickerToTime");
            this.dateTimePickerToTime.Name = "dateTimePickerToTime";
            this.dateTimePickerToTime.ShowUpDown = true;
            this.dateTimePickerToTime.ValueChanged += new System.EventHandler(this.dateTimePickerToTime_ValueChanged);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ControlText;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ControlText;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePickerToTime);
            this.Controls.Add(this.dateTimePickerFromTime);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBoxBillable);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelHours);
            this.Controls.Add(this.textBoxTaskDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxProject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxProject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTaskDescription;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.CheckBox checkBoxBillable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerFromTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerToTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}