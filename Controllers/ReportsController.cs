using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SportsManagementSystem.Data;
using SportsManagementSystem.Models;

namespace SportsManagementSystem.Controllers
{
    [Authorize(Roles = "EventManager")]
    public class ReportsController : Controller
    {
        private readonly SportsDbContext _context;

        public ReportsController(SportsDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Events.ToListAsync());
        }


        public class Leaderboard
        {
            public Dictionary<string, int> Countries = new Dictionary<string, int>();
        }

        public async Task<IActionResult> TallyList()
        {
            var outcomes = await _context.EventOutcomes.ToListAsync();
            var competitors = await _context.Competitors.ToListAsync();

            Leaderboard board = new Leaderboard();

            foreach (var comp in competitors)
            {
                if (!board.Countries.ContainsKey(comp.Country))
                {
                    board.Countries.Add(comp.Country, 0);
                }
            }

            foreach (var outcome in outcomes)
            {
                if (outcome.Medal == "Gold" || outcome.Medal == "Silver" || outcome.Medal == "Bronze")
                {
                    foreach (var comp in competitors)
                    {
                        if (comp.CompetitorId == outcome.CompetitorId)
                        {
                            board.Countries[comp.Country]++;
                        }
                    }
                }
            }

            var sortedList = board.Countries.ToList();
            sortedList.Sort((pair1, pair2) => pair2.Value.CompareTo(pair1.Value));

            return View(sortedList);
        }

        public async Task<IActionResult> Search(string searchTerm)
        {
            var query =
                from s in _context.EventPhotos
                select s;

            if (!String.IsNullOrEmpty(searchTerm))
            {
                query = query.Where(s => s.PhotoTags.Contains(searchTerm));
            }

            return View(await query.ToListAsync());
        }
    }
}
