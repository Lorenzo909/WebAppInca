using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebAppInca.Data;
using WebAppInca.Models;

namespace WebAppInca.Controllers
{
    public class TipoHerramientasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TipoHerramientasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TipoHerramientas
        public async Task<IActionResult> Index()
        {
            return View(await _context.TipoHerramienta.ToListAsync());
        }

        // GET: TipoHerramientas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoHerramienta = await _context.TipoHerramienta
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoHerramienta == null)
            {
                return NotFound();
            }

            return View(tipoHerramienta);
        }

        // GET: TipoHerramientas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TipoHerramientas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre")] TipoHerramienta tipoHerramienta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoHerramienta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoHerramienta);
        }

        // GET: TipoHerramientas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoHerramienta = await _context.TipoHerramienta.FindAsync(id);
            if (tipoHerramienta == null)
            {
                return NotFound();
            }
            return View(tipoHerramienta);
        }

        // POST: TipoHerramientas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre")] TipoHerramienta tipoHerramienta)
        {
            if (id != tipoHerramienta.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoHerramienta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoHerramientaExists(tipoHerramienta.Id))
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
            return View(tipoHerramienta);
        }

        // GET: TipoHerramientas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoHerramienta = await _context.TipoHerramienta
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoHerramienta == null)
            {
                return NotFound();
            }

            return View(tipoHerramienta);
        }

        // POST: TipoHerramientas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tipoHerramienta = await _context.TipoHerramienta.FindAsync(id);
            _context.TipoHerramienta.Remove(tipoHerramienta);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoHerramientaExists(int id)
        {
            return _context.TipoHerramienta.Any(e => e.Id == id);
        }
    }
}
