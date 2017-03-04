using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SamplePatientProgram
{
    public partial class CreateAppointmentForm : Form
    {
        PatientDBFunctions patientFunctions = new PatientDBFunctions();
        DoctorDBFunctions doctorFunctions = new DoctorDBFunctions();
        AppointmentDBFunctions appointmentFunctions = new AppointmentDBFunctions();

        public CreateAppointmentForm()
        {
            InitializeComponent();

            List<Patient> patientList = patientFunctions.GetListOfPatients();
            selectPatientComboBox.DataSource = patientList;
            selectPatientComboBox.DisplayMember = "Name";

            List<Doctor> doctorList = doctorFunctions.GetListOfDoctors();
            selectDoctorComboBox.DataSource = doctorList;
            selectDoctorComboBox.DisplayMember = "Name";

            LoadAppointmentsForDay();
        }

        public void LoadAppointmentsForDay()
        {
            string selectedDate = apptDateTime.Value.Date.ToShortDateString();
            DataTable appointmentDataTable = appointmentFunctions.GetDataTableOfAppointments(selectedDate);
            dailyApptGridView.DataSource = appointmentDataTable;
        }

        private void apptDateTime_ValueChanged(object sender, EventArgs e)
        {
            LoadAppointmentsForDay();
        }

        private void createAppointmentButton_Click(object sender, EventArgs e)
        {
            if (ValidateNewAppointment())
            {
                AddNewAppointmentToDB();
                LoadAppointmentsForDay();
            }
        }

        public bool ValidateNewAppointment()
        {
            string errorMessage = "";

            /* can add a series of checks here if needed*/

            if (selectPatientComboBox.SelectedIndex == -1)
                errorMessage = "Please select a Patient." + "\n";

            if (selectPatientComboBox.SelectedIndex == -1)
                errorMessage += "Please select a Doctor." + "\n";

            if (errorMessage.Length > 0)
            {
                MessageBox.Show(errorMessage);
                return false;
            }
            return true;
        }

        public void AddNewAppointmentToDB()
        {
            Appointment appointment = new Appointment();
            Patient patient = (Patient)selectPatientComboBox.SelectedItem;
            appointment.patientID = patient.ID;
            Doctor doctor = (Doctor)selectDoctorComboBox.SelectedItem;
            appointment.doctorID = doctor.ID;
            string selectedDate = apptDateTime.Value.Date.ToShortDateString();
            appointment.dateAndTime = apptDateTime.Value.Date;
            string errorString = appointmentFunctions.AddNewAppointmentToDB(appointment);
            if (errorString.Length > 0)
            {
                MessageBox.Show("There was an error saving the Appointment." + "\n" + errorString);
            }
            else
            {
                MessageBox.Show("Appointment Saved Successfully.");
            }
        }
    }
}
