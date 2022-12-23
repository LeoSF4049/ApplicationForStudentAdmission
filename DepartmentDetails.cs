using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationForStudentAdmission
{

    public class DepartmentDetails
    {
        private static int s_departmentID = 100;


        public string DepartmentName { get; set; }

        public int NumberOfSeats { get; set; }

        public string DepartmentID { get; }



        public DepartmentDetails(string departmentName, int numberOfSeats)
        {
            s_departmentID++;
            DepartmentID = "DID" + s_departmentID;
            DepartmentName = departmentName;
            NumberOfSeats = numberOfSeats;
        }

    }
}