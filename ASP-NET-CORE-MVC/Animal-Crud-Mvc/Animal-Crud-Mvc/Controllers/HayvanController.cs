using Animal_Crud_Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Animal_Crud_Mvc.Controllers
{
    public class HayvanController : Controller
    {
        private readonly HayvanContext _context;

        public HayvanController(HayvanContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var hayvanlar = await _context.Hayvanlar.ToListAsync();
            return View(hayvanlar);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Hayvan hayvan, IFormFile ResimYolu, [FromServices] IWebHostEnvironment env)
        {
            if (ResimYolu != null && ResimYolu.Length > 0)
            {
                var dosyaAdi = Path.GetFileName(ResimYolu.FileName);
                var dosyaYolu = Path.Combine(env.WebRootPath, "pictures", dosyaAdi);

                using (var stream = new FileStream(dosyaYolu, FileMode.Create)) // Dosya oluşturuldu.. 
                {
                    await ResimYolu.CopyToAsync(stream); // Dosya kaydedildi..
                }
                hayvan.ResimYolu = dosyaAdi; // Hayvan nesnesine dosya yolu bilgisi atandı..
            }
            await _context.Hayvanlar.AddAsync(hayvan);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Delete(int id)
        {
            var silinecekHayvan = await _context.Hayvanlar.FirstOrDefaultAsync(h => h.Id.Equals(id));
            _context.Hayvanlar.Remove(silinecekHayvan);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int id)
        {
            var guncellenecekHayvan = await _context.Hayvanlar.FirstOrDefaultAsync(h => h.Id.Equals(id));
            return View(guncellenecekHayvan);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Hayvan hayvan)
        {
            _context.Hayvanlar.Attach(hayvan);
            var entry = _context.Entry(hayvan);
            entry.State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
