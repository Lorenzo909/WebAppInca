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
    public class PlanillasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PlanillasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Planillas
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Planilla.Include(p => p.Empleado).Include(p => p.Puesto);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Planillas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planilla = await _context.Planilla
                .Include(p => p.Empleado)
                .Include(p => p.Puesto)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (planilla == null)
            {
                return NotFound();
            }

            return View(planilla);
        }

        // GET: Planillas/Create
        public IActionResult Create()
        {
            ViewData["EmpleadoId"] = new SelectList(_context.Empleado, "Id", "Id");
            ViewData["PuestoId"] = new SelectList(_context.Puesto, "Id", "Id");
            return View();
        }

        // POST: Planillas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FechaPago,Horas,PrecioHora,Pago,EmpleadoId,PuestoId")] Planilla planilla)
        {
            if (ModelState.IsValid)
            {
                _context.Add(planilla);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EmpleadoId"] = new SelectList(_context.Empleado, "Id", "Id", planilla.EmpleadoId);
            ViewData["PuestoId"] = new SelectList(_context.Puesto, "Id", "Id", planilla.PuestoId);
            return View(planilla);
        }

        // GET: Planillas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planilla = await _context.Planilla.FindAsync(id);
            if (planilla == null)
            {
                return NotFound();
            }
            ViewData["EmpleadoId"] = new SelectList(_context.Empleado, "Id", "Id", planilla.EmpleadoId);
            ViewData["PuestoId"] = new SelectList(_context.Puesto, "Id", "Id", planilla.PuestoId);
            return View(planilla);
        }

        // POST: Planillas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FechaPago,Horas,PrecioHora,Pago,EmpleadoId,PuestoId")] Planilla planilla)
        {
            if (id != planilla.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(planilla);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlanillaExists(planilla.Id))
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
            ViewData["EmpleadoId"] = new SelectList(_context.Empleado, "Id", "Id", planilla.EmpleadoId);
            ViewData["PuestoId"] = new SelectList(_context.Puesto, "Id", "Id", planilla.PuestoId);
            return View(planilla);
        }

        // GET: Planillas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planilla = await _context.Planilla
                .Include(p => p.Empleado)
                .Include(p => p.Puesto)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (planilla == null)
            {
                return NotFound();
            }

            return View(planilla);
        }

        // POST: Planillas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var planilla = await _context.Planilla.FindAsync(id);
            _context.Planilla.Remove(planilla);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlanillaExists(int id)
        {
            return _context.Planilla.Any(e => e.Id == id);
        }
    }
}
