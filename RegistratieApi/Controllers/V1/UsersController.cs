using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RegistratieApi.Data;
using RegistratieApi.Models;

namespace RegistratieApi.Controllers.V1
{
    [Route("api/V1/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly RegistratieApiContext _context;

        public UsersController(RegistratieApiContext context)
        {
            _context = context;
        }

        // GET: api/V1/Users
        [HttpGet]
        public async Task<IEnumerable<User>> GetUser()
        {
            IEnumerable<User> users = await _context.User.ToListAsync();
            foreach (User user in users)
            {
                user.Registrations = _context.Registration.Where(r => r.UserId == user.OvNummer).ToList();
            }
            return users;
        }

        // GET: api/V1/Users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = await _context.User.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            user.Registrations = _context.Registration.Where(r => r.UserId == user.OvNummer).ToList();

            return user;
        }

        // PUT: api/V1/Users/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<ActionResult<string>> PutUser(int id, User user)
        {
            if (id != user.OvNummer)
            {
                return BadRequest();
            }

            _context.Entry(user).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return "Gelukt";
        }

        // POST: api/V1/Users
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User user)
        {
            _context.User.Add(user);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUser", new { id = user.OvNummer }, user);
        }

        // DELETE: api/V1/Users/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<User>> DeleteUser(int id)
        {
            var user = await _context.User.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.User.Remove(user);
            await _context.SaveChangesAsync();

            return user;
        }

        private bool UserExists(int id)
        {
            return _context.User.Any(e => e.OvNummer == id);
        }
    }
}
