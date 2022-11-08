using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Renatour_Dot_Net_v._1.Data;
using Renatour_Dot_Net_v._1.Views.Destinos;

namespace Renatour_Dot_Net_v._1.Controllers
{
    public class DestinosController : Controller
    {
        private readonly Renatour_Dot_Net_v_1Context _context;

        public DestinosController(Renatour_Dot_Net_v_1Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        // GET: Destinos
        public async Task<IActionResult> Destinos()
        {
              return View(await _context.Destinos.ToListAsync());
        }

        // GET: Destinos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Destinos == null)
            {
                return NotFound();
            }

            var destinos = await _context.Destinos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (destinos == null)
            {
                return NotFound();
            }

            return View(destinos);
        }

        // GET: Destinos/Create
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Contato()
        {
            return View();
        }

        // POST: Destinos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Descricao,Preco")] Destinos destinos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(destinos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Destinos));
            }
            return View(destinos);
        }

        // GET: Destinos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Destinos == null)
            {
                return NotFound();
            }

            var destinos = await _context.Destinos.FindAsync(id);
            if (destinos == null)
            {
                return NotFound();
            }
            return View(destinos);
        }

        // POST: Destinos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Descricao,Preco")] Destinos destinos)
        {
            if (id != destinos.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(destinos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DestinosExists(destinos.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Destinos));
            }
            return View(destinos);
        }

        // GET: Destinos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Destinos == null)
            {
                return NotFound();
            }

            var destinos = await _context.Destinos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (destinos == null)
            {
                return NotFound();
            }

            return View(destinos);
        }

        // POST: Destinos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Destinos == null)
            {
                return Problem("Entity set 'Renatour_Dot_Net_v_1Context.Destinos'  is null.");
            }
            var destinos = await _context.Destinos.FindAsync(id);
            if (destinos != null)
            {
                _context.Destinos.Remove(destinos);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Destinos));
        }

        private bool DestinosExists(int id)
        {
          return _context.Destinos.Any(e => e.Id == id);
        }
    }
}
