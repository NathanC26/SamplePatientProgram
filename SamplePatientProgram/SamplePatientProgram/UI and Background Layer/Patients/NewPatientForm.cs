using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace SamplePatientProgram
{
    public partial class NewPatientForm : Form
    {
        PatientDBFunctions patientFunctions = new PatientDBFunctions();

        public NewPatientForm()
        {
            InitializeComponent();
        }

        private void createNewPatientButton_Click(object sender, EventArgs e)
        {
            if (ValidateNewPatient())
            {
                AddNewPatientToDB();
            }
        }

        public bool ValidateNewPatient()
        {
            string errorMessage = "";

            /* can add a series of checks here if needed*/

            if (nameTextBox.Text.Length == 0)
                errorMessage = "Please enter a Name.";


            if (errorMessage.Length > 0)
            {
                MessageBox.Show(errorMessage);
                return false;
            }
            return true;
        }

        public void AddNewPatientToDB()
        { 
            Patient patient = new Patient();
            patient.name = nameTextBox.Text;
            patient.age = (int)ageNumericUpDown.Value;

            if (maleRadioButton.Checked)
                patient.gender = 'M';
            else if (femaleRadioButton.Checked)
                patient.gender = 'F';
            else
                patient.gender = ' ';

            patient.email = emailTextBox.Text;
            patient.phone = phoneTextBox.Text;

            string errorString = patientFunctions.AddNewPatientToDB(patient);
            if(errorString.Length > 0)
            {
                MessageBox.Show("There was an error saving the Patient." + "\n" + errorString);
            }
            else
            {
                MessageBox.Show("Patient Saved Successfully.");
                ClearPatientFields();
            }
        }

        public void ClearPatientFields()
        {
            nameTextBox.Text = "";
            emailTextBox.Text = "";
            phoneTextBox.Text = "";
        }

        private void backToMainButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
