using EmployeeDetailsFrameWork;
using EmployeeDetailsFrameWork.entites;

namespace Employe
{
    public class Program
    {
        static void Main(string[] args)
        {
            CurdManger curdManger = new CurdManger();
            //Employee result = new Employee { Name = "Ashok", Age = 21 };
            //  curdManger.insert(new EmployeeOrganization { Name = "Lbrce", Address = "Vijyawada", Employee = result });
            List<EmployeeOrganization> list = new List<EmployeeOrganization>();
            list.Add(new EmployeeOrganization { Name = "VIT", Address = "Amaravathi" });
            //list.Add(new EmployeeOrganization { Name = "Lbrce", Address = "Vijyawada" });
            //curdManger.insertbyid(4, list);

            //curdManger.updatebyid(4, list);
            //curdManger.deletebyid(10);
            curdManger.deleteEmployeedetails(4);
        }
    }
}