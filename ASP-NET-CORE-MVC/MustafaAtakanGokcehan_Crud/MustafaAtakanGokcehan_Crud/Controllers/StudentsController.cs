using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MustafaAtakanGokcehan_Crud.Models;

namespace MustafaAtakanGokcehan_Crud.Controllers
{
	public class StudentsController : Controller
	{
		private readonly MyContext _context;

		public StudentsController(MyContext context)
		{
			_context = context;
		}

		// GET: Students
		public async Task<IActionResult> Index()
		{
			ViewBag.Branches = await _context.Branches.Include(b => b.Students).ToListAsync();
			var myContext = _context.Students.Include(s => s.Branch);
			return View(await myContext.ToListAsync());
		}


		public async Task<IActionResult> Index2(int id)
		{
			//ViewBag.Students = await _context.Branches.Where(b => b.Id == id).Include(b => b.Students).ToListAsync();
			var myContext = await _context.Students.Include(s => s.Branch).Where(Branch => Branch.Branch.Id == id).ToListAsync();
			//var 
			ViewBag.Branches = await _context.Branches.Include(b => b.Students).ToListAsync();
			//var myContext = _context.Students.Include(s => s.Branch);
			return View("Index", myContext);
		}

		// GET: Students/Details/5
		public async Task<IActionResult> Details(int? id)
		{
			if (id == null || _context.Students == null)
			{
				return NotFound();
			}

			var student = await _context.Students
				.Include(s => s.Branch)
				.FirstOrDefaultAsync(m => m.Id == id);
			if (student == null)
			{
				return NotFound();
			}

			return View(student);
		}

		public IActionResult Create()
		{
			//ViewData["BranchId"] = new SelectList(_context.Branches, "Id", "Id");
			//ViewData["BranchName"] = new SelectList(_context.Branches, "Name", "Name");

			ViewBag.LevelName = _context.Branches.Select(b => new SelectListItem { Text = b.Name + " " + b.Level, Value = b.Id.ToString() });

			return View();
		}


		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,Address,BranchId")] Student student)
		{
			if (ModelState.IsValid)
			{
				_context.Add(student);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}
			ViewData["BranchId"] = new SelectList(_context.Branches, "Id", "Id", student.BranchId);
			return View(student);
		}


		public async Task<IActionResult> Edit(int? id)
		{
			if (id == null || _context.Students == null)
			{
				return NotFound();
			}

			var student = await _context.Students.FindAsync(id);
			if (student == null)
			{
				return NotFound();
			}
			ViewData["BranchId"] = new SelectList(_context.Branches, "Id", "Id", student.BranchId);
			return View(student);
		}


		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,Address,BranchId")] Student student)
		{
			if (id != student.Id)
			{
				return NotFound();
			}

			if (ModelState.IsValid)
			{
				try
				{
					_context.Update(student);
					await _context.SaveChangesAsync();
				}
				catch (DbUpdateConcurrencyException)
				{
					if (!StudentExists(student.Id))
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
			ViewData["BranchId"] = new SelectList(_context.Branches, "Id", "Id", student.BranchId);
			return View(student);
		}


		public async Task<IActionResult> Delete(int? id)
		{
			if (id == null || _context.Students == null)
			{
				return NotFound();
			}

			var student = await _context.Students
				.Include(s => s.Branch)
				.FirstOrDefaultAsync(m => m.Id == id);
			if (student == null)
			{
				return NotFound();
			}

			return View(student);
		}


		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(int id)
		{
			if (_context.Students == null)
			{
				return Problem("Entity set 'MyContext.Students'  is null.");
			}
			var student = await _context.Students.FindAsync(id);
			if (student != null)
			{
				_context.Students.Remove(student);
			}

			await _context.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

		private bool StudentExists(int id)
		{
			return (_context.Students?.Any(e => e.Id == id)).GetValueOrDefault();
		}
	}
}
