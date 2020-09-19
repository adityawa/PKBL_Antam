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
    public class MasterRefDataUsahaMitraController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MasterRefDataUsahaMitraController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MasterRefDataUsahaMitra
        public async Task<IActionResult> Index()
        {
            return View(await _context.M_RefDataUsahaMitras.Where(x=>!x.IsDeleted).ToListAsync());
        }

        // GET: MasterRefDataUsahaMitra/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var m_RefDataUsahaMitra = await _context.M_RefDataUsahaMitras
                .FirstOrDefaultAsync(m => m.Id == id);
            if (m_RefDataUsahaMitra == null)
            {
                return NotFound();
            }

            return View(m_RefDataUsahaMitra);
        }

        // GET: MasterRefDataUsahaMitra/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MasterRefDataUsahaMitra/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CompSectorDetail,CompName,CompCEO,Address,CityId,PostalCode,Phone1,Phone2,Fax,Email,OwnWorkPlace,WorkPlace_Enddate,ActiveSince,Workforce,WorkingCapital,Investment,MonthlyRevenue,CompanyUnit,HasJournalAdmin,JournalAdministration,HasOtherLoan,OtherLoanAt,OtherLoanAmt,MitraId,MGRProposalNo")] M_RefDataUsahaMitra m_RefDataUsahaMitra)
        {
            if (ModelState.IsValid)
            {
                _context.Add(m_RefDataUsahaMitra);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(m_RefDataUsahaMitra);
        }

        // GET: MasterRefDataUsahaMitra/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var m_RefDataUsahaMitra = await _context.M_RefDataUsahaMitras.FindAsync(id);
            if (m_RefDataUsahaMitra == null)
            {
                return NotFound();
            }
            return View(m_RefDataUsahaMitra);
        }

        // POST: MasterRefDataUsahaMitra/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,CompSectorDetail,CompName,CompCEO,Address,CityId,PostalCode,Phone1,Phone2,Fax,Email,OwnWorkPlace,WorkPlace_Enddate,ActiveSince,Workforce,WorkingCapital,Investment,MonthlyRevenue,CompanyUnit,HasJournalAdmin,JournalAdministration,HasOtherLoan,OtherLoanAt,OtherLoanAmt,MitraId,MGRProposalNo,CreatedBy,CreatedDate")] M_RefDataUsahaMitra m_RefDataUsahaMitra)
        {
            if (id != m_RefDataUsahaMitra.Id || !M_RefDataUsahaMitraExists(m_RefDataUsahaMitra.Id))
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(m_RefDataUsahaMitra);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!M_RefDataUsahaMitraExists(m_RefDataUsahaMitra.Id))
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
            return View(m_RefDataUsahaMitra);
        }

        // GET: MasterRefDataUsahaMitra/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var m_RefDataUsahaMitra = await _context.M_RefDataUsahaMitras
                .FirstOrDefaultAsync(m => m.Id == id);
            if (m_RefDataUsahaMitra == null)
            {
                return NotFound();
            }

            return View(m_RefDataUsahaMitra);
        }

        // POST: MasterRefDataUsahaMitra/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var m_RefDataUsahaMitra = await _context.M_RefDataUsahaMitras.FindAsync(id);
            m_RefDataUsahaMitra.IsDeleted = true;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool M_RefDataUsahaMitraExists(long id)
        {
            return _context.M_RefDataUsahaMitras.Any(e => e.Id == id && !e.IsDeleted);
        }
    }
}
