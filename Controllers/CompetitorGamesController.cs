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
    [Authorize(Roles = "Admin")]
    public class CompetitorGamesController : Controller
    {
        private readonly SportsDbContext _context;

        public CompetitorGamesController(SportsDbContext context)
        {
            _context = context;
        }

        // GET: CompetitorGames
        public async Task<IActionResult> Index()
        {
            var sportsDbContext = _context.CompetitorGames.Include(c => c.Competitor).Include(c => c.Game);
            return View(await sportsDbContext.ToListAsync());
        }

        // GET: CompetitorGames/Details/5
        public async Task<IActionResult> Details(int? Game_ID, int? Competitor_ID)
        {
            if (Game_ID == null || Competitor_ID == null)
            {
                return NotFound();
            }

            var competitorGames = await _context.CompetitorGames
                .Include(c => c.Competitor)
                .Include(c => c.Game)
                .FirstOrDefaultAsync(m => m.CompetitorId == Competitor_ID);
            if (competitorGames == null)
            {
                return NotFound();
            }

            return View(competitorGames);
        }

        // GET: CompetitorGames/Create
        public IActionResult Create()
        {
            ViewData["CompetitorId"] = new SelectList(_context.Competitors, "CompetitorId", "Name");
            ViewData["GameId"] = new SelectList(_context.Games, "GameId", "Code");
            return View();
        }

        // POST: CompetitorGames/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CompetitorId,GameId")] CompetitorGames competitorGames)
        {
            if (ModelState.IsValid)
            {
                _context.Add(competitorGames);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CompetitorId"] = new SelectList(_context.Competitors, "CompetitorId", "Name", competitorGames.CompetitorId);
            ViewData["GameId"] = new SelectList(_context.Games, "GameId", "Code", competitorGames.GameId);
            return View(competitorGames);
        }

        // GET: CompetitorGames/Edit/5
        public async Task<IActionResult> Edit(int? Game_ID, int? Competitor_ID)
        {
            if (Game_ID == null || Competitor_ID == null)
            {
                return NotFound();
            }

            var competitorGames = await _context.CompetitorGames.FindAsync(Competitor_ID, Game_ID);
            if (competitorGames == null)
            {
                return NotFound();
            }
            ViewData["CompetitorId"] = new SelectList(_context.Competitors, "CompetitorId", "Name", competitorGames.CompetitorId);
            ViewData["GameId"] = new SelectList(_context.Games, "GameId", "Code", competitorGames.GameId);
            return View(competitorGames);
        }

        // POST: CompetitorGames/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? Game_ID, int? Competitor_ID, [Bind("CompetitorId,GameId")] CompetitorGames competitorGames)
        {
            if (Competitor_ID != competitorGames.CompetitorId || Game_ID != competitorGames.GameId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(competitorGames);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompetitorGamesExists(competitorGames.GameId, competitorGames.CompetitorId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            ViewData["CompetitorId"] = new SelectList(_context.Competitors, "CompetitorId", "Name", competitorGames.CompetitorId);
            ViewData["GameId"] = new SelectList(_context.Games, "GameId", "Code", competitorGames.GameId);
            return View(competitorGames);
        }

        private bool CompetitorGamesExists(int? Game_ID, int? Competitor_ID)
        {
            return _context.CompetitorGames.Any(e => e.CompetitorId == Competitor_ID) && _context.CompetitorGames.Any(e => e.GameId == Game_ID);
        }
    }
}
