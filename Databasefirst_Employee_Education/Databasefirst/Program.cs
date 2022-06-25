using Databasefirst_Employee_Education;
using Databasefirst_Employee_Education.Models;

namespace Databasefirst
{
    public class Program
    {
        public static void Main(string[] args)
        {
           CurdManger curdManger = new CurdManger();
            // var emp = new Employee {EmployeeId=12, EmployeeName = "Lokesh", EmployeeAddress = "Vijyawada" };

            //curdManger.insert (new EmployeeEducation {Id=5543, CourseName = "CSE", UniversityNmae = "Lbrce", Employee =emp});
            List<EmployeeEducation> employ = new List<EmployeeEducation>();
            // employ.Add(new EmployeeEducation { Id = 4456, CourseName = "Ece", UniversityNmae = "Lbrce" });
            // curdManger.insertbyid(12, employ);
            //curdManger.updateEmployebyId(12);

            //curdManger.updateEmpEducationbyEmpId(12, 5543);
            curdManger.deleteemployee(12);


        }
    }
}
