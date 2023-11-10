using List.Tasks.Services;
using List.Tasks.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List.Tasks.Controllers
{
    internal class EmployeeController
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController()
        {
            _employeeService=new EmployeeService();

        }

        public void GetEmployeesBySalarAndTime()
        {
            var data = _employeeService.GetAll();
            DateTime startDate= new(1994,11,11);
            DateTime endDate= new(2021,12,12);
            int count = 0;

            foreach (var item in data)
            {
                
                if (item.Salary > 2000 && item.Birthday > startDate && item.Birthday < endDate)
                {
                    count++;

                
                }
              
            }
            Console.WriteLine(count);

        }
    }
}
