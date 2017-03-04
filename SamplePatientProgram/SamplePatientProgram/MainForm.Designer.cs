namespace SamplePatientProgram
{
    partial class MainForm
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
            this.EnterNewPatientForm = new System.Windows.Forms.Button();
            this.viewPatientButton = new System.Windows.Forms.Button();
            this.createAppointmentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnterNewPatientForm
            // 
            this.EnterNewPatientForm.Location = new System.Drawing.Point(56, 65);
            this.EnterNewPatientForm.Name = "EnterNewPatientForm";
            this.EnterNewPatientForm.Size = new System.Drawing.Size(138, 30);
            this.EnterNewPatientForm.TabIndex = 0;
            this.EnterNewPatientForm.Text = "Enter New Patient";
            this.EnterNewPatientForm.UseVisualStyleBackColor = true;
            this.EnterNewPatientForm.Click += new System.EventHandler(this.EnterNewPatientForm_Click);
            // 
            // viewPatientButton
            // 
            this.viewPatientButton.Location = new System.Drawing.Point(56, 119);
            this.viewPatientButton.Name = "viewPatientButton";
            this.viewPatientButton.Size = new System.Drawing.Size(138, 29);
            this.viewPatientButton.TabIndex = 1;
            this.viewPatientButton.Text = "View Patient List";
            this.viewPatientButton.UseVisualStyleBackColor = true;
            this.viewPatientButton.Click += new System.EventHandler(this.viewPatientButton_Click);
            // 
            // createAppointmentButton
            // 
            this.createAppointmentButton.Location = new System.Drawing.Point(56, 185);
            this.createAppointmentButton.Name = "createAppointmentButton";
            this.createAppointmentButton.Size = new System.Drawing.Size(138, 27);
            this.createAppointmentButton.TabIndex = 2;
            this.createAppointmentButton.Text = "Create Appointment";
            this.createAppointmentButton.UseVisualStyleBackColor = true;
            this.createAppointmentButton.Click += new System.EventHandler(this.createAppointmentButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 468);
            this.Controls.Add(this.createAppointmentButton);
            this.Controls.Add(this.viewPatientButton);
            this.Controls.Add(this.EnterNewPatientForm);
            this.Name = "MainForm";
            this.Text = "Catchy Program Name Here";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EnterNewPatientForm;
        private System.Windows.Forms.Button viewPatientButton;
        private System.Windows.Forms.Button createAppointmentButton;
    }
}

