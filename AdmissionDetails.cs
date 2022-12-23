using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace College
namespace ApplicationForStudentAdmission
>>>>>>> Stashed changes
{
    public enum AdmissionStatus{select,Admitted,Cancelled}
    public class AdmissionDetails
    {
        public static int s_admissionID=1000;
        public string AdmissionID{get;set;}
        public string StudentID{get;set;}
        public string DepartmentID{get;set;}
        public DateTime AdmissionDate{get;set;}
<<<<<<< Updated upstream
        public AdmissionStatus Admissionstatus{get;set;}
=======
        public AdmissionStatus AdmissionStatus{get;set;}
>>>>>>> Stashed changes
        public AdmissionDetails(string studentID,string departmentID,DateTime admissionDate,AdmissionStatus status)
        {
            s_admissionID++;
            AdmissionID="AID"+s_admissionID;
            StudentID=studentID;
            DepartmentID=departmentID;
            AdmissionDate=admissionDate;
<<<<<<< Updated upstream
            Admissionstatus=status;
=======
            AdmissionStatus=status;
>>>>>>> Stashed changes
        }
    }
}