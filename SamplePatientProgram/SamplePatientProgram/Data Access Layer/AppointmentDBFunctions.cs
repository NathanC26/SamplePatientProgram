using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace SamplePatientProgram
{
    public class AppointmentDBFunctions
    {
        public DataTable GetDataTableOfAppointments(string selectedDate)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
                connection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = connection;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "SELECT Patients.Name, Doctors.Name, Appointments.DateTime FROM Appointments " +
                                         "LEFT JOIN Patients ON Appointments.PatientID = Patients.ID " +
                                         "LEFT JOIN Doctors ON Appointments.DoctorID = Doctors.ID " +
                                         "WHERE DateTime between '" + selectedDate + "' AND '" + selectedDate + " 23:59:59'";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataRecord = new DataTable();
                sqlDataAdapter.Fill(dataRecord);

                connection.Close();
                return dataRecord;
            }
        }

        public string AddNewAppointmentToDB(Appointment appointment)
        {
            string errorString = "";

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
                connection.Open();

                string sql = "INSERT INTO Appointments(PatientID, DoctorID, DateTime) VALUES(@PatientID, @DoctorID, @DateTime)";

                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.Add("@PatientID", SqlDbType.Int);
                command.Parameters.Add("@DoctorID", SqlDbType.Int);
                command.Parameters.Add("@DateTime", SqlDbType.DateTime);

                command.Parameters["@PatientID"].Value = appointment.patientID;
                command.Parameters["@DoctorID"].Value = appointment.doctorID;
                command.Parameters["@DateTime"].Value = appointment.dateAndTime;

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    errorString = ex.ToString();
                }
                finally
                {
                    connection.Close();
                }
            }
            return errorString;
        }
    }
}
