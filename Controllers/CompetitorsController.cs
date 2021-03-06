﻿using System;
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
    public class CompetitorsController : Controller
    {
        private readonly SportsDbContext _context;

        public CompetitorsController(SportsDbContext context)
        {
            _context = context;
        }

        // GET: Competitors
        public async Task<IActionResult> Index()
        {
            return View(await _context.Competitors.ToListAsync());
        }

        // GET: Competitors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var competitor = await _context.Competitors
                .FirstOrDefaultAsync(m => m.CompetitorId == id);
            if (competitor == null)
            {
                return NotFound();
            }

            return View(competitor);
        }

        // GET: Competitors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Competitors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CompetitorId,Salutation,Name,Dob,Email,Description,Country,Gender,ContactNo,Website,Photo")] Competitor competitor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(competitor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(competitor);
        }

        // GET: Competitors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var competitor = await _context.Competitors.FindAsync(id);
            if (competitor == null)
            {
                return NotFound();
            }
            return View(competitor);
        }

        // POST: Competitors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CompetitorId,Salutation,Name,Dob,Email,Description,Country,Gender,ContactNo,Website,Photo")] Competitor competitor)
        {
            if (id != competitor.CompetitorId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(competitor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompetitorExists(competitor.CompetitorId))
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
            return View(competitor);
        }

        // GET: Competitors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var competitor = await _context.Competitors
                .FirstOrDefaultAsync(m => m.CompetitorId == id);
            if (competitor == null)
            {
                return NotFound();
            }

            return View(competitor);
        }

        // POST: Competitors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var competitor = await _context.Competitors.FindAsync(id);
            _context.Competitors.Remove(competitor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompetitorExists(int id)
        {
            return _context.Competitors.Any(e => e.CompetitorId == id);
        }
    }
}
