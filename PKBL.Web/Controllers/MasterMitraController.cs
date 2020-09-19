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
    public class MasterMitraController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MasterMitraController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MasterMitra
        public async Task<IActionResult> Index()
        {
            return View(await _context.M_Mitras.Where(x=> !x.IsDeleted).ToListAsync());
        }

        // GET: MasterMitra/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var m_Mitra = await _context.M_Mitras
                .FirstOrDefaultAsync(m => m.Id == id);
            if (m_Mitra == null)
            {
                return NotFound();
            }

            return View(m_Mitra);
        }

        // GET: MasterMitra/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MasterMitra/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,RequestorAddress,AddressDistrict,HomeOwnershipId,RequestorPhone1,RequestorPhone2,RequestorMail,MaritalStatusId,EducationLevelId,CompanyDataId,Family_Relative_ID,Other_Relative_ID,Car_Mortage_ID,Motorcycle_Mortage_ID,Other_Mortage_ID,MortageRemarks,Administrative_Id,Production_Activity_Id1,Production_Activity_Id2,Production_Activity_Id3,Production_Activity_Id4,IsProductHandMade,IsMachineMade,Owned_Tool1,Owned_Tool1_count,Owned_Tool2,Owned_Tool2_count,Owned_Tool3,Owned_Tool3_count,Owned_Tool4,Owned_Tool4_count,Service_Provided,Marketing,IsLocalMarket,IsExport,Checklist_Id,UploadedFile,InventoryUpdateId,MGRNoProposal,TglBermasalah")] M_Mitra m_Mitra)
        {
            if (ModelState.IsValid)
            {
                _context.Add(m_Mitra);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(m_Mitra);
        }

        // GET: MasterMitra/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var m_Mitra = await _context.M_Mitras.FindAsync(id);
            if (m_Mitra == null)
            {
                return NotFound();
            }
            return View(m_Mitra);
        }

        // POST: MasterMitra/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,RequestorAddress,AddressDistrict,HomeOwnershipId,RequestorPhone1,RequestorPhone2,RequestorMail,MaritalStatusId,EducationLevelId,CompanyDataId,Family_Relative_ID,Other_Relative_ID,Car_Mortage_ID,Motorcycle_Mortage_ID,Other_Mortage_ID,MortageRemarks,Administrative_Id,Production_Activity_Id1,Production_Activity_Id2,Production_Activity_Id3,Production_Activity_Id4,IsProductHandMade,IsMachineMade,Owned_Tool1,Owned_Tool1_count,Owned_Tool2,Owned_Tool2_count,Owned_Tool3,Owned_Tool3_count,Owned_Tool4,Owned_Tool4_count,Service_Provided,Marketing,IsLocalMarket,IsExport,Checklist_Id,UploadedFile,InventoryUpdateId,MGRNoProposal,TglBermasalah,CreatedBy,CreatedDate")] M_Mitra m_Mitra)
        {
            if (id != m_Mitra.Id || !M_MitraExists(m_Mitra.Id))
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(m_Mitra);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!M_MitraExists(m_Mitra.Id))
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
            return View(m_Mitra);
        }

        // GET: MasterMitra/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var m_Mitra = await _context.M_Mitras
                .FirstOrDefaultAsync(m => m.Id == id);
            if (m_Mitra == null)
            {
                return NotFound();
            }

            return View(m_Mitra);
        }

        // POST: MasterMitra/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var m_Mitra = await _context.M_Mitras.FindAsync(id);
            m_Mitra.IsDeleted = true;
            //_context.M_Mitras.Remove(m_Mitra);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool M_MitraExists(long id)
        {
            return _context.M_Mitras.Any(e => e.Id == id && !e.IsDeleted);
        }
    }
}
