using Dapper;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Threading.Tasks;
using TeacherProject.Data;
using TeacherProject.Models;

namespace TeacherProject.Controllers
{
    public class EmployeeWithSalaryDetailsController : Controller
    {

        private readonly ApplicationDbContext _context;
        private readonly IDbConnection _dbConnection;

        public EmployeeWithSalaryDetailsController(ApplicationDbContext context, IDbConnection dbConnection)
        {
            _context = context;
            _dbConnection = dbConnection;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _dbConnection.QueryAsync<EmployeeWithSalaryDetailsViewModel>(@"select min(e.FullName) as 'EmployeeName',sum(ets.Salary) as 'TotalSalary',min(c.NepaliCalenderName) as 'MonthName',min(c.Id) as 'CalenderId', e.Id as 'EmployeeId' from EmployeeTotalSalary ets
                                                                                            left join Employee e on ets.EmployeeId=e.Id
                                                                                            left join Calender c on ets.AddedCalender=c.Id
                                                                                            group by e.Id");
            return View(data); 
        }
    }
}
