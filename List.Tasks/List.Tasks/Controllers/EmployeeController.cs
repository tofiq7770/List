using List.Services;
using List.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List.Controllers
{
    internal class EmployeeController
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController()
        {
            _employeeService = new EmployeeService();

        }

        public void GetEmployeesBySalarAndTime()
        {
            var data = _employeeService.GetAll();
            DateTime startDate = new(1945, 01, 01);
            DateTime endDate = new(2023, 01, 03);

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
