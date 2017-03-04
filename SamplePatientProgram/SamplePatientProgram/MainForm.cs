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

namespace SamplePatientProgram
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void EnterNewPatientForm_Click(object sender, EventArgs e)
        {
            NewPatientForm form = new NewPatientForm();
            form.Show();
        }

        private void viewPatientButton_Click(object sender, EventArgs e)
        {
            ViewPatientsForm form = new ViewPatientsForm();
            form.Show();
        }

        private void createAppointmentButton_Click(object sender, EventArgs e)
        {
            CreateAppointmentForm form = new CreateAppointmentForm();
            form.Show();
        }

        public List<Patient> GetListOfPatients()
        {
            List<Patient> patientList = new List<Patient>();

            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Patients", sqlConnection);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Patient patient = new Patient();
                    patient.name = (string)reader["Name"];
                    patient.age = (int)reader["Age"];
                    patient.gender = (char)reader["Gender"];
                    patient.phone = (string)reader["Phone"];
                    patient.email = (string)reader["Email"];
                    patientList.Add(patient);
                }
                sqlConnection.Close();
            }

            return patientList;
        }

        public DataTable GetAllPatients()
        {
            SqlConnection connection = new SqlConnection();

            connection.ConnectionString = "Server=localhost; Database=PatientAppDB; Integrated Security=True;";
            connection.Open();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "SELECT * FROM Patients";
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCommand);

            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);

            connection.Close();

            return dtRecord;
        }
    }
}
