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
    public class MasterDropdownController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MasterDropdownController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MasterDropdown
        public async Task<IActionResult> Index()
        {
            return View(await _context.M_Dropdowns.Where(x=>!x.IsDeleted).ToListAsync());
        }

        // GET: MasterDropdown/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var m_Dropdown = await _context.M_Dropdowns
                .FirstOrDefaultAsync(m => m.Id == id);
            if (m_Dropdown == null)
            {
                return NotFound();
            }

            return View(m_Dropdown);
        }

        // GET: MasterDropdown/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MasterDropdown/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Item,Value,Name")] M_Dropdown m_Dropdown)
        {
            if (ModelState.IsValid)
            {
                _context.Add(m_Dropdown);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(m_Dropdown);
        }

        // GET: MasterDropdown/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var m_Dropdown = await _context.M_Dropdowns.FindAsync(id);
            if (m_Dropdown == null)
            {
                return NotFound();
            }
            return View(m_Dropdown);
        }

        // POST: MasterDropdown/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Item,CreatedBy,CreatedDate")] M_Dropdown m_Dropdown)
        {
            if (id != m_Dropdown.Id || !M_DropdownExists(m_Dropdown.Id))
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(m_Dropdown);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!M_DropdownExists(m_Dropdown.Id))
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
            return View(m_Dropdown);
        }

        // GET: MasterDropdown/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var m_Dropdown = await _context.M_Dropdowns
                .FirstOrDefaultAsync(m => m.Id == id);
            if (m_Dropdown == null)
            {
                return NotFound();
            }

            return View(m_Dropdown);
        }

        // POST: MasterDropdown/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var m_Dropdown = await _context.M_Dropdowns.FindAsync(id);
            m_Dropdown.IsDeleted = true;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool M_DropdownExists(long id)
        {
            return _context.M_Dropdowns.Any(e => e.Id == id && !e.IsDeleted);
        }
    }
}
