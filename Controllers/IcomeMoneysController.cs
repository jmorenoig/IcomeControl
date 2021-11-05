using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IcomeControl.Data;
using IcomeControl.Models;

namespace IcomeControl.Controllers
{
    public class IcomeMoneysController : Controller
    {
        private readonly ApplicationDbContext _context;

        public IcomeMoneysController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: IcomeMoneys
        public async Task<IActionResult> Index(int? mes, int? anio)
        {
            if (mes == null)
            {
                mes = DateTime.Now.Month;
            }
            if (anio == null)
            {
                anio = DateTime.Now.Year;
            }

            ViewData["mes"] = mes;
            ViewData["anio"] = anio;

            var applicationDbContext = _context.IngresoGasto.Include(i => i.Category).Where(i => i.Date.Month == mes && i.Date.Year == anio); ;
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: IcomeMoneys/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var icomeMoney = await _context.IngresoGasto
                .Include(i => i.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (icomeMoney == null)
            {
                return NotFound();
            }

            return View(icomeMoney);
        }

        // GET: IcomeMoneys/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categorias.Where(c => c.State == true), "Id", "NameCategory");
            return View();
        }

        // POST: IcomeMoneys/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CategoryId,Date,Value")] IcomeMoney icomeMoney)
        {
            if (ModelState.IsValid)
            {
                _context.Add(icomeMoney);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categorias, "Id", "NameCategory", icomeMoney.CategoryId);
            return View(icomeMoney);
        }

        // GET: IcomeMoneys/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var icomeMoney = await _context.IngresoGasto.FindAsync(id);
            if (icomeMoney == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Categorias, "Id", "NameCategory", icomeMoney.CategoryId);
            return View(icomeMoney);
        }

        // POST: IcomeMoneys/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CategoryId,Date,Value")] IcomeMoney icomeMoney)
        {
            if (id != icomeMoney.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(icomeMoney);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IcomeMoneyExists(icomeMoney.Id))
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
            ViewData["CategoryId"] = new SelectList(_context.Categorias, "Id", "NameCategory", icomeMoney.CategoryId);
            return View(icomeMoney);
        }

        // GET: IcomeMoneys/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var icomeMoney = await _context.IngresoGasto
                .Include(i => i.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (icomeMoney == null)
            {
                return NotFound();
            }

            return View(icomeMoney);
        }

        // POST: IcomeMoneys/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var icomeMoney = await _context.IngresoGasto.FindAsync(id);
            _context.IngresoGasto.Remove(icomeMoney);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IcomeMoneyExists(int id)
        {
            return _context.IngresoGasto.Any(e => e.Id == id);
        }
    }
}
