using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebExampleTable.Context;
using WebExampleTable.Models;

namespace WebExampleTable.Controllers
{
    public class ArabaController : Controller
    {
        private readonly KisiContext _db;
        public ArabaController(KisiContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            var arabalar = await _db.Arabalar.ToListAsync();
            return View(arabalar);
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Araba araba)
        {
            await _db.Arabalar.AddAsync(araba);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var silinecekAraba = await _db.Arabalar.FindAsync(id);
            _db.Arabalar.Remove(silinecekAraba);
            _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int id)
        {
            return View(await _db.Arabalar.FindAsync(id));
        }
        [HttpPost]
        public async Task<IActionResult> Update(Araba araba)
        {
            //_db.Entry(_db.Kisiler).State = EntityState.Modified;
            _db.Arabalar.Update(araba);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
