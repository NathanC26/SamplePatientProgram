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
    public class DoctorDBFunctions
    {
        public List<Doctor> GetListOfDoctors()
        {
            List<Doctor> doctorList = new List<Doctor>();

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Doctors", connection);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Doctor doctor = new Doctor();
                    doctor.ID = (int)reader["ID"];
                    doctor.name = (string)reader["Name"];
                    doctor.speciality = (string)reader["Speciality"];
                    doctorList.Add(doctor);
                }
                connection.Close();
            }
            return doctorList;
        }

        public DataTable GetDataTableOfDoctors()
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
                connection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = connection;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "SELECT * FROM Doctors";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataRecord = new DataTable();
                sqlDataAdapter.Fill(dataRecord);

                connection.Close();
                return dataRecord;
            }
        }
    }
}
