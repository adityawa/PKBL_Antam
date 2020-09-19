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
    public class MasterJenisKreditKemitraanController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MasterJenisKreditKemitraanController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MasterJenisKreditKemitraan
        public async Task<IActionResult> Index()
        {
            return View(await _context.M_JenisKreditKemitraans.Where(x=>!x.IsDeleted).ToListAsync());
        }

        // GET: MasterJenisKreditKemitraan/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var m_JenisKreditKemitraan = await _context.M_JenisKreditKemitraans
                .FirstOrDefaultAsync(m => m.Id == id);
            if (m_JenisKreditKemitraan == null)
            {
                return NotFound();
            }

            return View(m_JenisKreditKemitraan);
        }

        // GET: MasterJenisKreditKemitraan/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MasterJenisKreditKemitraan/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdJenisProgram,Description")] M_JenisKreditKemitraan m_JenisKreditKemitraan)
        {
            if (ModelState.IsValid)
            {
                _context.Add(m_JenisKreditKemitraan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(m_JenisKreditKemitraan);
        }

        // GET: MasterJenisKreditKemitraan/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var m_JenisKreditKemitraan = await _context.M_JenisKreditKemitraans.FindAsync(id);
            if (m_JenisKreditKemitraan == null)
            {
                return NotFound();
            }
            return View(m_JenisKreditKemitraan);
        }

        // POST: MasterJenisKreditKemitraan/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,IdJenisProgram,Description,CreatedBy,CreatedDate")] M_JenisKreditKemitraan m_JenisKreditKemitraan)
        {
            if (id != m_JenisKreditKemitraan.Id || !M_JenisKreditKemitraanExists(m_JenisKreditKemitraan.Id))
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(m_JenisKreditKemitraan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!M_JenisKreditKemitraanExists(m_JenisKreditKemitraan.Id))
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
            return View(m_JenisKreditKemitraan);
        }

        // GET: MasterJenisKreditKemitraan/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var m_JenisKreditKemitraan = await _context.M_JenisKreditKemitraans
                .FirstOrDefaultAsync(m => m.Id == id);
            if (m_JenisKreditKemitraan == null)
            {
                return NotFound();
            }

            return View(m_JenisKreditKemitraan);
        }

        // POST: MasterJenisKreditKemitraan/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var m_JenisKreditKemitraan = await _context.M_JenisKreditKemitraans.FindAsync(id);
            m_JenisKreditKemitraan.IsDeleted = true;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool M_JenisKreditKemitraanExists(long id)
        {
            return _context.M_JenisKreditKemitraans.Any(e => e.Id == id && !e.IsDeleted);
        }
    }
}
