using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebExampleTable.Context;
using WebExampleTable.Models;

namespace WebExampleTable.Controllers
{
    public class KisiController : Controller
    {
        private readonly KisiContext _db;
        public KisiController(KisiContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            var kisiler = await _db.Kisiler.ToListAsync();
            return View(kisiler);
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Kisi kisi)
        {
            await _db.Kisiler.AddAsync(kisi);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var silinecekKisi = await _db.Kisiler.FindAsync(id);
            _db.Kisiler.Remove(silinecekKisi);
            _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int id)
        {
            return View(await _db.Kisiler.FindAsync(id));
        }
        [HttpPost]
        public async Task<IActionResult> Update(Kisi kisi)
        {
            _db.Entry(_db.Kisiler).State = EntityState.Modified;

            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }




    }
}
