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
using System.Web;

namespace SamplePatientProgram
{
    public partial class ViewPatientsForm : Form
    {
        PatientDBFunctions patientFunctions = new PatientDBFunctions();

        public ViewPatientsForm()
        {
            InitializeComponent();

            DataTable patientDataTable = patientFunctions.GetDataTableOfPatients();
            patientListGridView.DataSource = patientDataTable;
        }
    }
}
