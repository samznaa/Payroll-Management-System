using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TeacherProject.Data;
using TeacherProject.Models;

namespace TeacherProject.Controllers
{
    public class EmployeeTotalSalaryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeeTotalSalaryController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: EmployeeTotalSalary
        public async Task<IActionResult> Index()
        {
            return View(await _context.EmployeeTotalSalary.ToListAsync());
        }

        // GET: EmployeeTotalSalary/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeTotalSalary = await _context.EmployeeTotalSalary
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employeeTotalSalary == null)
            {
                return NotFound();
            }

            return View(employeeTotalSalary);
        }

        // GET: EmployeeTotalSalary/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EmployeeTotalSalary/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FullName,EmployeeId,AddedCalender,AddedOn,AddedBy")] EmployeeTotalSalary employeeTotalSalary)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employeeTotalSalary);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employeeTotalSalary);
        }

        // GET: EmployeeTotalSalary/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeTotalSalary = await _context.EmployeeTotalSalary.FindAsync(id);
            if (employeeTotalSalary == null)
            {
                return NotFound();
            }
            return View(employeeTotalSalary);
        }

        // POST: EmployeeTotalSalary/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,EmployeeId,AddedCalender,AddedOn,AddedBy")] EmployeeTotalSalary employeeTotalSalary)
        {
            if (id != employeeTotalSalary.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employeeTotalSalary);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeTotalSalaryExists(employeeTotalSalary.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(employeeTotalSalary);
        }

        // GET: EmployeeTotalSalary/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeTotalSalary = await _context.EmployeeTotalSalary
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employeeTotalSalary == null)
            {
                return NotFound();
            }

            return View(employeeTotalSalary);
        }

        // POST: EmployeeTotalSalary/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employeeTotalSalary = await _context.EmployeeTotalSalary.FindAsync(id);
            _context.EmployeeTotalSalary.Remove(employeeTotalSalary);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeTotalSalaryExists(int id)
        {
            return _context.EmployeeTotalSalary.Any(e => e.Id == id);
        }
    }
}
