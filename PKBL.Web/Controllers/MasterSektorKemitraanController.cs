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
    public class MasterSektorKemitraanController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MasterSektorKemitraanController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MasterSektorKemitraan
        public async Task<IActionResult> Index()
        {
            return View(await _context.M_SektorKemitraans.Where(x=>!x.IsDeleted).ToListAsync());
        }

        // GET: MasterSektorKemitraan/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var m_SektorKemitraan = await _context.M_SektorKemitraans
                .FirstOrDefaultAsync(m => m.Id == id);
            if (m_SektorKemitraan == null)
            {
                return NotFound();
            }

            return View(m_SektorKemitraan);
        }

        // GET: MasterSektorKemitraan/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MasterSektorKemitraan/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Sector_Name,Remarks")] M_SektorKemitraan m_SektorKemitraan)
        {
            if (ModelState.IsValid)
            {
                _context.Add(m_SektorKemitraan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(m_SektorKemitraan);
        }

        // GET: MasterSektorKemitraan/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var m_SektorKemitraan = await _context.M_SektorKemitraans.FindAsync(id);
            if (m_SektorKemitraan == null)
            {
                return NotFound();
            }
            return View(m_SektorKemitraan);
        }

        // POST: MasterSektorKemitraan/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Sector_Name,Remarks,CreatedByCreatedDate")] M_SektorKemitraan m_SektorKemitraan)
        {
            if (id != m_SektorKemitraan.Id || !M_SektorKemitraanExists(m_SektorKemitraan.Id))
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(m_SektorKemitraan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!M_SektorKemitraanExists(m_SektorKemitraan.Id))
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
            return View(m_SektorKemitraan);
        }

        // GET: MasterSektorKemitraan/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var m_SektorKemitraan = await _context.M_SektorKemitraans
                .FirstOrDefaultAsync(m => m.Id == id);
            if (m_SektorKemitraan == null)
            {
                return NotFound();
            }

            return View(m_SektorKemitraan);
        }

        // POST: MasterSektorKemitraan/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var m_SektorKemitraan = await _context.M_SektorKemitraans.FindAsync(id);
            m_SektorKemitraan.IsDeleted = true;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool M_SektorKemitraanExists(long id)
        {
            return _context.M_SektorKemitraans.Any(e => e.Id == id && !e.IsDeleted);
        }
    }
}
