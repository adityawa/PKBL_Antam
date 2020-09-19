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
    public class MasterCompanyController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MasterCompanyController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MasterCompany
        public async Task<IActionResult> Index()
        {
            return View(await _context.M_Companies.Where(e=>!e.IsDeleted).ToListAsync());
        }

        // GET: MasterCompany/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var m_Company = await _context.M_Companies
                .FirstOrDefaultAsync(m => m.Id == id);
            if (m_Company == null)
            {
                return NotFound();
            }

            return View(m_Company);
        }

        // GET: MasterCompany/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MasterCompany/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Description")] M_Company m_Company)
        {
            if (ModelState.IsValid)
            {
                _context.Add(m_Company);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(m_Company);
        }

        // GET: MasterCompany/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var m_Company = await _context.M_Companies.FindAsync(id);
            if (m_Company == null)
            {
                return NotFound();
            }
            return View(m_Company);
        }

        // POST: MasterCompany/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Description,CreatedBy,CreatedDate")] M_Company m_Company)
        {
            if (id != m_Company.Id || !M_CompanyExists(m_Company.Id))
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(m_Company);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!M_CompanyExists(m_Company.Id))
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
            return View(m_Company);
        }

        // GET: MasterCompany/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var m_Company = await _context.M_Companies
                .FirstOrDefaultAsync(m => m.Id == id);
            if (m_Company == null)
            {
                return NotFound();
            }

            return View(m_Company);
        }

        // POST: MasterCompany/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var m_Company = await _context.M_Companies.FindAsync(id);
            m_Company.IsDeleted = true;;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool M_CompanyExists(long id)
        {
            return _context.M_Companies.Any(e => e.Id == id && !e.IsDeleted);
        }
    }
}
