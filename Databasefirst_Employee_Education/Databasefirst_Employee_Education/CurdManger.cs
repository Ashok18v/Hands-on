using Databasefirst_Employee_Education.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databasefirst_Employee_Education
{
    public class CurdManger
    {
        private detailsContext detailsContext;
        public CurdManger()
        {
            detailsContext = new detailsContext();
        }
        public void insert(EmployeeEducation EmpEducation)
        {
            //   var emp_details = new Employee()
            //   {
            //       EmployeeName
            //   }
            //foreach(EmployeeEducation emp in EmpEducation)
            //   {
            //       emp_details.EmployeeEducations.Add(emp);
            //   }
            detailsContext.EmployeeEducations.Add(EmpEducation);
            detailsContext.SaveChanges();
        }
        public void insertbyid(int id, List<EmployeeEducation> emp)
        {
            var empDetail = detailsContext.Employees.Where(x => x.EmployeeId == id).Include(e => e.EmployeeEducations).First();
            foreach (EmployeeEducation employeeEducation in emp)
            {
                empDetail.EmployeeEducations.Add(employeeEducation);

            }
            detailsContext.Employees.Update(empDetail);
            detailsContext.SaveChanges();
        }
        public void updateEmployebyId(int id)
        {
            var empolyee = detailsContext.Employees.Where(x => x.EmployeeId == id).First();
            Console.WriteLine("Enter the Employee Name");
            string a = Console.ReadLine();
            empolyee.EmployeeName = a;
            detailsContext.Employees.Update(empolyee);
            detailsContext.SaveChanges();

        }
        public void updateEmpEducationbyEmpId(int id, int ed_Id)
        {
            var edu = detailsContext.EmployeeEducations.Where(e => e.Id == ed_Id).First();
            edu.UniversityNmae = "VVIT";
            var employee = detailsContext.Employees.Where(x => x.EmployeeId == id).Include(e => e.EmployeeEducations.Where(x => x.Id == ed_Id)).First();

            detailsContext.Employees.Update(employee);
            detailsContext.SaveChanges();
        }

        public void deleteemployee(int id)
        {
            var empDetail = detailsContext.Employees.Where(x => x.EmployeeId == id).First();
            
            detailsContext.Employees.Remove(empDetail);
          
           
            detailsContext.SaveChanges();
        }
    }
}
