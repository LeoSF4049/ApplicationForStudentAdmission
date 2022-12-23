using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationForStudentAdmission
{
    public static class Operation
    {
        private static List<StudentDetails> studentList = new List<StudentDetails>();
        private static List<DepartmentDetails> departmentList = new List<DepartmentDetails>();
        private static List<AdmissionDetails> admissionList = new List<AdmissionDetails>();
        static StudentDetails currentStudent;
        public static void MainMenu()
        {
            int option = 0;
            do
            {
                System.Console.WriteLine("\t 1. Registration \n \t 2. Login \n \t 3. Exit");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        {
                            Registration();
                            System.Console.WriteLine("**************Registration form**************");
                            break;
                        }
                    case 2:
                        {
                            Login();
                            System.Console.WriteLine("***************Login form*********************");
                            break;
                        }
                    case 3:
                        {
                            System.Console.WriteLine("*************Exit from main menu**************");
                            break;
                        }
                }
            } while (option != 3);
        }

        static void Registration()
        {
            System.Console.Write("Enter your name : ");
            string name = Console.ReadLine();

            System.Console.Write("Enter your father name : ");
            string fatherName = Console.ReadLine();
            
            System.Console.Write("Enter your gender (Male/Female/Transgender) : ");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine());

            System.Console.Write("Enter your DOB in (dd/mm/yyyy) : ");
            DateTime DOB = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            System.Console.Write("Enter your phone number : ");
            long phoneNumber = long.Parse(Console.ReadLine());

            System.Console.Write("Enter Physics mark : ");
            int physics = int.Parse(Console.ReadLine());

            System.Console.Write("Enter Chemistry mark : ");
            int chemistry = int.Parse(Console.ReadLine());

            System.Console.Write("Enter maths mark : ");
            int maths = int.Parse(Console.ReadLine());

            Student student = new Student(name, fatherName, DOB, gender, phoneNumber, physics, chemistry,  maths);
            System.Console.WriteLine($"Registration successfull. Your ID is {student.StudentID}");
            studentList.Add(student);
        }

        static void Login()
        {
            System.Console.Write("Enter your student ID : ");
            string studentID = Console.ReadLine().ToUpper();
            bool check = false;
            foreach(StudentDetails student in studentList)
            {
                if(student.StudentID == studentID)
                {
                    check = true;
                    System.Console.WriteLine("Login sucessfull");
                    currentStudent = student;
                    SubMenu();
                }
            }

            if(!check)
            {
                System.Console.WriteLine("Invalid user ID");
            }
        }

        
    }

}