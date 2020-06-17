using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuickAPI.Models;

namespace QuickAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MonstersController : ControllerBase
    {

        private readonly DnDContext _context;

        public MonstersController(DnDContext context)
        {
            _context = context;

            _context.Database.EnsureCreated();
        }

        [HttpGet]
        public async Task<IActionResult> GetMonsters() {
            return Ok(await _context.Monsters.ToArrayAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetMonster(int id)
        {
            var monster = _context.Monsters.Find(id);
            if (monster == null)
            {
                return NotFound();
            }
            return Ok(monster);
        }
    }
}