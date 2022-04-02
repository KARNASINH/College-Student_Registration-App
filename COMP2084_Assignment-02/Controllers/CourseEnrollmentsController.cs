using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using COMP2084_Assignment_02.Data;
using COMP2084_Assignment_02.Models;

namespace COMP2084_Assignment_02.Controllers
{
    public class CourseEnrollmentsController : Controller
    {
        private readonly COMP2084_Assignment_02Context _context;

        public CourseEnrollmentsController(COMP2084_Assignment_02Context context)
        {
            _context = context;
        }

        // GET: CourseEnrollments
        public async Task<IActionResult> Index()
        {
            return View(await _context.CourseEnrollment.ToListAsync());
        }

        // GET: CourseEnrollments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseEnrollment = await _context.CourseEnrollment
                .FirstOrDefaultAsync(m => m.ENROLLMENT_ID == id);
            if (courseEnrollment == null)
            {
                return NotFound();
            }

            return View(courseEnrollment);
        }

        // GET: CourseEnrollments/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CourseEnrollments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ENROLLMENT_ID,COURSE_ENROLLMENT_ID,STUDENT_ID,COURSE_ID,DAY,ENROLLMENT")] CourseEnrollment courseEnrollment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(courseEnrollment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(courseEnrollment);
        }

        // GET: CourseEnrollments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseEnrollment = await _context.CourseEnrollment.FindAsync(id);
            if (courseEnrollment == null)
            {
                return NotFound();
            }
            return View(courseEnrollment);
        }

        // POST: CourseEnrollments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ENROLLMENT_ID,COURSE_ENROLLMENT_ID,STUDENT_ID,COURSE_ID,DAY,ENROLLMENT")] CourseEnrollment courseEnrollment)
        {
            if (id != courseEnrollment.ENROLLMENT_ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(courseEnrollment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CourseEnrollmentExists(courseEnrollment.ENROLLMENT_ID))
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
            return View(courseEnrollment);
        }

        // GET: CourseEnrollments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseEnrollment = await _context.CourseEnrollment
                .FirstOrDefaultAsync(m => m.ENROLLMENT_ID == id);
            if (courseEnrollment == null)
            {
                return NotFound();
            }

            return View(courseEnrollment);
        }

        // POST: CourseEnrollments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var courseEnrollment = await _context.CourseEnrollment.FindAsync(id);
            _context.CourseEnrollment.Remove(courseEnrollment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CourseEnrollmentExists(int id)
        {
            return _context.CourseEnrollment.Any(e => e.ENROLLMENT_ID == id);
        }
    }
}
