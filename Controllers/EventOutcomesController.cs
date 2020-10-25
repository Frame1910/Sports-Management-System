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
    public class EventOutcomesController : Controller
    {
        private readonly SportsDbContext _context;

        public EventOutcomesController(SportsDbContext context)
        {
            _context = context;
        }

        // GET: EventOutcomes
        public async Task<IActionResult> Index()
        {
            var sportsDbContext = _context.EventOutcomes.Include(e => e.Competitor).Include(e => e.Event);
            return View(await sportsDbContext.ToListAsync());
        }

        // GET: EventOutcomes/Details/5
        public async Task<IActionResult> Details(int? Event_ID, int? Competitor_ID)
        {
            if (Event_ID == null || Competitor_ID == null)
            {
                return NotFound();
            }

            var eventOutcome = await _context.EventOutcomes
                .Include(e => e.Competitor)
                .Include(e => e.Event)
                .FirstOrDefaultAsync(m => m.EventId == Event_ID);
            if (eventOutcome == null)
            {
                return NotFound();
            }

            return View(eventOutcome);
        }

        // GET: EventOutcomes/Create
        public IActionResult Create()
        {
            ViewData["CompetitorId"] = new SelectList(_context.Competitors, "CompetitorId", "Name");
            ViewData["EventId"] = new SelectList(_context.Events, "EventId", "EventId");
            return View();
        }

        // POST: EventOutcomes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EventId,CompetitorId,Position")] EventOutcome eventOutcome)
        {
            if (ModelState.IsValid)
            {
                _context.Add(eventOutcome);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CompetitorId"] = new SelectList(_context.Competitors, "CompetitorId", "Name", eventOutcome.CompetitorId);
            ViewData["EventId"] = new SelectList(_context.Events, "EventId", "EventId", eventOutcome.EventId);
            return View(eventOutcome);
        }

        // GET: EventOutcomes/Delete/5
        public async Task<IActionResult> Delete(int? Event_ID, int? Competitor_ID)
        {
            if (Event_ID == null || Competitor_ID == null)
            {
                return NotFound();
            }

            var eventOutcome = await _context.EventOutcomes
                .Include(e => e.Competitor)
                .Include(e => e.Event)
                .FirstOrDefaultAsync(m => m.EventId == Event_ID);
            if (eventOutcome == null)
            {
                return NotFound();
            }

            return View(eventOutcome);
        }

        // POST: EventOutcomes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int Event_ID, int Competitor_ID)
        {
            var eventOutcome = await _context.EventOutcomes.FindAsync(Event_ID, Competitor_ID);
            _context.EventOutcomes.Remove(eventOutcome);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EventOutcomeExists(int? Event_ID, int? Competitor_ID)
        {
            return _context.EventOutcomes.Any(e => e.EventId == Event_ID) || _context.EventOutcomes.Any(e => e.CompetitorId == Competitor_ID);
        }
    }
}
