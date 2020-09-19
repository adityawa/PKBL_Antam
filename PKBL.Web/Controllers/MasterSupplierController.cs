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
    public class MasterSupplierController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MasterSupplierController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MasterSupplier
        public async Task<IActionResult> Index()
        {
            return View(await _context.M_Suppliers.Where(x=>!x.IsDeleted).ToListAsync());
        }

        // GET: MasterSupplier/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var m_Supplier = await _context.M_Suppliers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (m_Supplier == null)
            {
                return NotFound();
            }

            return View(m_Supplier);
        }

        // GET: MasterSupplier/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MasterSupplier/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SupplierName,Alamat,Phone,Fax,Keterangan,Pic,Jabatan,BranchCode,SupplierCode,TglDaftar,group_penokode")] M_Supplier m_Supplier)
        {
            if (ModelState.IsValid)
            {
                _context.Add(m_Supplier);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(m_Supplier);
        }

        // GET: MasterSupplier/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var m_Supplier = await _context.M_Suppliers.FindAsync(id);
            if (m_Supplier == null)
            {
                return NotFound();
            }
            return View(m_Supplier);
        }

        // POST: MasterSupplier/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,SupplierName,Alamat,Phone,Fax,Keterangan,Pic,Jabatan,BranchCode,SupplierCode,TglDaftar,group_penokode,CreatedBy,CreatedDate")] M_Supplier m_Supplier)
        {
            if (id != m_Supplier.Id || !M_SupplierExists(m_Supplier.Id))
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(m_Supplier);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!M_SupplierExists(m_Supplier.Id))
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
            return View(m_Supplier);
        }

        // GET: MasterSupplier/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var m_Supplier = await _context.M_Suppliers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (m_Supplier == null)
            {
                return NotFound();
            }

            return View(m_Supplier);
        }

        // POST: MasterSupplier/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var m_Supplier = await _context.M_Suppliers.FindAsync(id);
            m_Supplier.IsDeleted = true;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool M_SupplierExists(long id)
        {
            return _context.M_Suppliers.Any(e => e.Id == id && !e.IsDeleted);
        }
    }
}
