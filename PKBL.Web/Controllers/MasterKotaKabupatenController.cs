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
    public class MasterKotaKabupatenController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MasterKotaKabupatenController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MasterKotaKabupaten
        public async Task<IActionResult> Index()
        {
            return View(await _context.M_KotaKabupatens.Where(x=>!x.IsDeleted).ToListAsync());
        }

        // GET: MasterKotaKabupaten/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var m_KotaKabupaten = await _context.M_KotaKabupatens
                .FirstOrDefaultAsync(m => m.City_Id == id);
            if (m_KotaKabupaten == null)
            {
                return NotFound();
            }

            return View(m_KotaKabupaten);
        }

        // GET: MasterKotaKabupaten/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MasterKotaKabupaten/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("City_Id2,City_Id,City_AppCode,City_Name,Province_Code,Prefix")] M_KotaKabupaten m_KotaKabupaten)
        {
            if (ModelState.IsValid)
            {
                _context.Add(m_KotaKabupaten);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(m_KotaKabupaten);
        }

        // GET: MasterKotaKabupaten/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var m_KotaKabupaten = await _context.M_KotaKabupatens.FindAsync(id);
            if (m_KotaKabupaten == null)
            {
                return NotFound();
            }
            return View(m_KotaKabupaten);
        }

        // POST: MasterKotaKabupaten/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("City_Id2,City_Id,City_AppCode,City_Name,Province_Code,Prefix,CreatedBy,CreatedDate")] M_KotaKabupaten m_KotaKabupaten)
        {
            if (id != m_KotaKabupaten.City_Id || !M_KotaKabupatenExists(m_KotaKabupaten.City_Id))
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(m_KotaKabupaten);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!M_KotaKabupatenExists(m_KotaKabupaten.City_Id))
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
            return View(m_KotaKabupaten);
        }

        // GET: MasterKotaKabupaten/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var m_KotaKabupaten = await _context.M_KotaKabupatens
                .FirstOrDefaultAsync(m => m.City_Id == id);
            if (m_KotaKabupaten == null)
            {
                return NotFound();
            }

            return View(m_KotaKabupaten);
        }

        // POST: MasterKotaKabupaten/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var m_KotaKabupaten = await _context.M_KotaKabupatens.FindAsync(id);
            m_KotaKabupaten.IsDeleted = true;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool M_KotaKabupatenExists(string id)
        {
            return _context.M_KotaKabupatens.Any(e => e.City_Id == id && !e.IsDeleted);
        }
    }
}
