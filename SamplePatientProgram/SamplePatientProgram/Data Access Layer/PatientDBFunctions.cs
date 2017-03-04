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
    public class PatientDBFunctions
    {
        public DataTable GetDataTableOfPatients()
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
                connection.Open();
                                                                                             
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = connection;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "SELECT * FROM Patients";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataRecord = new DataTable();
                sqlDataAdapter.Fill(dataRecord);

                connection.Close();
                return dataRecord;
            }
        }


        public string AddNewPatientToDB(Patient patient)
        {
            string errorString = "";

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
                connection.Open();

                string sql = "INSERT INTO Patients(name, age, gender, email, phone) VALUES(@name, @age, @gender, @email, @phone)";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.Add("@name", SqlDbType.VarChar, 50);
                command.Parameters.Add("@age", SqlDbType.TinyInt);
                command.Parameters.Add("@gender", SqlDbType.VarChar, 1);
                command.Parameters.Add("@email", SqlDbType.VarChar, 30);
                command.Parameters.Add("@phone", SqlDbType.VarChar, 10);

                command.Parameters["@name"].Value = patient.name;
                command.Parameters["@age"].Value = patient.age;
                command.Parameters["@gender"].Value = patient.gender;
                command.Parameters["@email"].Value = patient.email;
                command.Parameters["@phone"].Value = patient.phone;

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

        public List<Patient> GetListOfPatients()
        {
            List<Patient> patientList = new List<Patient>();

            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Patients", sqlConnection);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Patient patient = new Patient();
                    patient.ID = (int)reader["ID"];
                    patient.name = (string)reader["Name"];
                    /*patient.age = (int)reader["Age"];
                    patient.gender = (char)reader["Gender"];*/
                    patient.phone = (string)reader["Phone"];
                    patient.email = (string)reader["Email"];
                    patientList.Add(patient);
                }
                sqlConnection.Close();
            }
            return patientList;
        }


    } // end of class PatientDBFunctions
} // end of namespace
