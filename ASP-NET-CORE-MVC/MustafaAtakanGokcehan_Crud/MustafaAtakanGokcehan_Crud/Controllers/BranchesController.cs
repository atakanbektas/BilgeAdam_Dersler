﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MustafaAtakanGokcehan_Crud.Models;

namespace MustafaAtakanGokcehan_Crud.Controllers
{
	public class BranchesController : Controller
	{
		private readonly MyContext _context;

		public BranchesController(MyContext context)
		{
			_context = context;
		}

		public async Task<IActionResult> Index()
		{
			return _context.Branches != null ?
						View(await _context.Branches.Include(b => b.Students).ToListAsync()) :
						Problem("Entity set 'MyContext.Branches'  is null.");
		}


		public async Task<IActionResult> Details(int? id)
		{
			if (id == null || _context.Branches == null)
			{
				return NotFound();
			}

			var branch = await _context.Branches
				.FirstOrDefaultAsync(m => m.Id == id);
			if (branch == null)
			{
				return NotFound();
			}

			return View(branch);
		}


		public IActionResult Create()
		{
			return View();
		}


		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create([Bind("Id,Name,Level")] Branch branch)
		{
			if (ModelState.IsValid)
			{
				_context.Add(branch);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}
			return View(branch);
		}

		public async Task<IActionResult> Edit(int? id)
		{
			if (id == null || _context.Branches == null)
			{
				return NotFound();
			}

			var branch = await _context.Branches.FindAsync(id);
			if (branch == null)
			{
				return NotFound();
			}
			return View(branch);
		}


		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Level")] Branch branch)
		{
			if (id != branch.Id)
			{
				return NotFound();
			}

			if (ModelState.IsValid)
			{
				try
				{
					_context.Update(branch);
					await _context.SaveChangesAsync();
				}
				catch (DbUpdateConcurrencyException)
				{
					if (!BranchExists(branch.Id))
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
			return View(branch);
		}


		public async Task<IActionResult> Delete(int? id)
		{
			if (id == null || _context.Branches == null)
			{
				return NotFound();
			}

			var branch = await _context.Branches
				.FirstOrDefaultAsync(m => m.Id == id);
			if (branch == null)
			{
				return NotFound();
			}

			return View(branch);
		}

		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(int id)
		{
			if (_context.Branches == null)
			{
				return Problem("Entity set 'MyContext.Branches'  is null.");
			}
			var branch = await _context.Branches.FindAsync(id);
			if (branch != null)
			{
				_context.Branches.Remove(branch);
			}

			await _context.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

		private bool BranchExists(int id)
		{
			return (_context.Branches?.Any(e => e.Id == id)).GetValueOrDefault();
		}
	}
}
