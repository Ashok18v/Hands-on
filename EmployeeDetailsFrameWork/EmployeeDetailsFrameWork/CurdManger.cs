using EmployeeDetailsFrameWork.entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDetailsFrameWork
{
    public class CurdManger
    {
        private Context _context;
        public CurdManger()
        {
            _context = new Context();
        }

        public void insert(EmployeeOrganization employeeOrganization)
        {
            _context.Organization.Add(employeeOrganization);
            _context.SaveChanges();
        }
        public void insertbyid(int id, List<EmployeeOrganization> employeeOrganization)
        {
            var employ = _context.Employees.Where(x => x.EmployeeId == id).Include(e => e.Organization).First();

            foreach (EmployeeOrganization emp in employeeOrganization.ToList())
            {
                employ.Organization.Add(emp);

            }
            _context.Employees.Update(employ);

            _context.SaveChanges();

        }
        public void updatebyid(int id, List<EmployeeOrganization> employeeOrganization)
        {
            var emploeee = _context.Employees.Where(x => x.EmployeeId == id).Include(e => e.Organization.Where(x => x.Id == 7)).First();
            emploeee.Name = "Updated";
            emploeee.Age = 22;
            emploeee.Organization = employeeOrganization;
            foreach (EmployeeOrganization emp in employeeOrganization.ToList())
            {
                emploeee.Organization.Add(emp);
            }
            _context.Employees.Update(emploeee);

            _context.SaveChanges();
        }
        public void deletebyid(int organzation_id)
        {
            var employ = _context.Organization.Where(x => x.Id == organzation_id).First();
            _context.Organization.Remove(employ);
            _context.SaveChanges();
        }
        public void deleteEmployeedetails(int id)
        {
            var emp = _context.Employees.Where(x => x.EmployeeId == id).Include(e => e.Organization).First();
            _context.Employees.Remove(emp);
            _context.SaveChanges();
        }
    }
}
