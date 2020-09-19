using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PKBL.Domain.Entities.Master;
using PKBL.Infrastructure.Persistence;

namespace PKBL.Web.Controllers
{
    public class MasterCabPropController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MasterCabPropController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MasterCabProp
        public async Task<IActionResult> Index()
        {
            return View(await _context.M_CabProps.Where(x=>!x.IsDeleted).ToListAsync());
        }

        // GET: MasterCabProp/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var m_CabProp = await _context.M_CabProps
                .FirstOrDefaultAsync(m => m.Id == id);
            if (m_CabProp == null)
            {
                return NotFound();
            }

            return View(m_CabProp);
        }

        // GET: MasterCabProp/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MasterCabProp/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Cabang,Propinsi")] M_CabProp m_CabProp)
        {
            if (ModelState.IsValid)
            {
                _context.Add(m_CabProp);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(m_CabProp);
        }

        // GET: MasterCabProp/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var m_CabProp = await _context.M_CabProps.FindAsync(id);
            if (m_CabProp == null)
            {
                return NotFound();
            }
            return View(m_CabProp);
        }

        // POST: MasterCabProp/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Cabang,Propinsi,CreatedBy,CreatedDate")] M_CabProp m_CabProp)
        {
            if (id != m_CabProp.Id || !M_CabPropExists(m_CabProp.Id))
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(m_CabProp);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!M_CabPropExists(m_CabProp.Id))
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
            return View(m_CabProp);
        }

        // GET: MasterCabProp/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var m_CabProp = await _context.M_CabProps
                .FirstOrDefaultAsync(m => m.Id == id);
            if (m_CabProp == null)
            {
                return NotFound();
            }

            return View(m_CabProp);
        }

        // POST: MasterCabProp/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var m_CabProp = await _context.M_CabProps.FindAsync(id);
            m_CabProp.IsDeleted = true;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool M_CabPropExists(long id)
        {
            return _context.M_CabProps.Any(e => e.Id == id && !e.IsDeleted);
        }
    }
}
