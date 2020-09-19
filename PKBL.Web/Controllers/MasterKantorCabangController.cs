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
    public class MasterKantorCabangController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MasterKantorCabangController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MasterKantorCabang
        public async Task<IActionResult> Index()
        {
            return View(await _context.M_KantorCabangs.Where(x=>!x.IsDeleted).ToListAsync());
        }

        // GET: MasterKantorCabang/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var m_KantorCabang = await _context.M_KantorCabangs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (m_KantorCabang == null)
            {
                return NotFound();
            }

            return View(m_KantorCabang);
        }

        // GET: MasterKantorCabang/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MasterKantorCabang/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Details,HeadName,Title,Address,Province_Code")] M_KantorCabang m_KantorCabang)
        {
            if (ModelState.IsValid)
            {
                _context.Add(m_KantorCabang);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(m_KantorCabang);
        }

        // GET: MasterKantorCabang/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var m_KantorCabang = await _context.M_KantorCabangs.FindAsync(id);
            if (m_KantorCabang == null)
            {
                return NotFound();
            }
            return View(m_KantorCabang);
        }

        // POST: MasterKantorCabang/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Name,Details,HeadName,Title,Address,Province_Code,CreatedBy,CreatedDate")] M_KantorCabang m_KantorCabang)
        {
            if (id != m_KantorCabang.Id || !M_KantorCabangExists(m_KantorCabang.Id))
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(m_KantorCabang);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!M_KantorCabangExists(m_KantorCabang.Id))
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
            return View(m_KantorCabang);
        }

        // GET: MasterKantorCabang/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var m_KantorCabang = await _context.M_KantorCabangs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (m_KantorCabang == null)
            {
                return NotFound();
            }

            return View(m_KantorCabang);
        }

        // POST: MasterKantorCabang/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var m_KantorCabang = await _context.M_KantorCabangs.FindAsync(id);
            m_KantorCabang.IsDeleted = true;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool M_KantorCabangExists(long id)
        {
            return _context.M_KantorCabangs.Any(e => e.Id == id && !e.IsDeleted);
        }
    }
}
