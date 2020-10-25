using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SportsManagementSystem.Data;
using SportsManagementSystem.Models;

namespace SportsManagementSystem.Controllers
{
    [Authorize(Roles = "EventManager")]
    public class EventPhotoesController : Controller
    {
        private readonly SportsDbContext _context;

        public EventPhotoesController(SportsDbContext context)
        {
            _context = context;
        }

        // GET: EventPhotoes
        public async Task<IActionResult> Index()
        {
            var sportsDbContext = _context.EventPhotos.Include(e => e.Event);
            return View(await sportsDbContext.ToListAsync());
        }

        // GET: EventPhotoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventPhoto = await _context.EventPhotos
                .Include(e => e.Event)
                .FirstOrDefaultAsync(m => m.PhotoId == id);
            if (eventPhoto == null)
            {
                return NotFound();
            }

            return View(eventPhoto);
        }

        // GET: EventPhotoes/Create
        public IActionResult Create()
        {
            ViewData["EventId"] = new SelectList(_context.Events, "EventId", "EventId");
            return View();
        }

        // POST: EventPhotoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PhotoId,Photo,PhotoTags,EventId")] EventPhoto eventPhoto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(eventPhoto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EventId"] = new SelectList(_context.Events, "EventId", "EventId", eventPhoto.EventId);
            return View(eventPhoto);
        }

        // GET: EventPhotoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventPhoto = await _context.EventPhotos.FindAsync(id);
            if (eventPhoto == null)
            {
                return NotFound();
            }
            ViewData["EventId"] = new SelectList(_context.Events, "EventId", "EventId", eventPhoto.EventId);
            return View(eventPhoto);
        }

        // POST: EventPhotoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PhotoId,Photo,PhotoTags,EventId")] EventPhoto eventPhoto)
        {
            if (id != eventPhoto.PhotoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(eventPhoto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EventPhotoExists(eventPhoto.PhotoId))
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
            ViewData["EventId"] = new SelectList(_context.Events, "EventId", "EventId", eventPhoto.EventId);
            return View(eventPhoto);
        }

        // GET: EventPhotoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventPhoto = await _context.EventPhotos
                .Include(e => e.Event)
                .FirstOrDefaultAsync(m => m.PhotoId == id);
            if (eventPhoto == null)
            {
                return NotFound();
            }

            return View(eventPhoto);
        }

        // POST: EventPhotoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var eventPhoto = await _context.EventPhotos.FindAsync(id);
            _context.EventPhotos.Remove(eventPhoto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EventPhotoExists(int id)
        {
            return _context.EventPhotos.Any(e => e.PhotoId == id);
        }
    }
}
