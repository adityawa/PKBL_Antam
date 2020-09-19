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
    public class MasterProvinceController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MasterProvinceController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MasterProvince
        public async Task<IActionResult> Index()
        {
            return View(await _context.M_Provinces.Where(x=>!x.IsDeleted).ToListAsync());
        }

        // GET: MasterProvince/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var m_Province = await _context.M_Provinces
                .FirstOrDefaultAsync(m => m.Id == id);
            if (m_Province == null)
            {
                return NotFound();
            }

            return View(m_Province);
        }

        // GET: MasterProvince/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MasterProvince/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,CapitalName,BranchCode")] M_Province m_Province)
        {
            if (ModelState.IsValid)
            {
                _context.Add(m_Province);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(m_Province);
        }

        // GET: MasterProvince/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var m_Province = await _context.M_Provinces.FindAsync(id);
            if (m_Province == null)
            {
                return NotFound();
            }
            return View(m_Province);
        }

        // POST: MasterProvince/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Name,CapitalName,BranchCode,CreatedBy,CreatedDate")] M_Province m_Province)
        {
            if (id != m_Province.Id || !M_ProvinceExists(m_Province.Id))
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(m_Province);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!M_ProvinceExists(m_Province.Id))
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
            return View(m_Province);
        }

        // GET: MasterProvince/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var m_Province = await _context.M_Provinces
                .FirstOrDefaultAsync(m => m.Id == id);
            if (m_Province == null)
            {
                return NotFound();
            }

            return View(m_Province);
        }

        // POST: MasterProvince/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var m_Province = await _context.M_Provinces.FindAsync(id);
            m_Province.IsDeleted = true;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool M_ProvinceExists(long id)
        {
            return _context.M_Provinces.Any(e => e.Id == id && !e.IsDeleted);
        }
    }
}
