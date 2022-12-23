using System;

namespace ApplicationForStudentAdmission
{
    //Enum
    /// <summary>
    /// Gender is a enum type of namespace property used to select gender of a student 
    /// </summary>
    public enum Gender{Select,Male,Female,Transgender}
    //class
    /// <summary>
    /// <see cref="StudentDetails" /> is a  class used to set and get data from a students
    /// </summary>
    public class StudentDetails
    {
        /// <summary>
        /// Field student ID is integer type of satic value used to assign specific ID for a student 
        /// </summary>
       private static int s_studentID=3000;
       /// <summary>
       /// Property studentId used to spicify unique value from field studentId
       /// </summary>
       /// <value></value>
       public string StudentID { get; }
       /// <summary>
       /// Property name used to get and set a value and used to return specific student name
       /// </summary>
       /// <value></value>
       public string Name{get;set;} 
       /// <summary>
       /// Property Father name is a string type of value get from user
       /// </summary>
       /// <value></value>
       public string FatherName { get; set; }
       /// <summary>
       /// Property Gender is a enum type of value used to select gender from a given option
       /// </summary>
       /// <value></value>
       public Gender Gender { get; set; }
       /// <summary>
       /// Property DOB is a DateTime type of value used to get date of birth of a student
       /// </summary>
       /// <value>Date of Birth between 2001 to 2003</value>
       public DateTime DOB { get; set; }
       /// <summary>
       /// Property phone is a Long type of value get from student
       /// </summary>
       /// <value></value>

       public long PhoneNo { get; set; }
       /// <summary>
       /// Property Physics is a integer type of value get from user
       /// </summary>
       /// <value>Value limit 0 to 100</value>

       public int Physics { get; set; }
       /// <summary>
       /// Property Chemistry is a integer type of value get from user
       /// </summary>
       /// <value>Value limit 0 to 100</value>

       public int Chemistry { get; set; }
       /// <summary>
       /// Property Maths is a integer type of value get from user
       /// </summary>
       /// <value>Value limit 0 to 100</value>

       public int Maths { get; set; }
       /// <summary>
       /// <see cref="StudentDetails" /> is a class used to get and return a detalis of a student
       /// </summary>

       public StudentDetails()
       {
        Name="Your Name";
        FatherName="Your Father Name";
        Gender=Gender.Select;
       }
       /// <summary>
       /// <see cref="StudentDetails" /> is a class to assign value to object
       /// </summary>
       /// <param name="name">name parameter used to get string type of value from user</param>
       /// <param name="fatherName">father name parameter used to get string type of value from user</param>
       /// <param name="gender">gender parameter used to select Gender type of value from user</param>
       /// <param name="dob">dob parameter used to get DateTime type of value from user</param>
       /// <param name="phone">phone parameter used to get long type of value from user</param>
       /// <param name="physics">physics parameter used to get mark from user</param>
       /// <param name="chemistry">chemistry parameter used to get mark from user</param>
       /// <param name="maths">maths parameter used to get mark from user</param>
       public StudentDetails(string name,string fatherName,DateTime dob, Gender gender,
       long phoneNo,int physics,int chemistry,int maths)
       {
        s_studentID++;
        StudentID="SF"+s_studentID;
        Name=name;
        FatherName=fatherName;
        Gender=gender;
        DOB=dob;
        PhoneNo=phoneNo;
        Physics=physics;
        Chemistry=chemistry;
        Maths=maths;
       }

       
       /// <summary>
       /// CheckEligibility is a method to check eligibility of a student with CUTOFF using student physics,
       /// chemistry,maths total marks 
       /// </summary>
       /// <param name="cutOFF">cutoff used to calculate the average percentage from student marks</param>
       /// <returns></returns>

       public bool CheckEligibility(double cutOff)
       {
        int total=Physics+Chemistry+Maths;
        double average=(double)total/3;

        bool result=false;
        if(average>=cutOff)
        {
         result=true;
        }
        return result;
       }
    }
}