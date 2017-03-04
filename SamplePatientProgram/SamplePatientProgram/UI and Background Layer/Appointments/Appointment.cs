using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePatientProgram
{
    public class Appointment
    {
        public DateTime dateAndTime { get; set; }
        public int patientID { get; set; }
        public int doctorID { get; set; }
    }
}
