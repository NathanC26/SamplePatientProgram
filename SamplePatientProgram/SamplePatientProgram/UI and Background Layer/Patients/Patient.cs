using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace SamplePatientProgram
{
    public class Patient
    {
        public int ID { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public char gender { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
    }
}
