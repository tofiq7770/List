using List.Models;
using List.Services.Data;
using List.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List.Services
{
    public class EmployeeService : IEmployeeService
    {
        List<Employee> IEmployeeService.GetAll()
        {
            return AppDbContext.Employees();
        }

        List<Employee> IEmployeeService.GetEmployess(DateTime startDate, DateTime endDate, decimal salary)
        {
            return AppDbContext.Employees().Where(x => x.Birthday > startDate && x.Birthday < endDate && x.Salary == salary).ToList();
        }
    }
}
