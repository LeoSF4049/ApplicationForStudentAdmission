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
<<<<<<< Updated upstream
            Gender gender = Enum.Parse<Gender>(Console.ReadLine());
=======
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(),true);
>>>>>>> Stashed changes

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

<<<<<<< Updated upstream
            Student student = new Student(name, fatherName, DOB, gender, phoneNumber, physics, chemistry,  maths);
=======
            StudentDetails student = new StudentDetails(name, fatherName, DOB, gender, phoneNumber, physics, chemistry,  maths);
>>>>>>> Stashed changes
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

<<<<<<< Updated upstream
<<<<<<< Updated upstream
        
    }

}
=======
=======

>>>>>>> Stashed changes
        public static void SubMenu()

        {

            int option = 0;
            do
            {
                System.Console.WriteLine("***********Sub Menu***********");
                System.Console.WriteLine("\t1.Check Eligiblity\n\t2.Show Details\n\t3.Take Admission\n\t4.Cancel Admission\n\t5.Show Admission Details\n\t6.Exit");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            System.Console.WriteLine("**********Check Eligiblity*******");
                            CheckEligiblity();
                            break;
                        }
                    case 2:
                        {
                            System.Console.WriteLine("********Showing Details**********");
                            ShowDetails();
                            break;
                        }
                    case 3:
                        {
                            System.Console.WriteLine("***********Take admission***********");
                            TakeAdmission();
                            break;
                        }
                    case 4:
                        {
                            System.Console.WriteLine("**********Cancel Admission**********");
                            CancelAdmission();
                            break;
                        }
                    case 5:
                        {
                            System.Console.WriteLine("**********Showing Admission Details********");
                            ShowAdmissionDetails();
                            break;
                        }
                    case 6:
                        {
                            System.Console.WriteLine("**********Exit From Sub Menu********");
                            break;
                        }
                }
            } while (option != 6);
        } 
    
      public static void DefaultData()
        {
            StudentDetails student1 = new StudentDetails("Ravi", "Chandran", new DateTime(1999, 11, 11), Gender.Male, 987654321, 90, 90, 90);
            studentList.Add(student1);
            StudentDetails student2 = new StudentDetails("Baskar", "Sethuraj", new DateTime(1998, 11, 11), Gender.Male, 987654432,  90, 80, 90);
            studentList.Add(student2);
            DepartmentDetails department1 = new DepartmentDetails("EEE", 29);
            departmentList.Add(department1);
            DepartmentDetails department2 = new DepartmentDetails("CSE", 29);
            departmentList.Add(department2);
            DepartmentDetails department3 = new DepartmentDetails("MECH", 30);
            departmentList.Add(department3);
            DepartmentDetails department4 = new DepartmentDetails("ECE", 30);
            departmentList.Add(department4);
            AdmissionDetails admission1 = new AdmissionDetails(student1.StudentID, department1.DepartmentID, new DateTime(2022, 12, 16), AdmissionStatus.Admitted);
            admissionList.Add(admission1);
            AdmissionDetails admission2 = new AdmissionDetails(student2.StudentID, department2.DepartmentID, new DateTime(2022, 12, 16), AdmissionStatus.Admitted);
            admissionList.Add(admission2);



        }

        public static void CheckEligiblity()
        {
<<<<<<< Updated upstream
            bool eligiblity = currentStudent.CheckEligiblity(75.0);
=======
            bool eligiblity = currentStudent.CheckEligibility(75.0);
>>>>>>> Stashed changes
            if (eligiblity)
            {
                System.Console.WriteLine("You are eligible for admission");
            }
            else
            {
                System.Console.WriteLine("You are not eligible for admission");
            }
        }
        public static void ShowDetails()
        {
            System.Console.WriteLine($" Name:{currentStudent.Name} FatherName:{currentStudent.FatherName} Gender:{currentStudent.Gender} ");
<<<<<<< Updated upstream
            System.Console.WriteLine($" Phone:{currentStudent.Phone} DOB:{currentStudent.DOB.ToString("dd/MM/yyyy")} ");
=======
            System.Console.WriteLine($" Phone:{currentStudent.PhoneNo} DOB:{currentStudent.DOB.ToString("dd/MM/yyyy")} ");
>>>>>>> Stashed changes
            System.Console.WriteLine($"Physics:{currentStudent.Physics} Chemistry:{currentStudent.Chemistry} Maths:{currentStudent.Maths}");

        }
        public static void ShowAdmissionDetails()
        {
            bool condition = true;
            foreach (AdmissionDetails admissionInfo in admissionList)
            {
                if (currentStudent.StudentID == admissionInfo.StudentID)
                {
                    condition = false;
                    System.Console.WriteLine($"Admission ID:{admissionInfo.AdmissionID} Student ID:{admissionInfo.StudentID} Department ID:{admissionInfo.DepartmentID}");
                    System.Console.WriteLine($"Admission Date:{admissionInfo.AdmissionDate.ToString("dd/MM/yyyy")} Status:{admissionInfo.AdmissionStatus} ");

                }
                if (condition)
                {
                    System.Console.WriteLine("You haven't take any admission yet.");
                }
            }


        }

        public static void CancelAdmission()
        {
            //fetch admission LIst
            foreach (AdmissionDetails admissionInfo in admissionList)
            {
                //check student ID and admission status is admitted
                if (currentStudent.StudentID == admissionInfo.StudentID && admissionInfo.AdmissionStatus == AdmissionStatus.Admitted)
                {
                    //admission status=cancelled
                    admissionInfo.AdmissionStatus = AdmissionStatus.Cancelled;
                    //return seat to department 
                    foreach (DepartmentDetails departmentInfo in departmentList)
                    {
                        //check department id matches
                        if (departmentInfo.DepartmentID == admissionInfo.DepartmentID)
                        {
                            //increament seat by one
                            departmentInfo.NumberOfSeats++;
                        }
                    }
                    //show your admission cancelled
                    System.Console.WriteLine("Your admission was cancelled successfully");

                }
            }
        }
        public static void TakeAdmission()
        {
            //show department details
            foreach(DepartmentDetails departmentInfo in departmentList)
            {
                System.Console.WriteLine($" Department ID:{departmentInfo.DepartmentID} Name:{departmentInfo.DepartmentName} Number of seats{departmentInfo.NumberOfSeats}");
            }
            //ask departmentID to process admission
            System.Console.WriteLine("Enter department ID:");
            string departmentID=Console.ReadLine().ToUpper();

            //fetch department deatails
            bool temp=true;
            foreach(DepartmentDetails departmentInfo in departmentList)
            {
                //check it has valid deoartment ID -no-invalid departmentID
                if(departmentInfo.DepartmentID==departmentID)
                {
                    temp=false;
                    //yes-check number of seat>0-no-No seat available
                    if(departmentInfo.NumberOfSeats>0)
                    {
                        //yes -check he is eligible -no-not eligible to take admission
<<<<<<< Updated upstream
                        if(currentStudent.CheckEligiblity(75.0))
=======
                        if(currentStudent.CheckEligibility(75.0))
>>>>>>> Stashed changes
                        {
                            int count=0;
                            //
                            foreach(AdmissionDetails admissionInfo in admissionList)
                            {
                                if(currentStudent.StudentID==admissionInfo.StudentID && admissionInfo.AdmissionStatus==AdmissionStatus.Admitted)
                                {
                                    count++;
                                }
                                
                            }
                            if(count>0)
                            {
                                System.Console.WriteLine("You have already taken admission");
                            }
                            else
                            {
                                //no-create object
                                departmentInfo.NumberOfSeats--;
                                AdmissionDetails admission=new AdmissionDetails(currentStudent.StudentID,departmentInfo.DepartmentID,DateTime.Now,AdmissionStatus.Admitted);
                                admissionList.Add(admission);
                                System.Console.WriteLine("Admission was successful .Your admission ID"+admission.AdmissionID);
                                //show admission successful
                            }

                        }
                        else
                        {
                           System.Console.WriteLine("You are not eligible to take admission");
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("No seat available");
                    }

                }
            }
            if(temp)
            {
                System.Console.WriteLine("Invalid department ID");
            }
            


        }

    
    }


}

<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
