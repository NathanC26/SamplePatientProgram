namespace SamplePatientProgram
{
    partial class CreateAppointmentForm
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
            this.selectPatientComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dailyApptGridView = new System.Windows.Forms.DataGridView();
            this.apptDateTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.selectDoctorLabel = new System.Windows.Forms.Label();
            this.selectDoctorComboBox = new System.Windows.Forms.ComboBox();
            this.createAppointmentButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dailyApptGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // selectPatientComboBox
            // 
            this.selectPatientComboBox.DisplayMember = "Name";
            this.selectPatientComboBox.FormattingEnabled = true;
            this.selectPatientComboBox.Location = new System.Drawing.Point(182, 26);
            this.selectPatientComboBox.Name = "selectPatientComboBox";
            this.selectPatientComboBox.Size = new System.Drawing.Size(180, 21);
            this.selectPatientComboBox.TabIndex = 0;
            this.selectPatientComboBox.ValueMember = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Patient";
            // 
            // dailyApptGridView
            // 
            this.dailyApptGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dailyApptGridView.Location = new System.Drawing.Point(25, 178);
            this.dailyApptGridView.Name = "dailyApptGridView";
            this.dailyApptGridView.Size = new System.Drawing.Size(645, 242);
            this.dailyApptGridView.TabIndex = 4;
            // 
            // apptDateTime
            // 
            this.apptDateTime.Location = new System.Drawing.Point(182, 123);
            this.apptDateTime.Name = "apptDateTime";
            this.apptDateTime.Size = new System.Drawing.Size(200, 20);
            this.apptDateTime.TabIndex = 5;
            this.apptDateTime.ValueChanged += new System.EventHandler(this.apptDateTime_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select Date";
            // 
            // selectDoctorLabel
            // 
            this.selectDoctorLabel.AutoSize = true;
            this.selectDoctorLabel.Location = new System.Drawing.Point(23, 79);
            this.selectDoctorLabel.Name = "selectDoctorLabel";
            this.selectDoctorLabel.Size = new System.Drawing.Size(72, 13);
            this.selectDoctorLabel.TabIndex = 2;
            this.selectDoctorLabel.Text = "Select Doctor";
            // 
            // selectDoctorComboBox
            // 
            this.selectDoctorComboBox.FormattingEnabled = true;
            this.selectDoctorComboBox.Location = new System.Drawing.Point(182, 76);
            this.selectDoctorComboBox.Name = "selectDoctorComboBox";
            this.selectDoctorComboBox.Size = new System.Drawing.Size(180, 21);
            this.selectDoctorComboBox.TabIndex = 3;
            // 
            // createAppointmentButton
            // 
            this.createAppointmentButton.Location = new System.Drawing.Point(532, 26);
            this.createAppointmentButton.Name = "createAppointmentButton";
            this.createAppointmentButton.Size = new System.Drawing.Size(138, 34);
            this.createAppointmentButton.TabIndex = 7;
            this.createAppointmentButton.Text = "Create Appointment";
            this.createAppointmentButton.UseVisualStyleBackColor = true;
            this.createAppointmentButton.Click += new System.EventHandler(this.createAppointmentButton_Click);
            // 
            // CreateAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 455);
            this.Controls.Add(this.createAppointmentButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.apptDateTime);
            this.Controls.Add(this.dailyApptGridView);
            this.Controls.Add(this.selectDoctorComboBox);
            this.Controls.Add(this.selectDoctorLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectPatientComboBox);
            this.Name = "CreateAppointmentForm";
            this.Text = "CreateAppointmentForm";
            ((System.ComponentModel.ISupportInitialize)(this.dailyApptGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox selectPatientComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dailyApptGridView;
        private System.Windows.Forms.DateTimePicker apptDateTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label selectDoctorLabel;
        private System.Windows.Forms.ComboBox selectDoctorComboBox;
        private System.Windows.Forms.Button createAppointmentButton;
    }
}