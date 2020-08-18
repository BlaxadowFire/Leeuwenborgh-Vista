using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetflixCasusApi.Data;
using NetflixCasusApi.Models;

namespace NetflixCasusApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly NetflixCasusApiContext _context;

        public UsersController(NetflixCasusApiContext context)
        {
            _context = context;
        }

        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUser()
        {
            return await _context.User.ToListAsync();
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = await _context.User.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        // PUT: api/Users/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(int id, User user)
        {
            if (id != user.UserId)
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

            return NoContent();
        }

        // POST: api/Users
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User user)
        {
            _context.User.Add(user);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUser", new { id = user.UserId }, user);
        }

        // DELETE: api/Users/5
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

        [HttpPost("GetSubscriptionByUser")]
        public async Task<ActionResult<Subscription>> GetSubscriptionByUser(User user)
        {
            if (user == null || !_context.User.Contains(user))
                return NotFound();

            var contextUser = _context.User.Find(user.UserId);
            foreach (var sub in _context.Subscription.Include(s => s.Users))
            {
                if (sub.Users != null && sub.Users.Contains(contextUser))
                    return sub;
            }
            //Workaround for code underneath of this comment.


            //Subscription subscription = await _context.Subscription.Where(s => s.Users.Contains(contextUser)).FirstAsync();
            
            //Should work, but it doesn't work. It gives a strange error.

            return NotFound();
        }

        [HttpPost("GetAllUsersByUser")]
        public async Task<ActionResult<List<User>>> GetAllUsersByUser(User user)
        {
            Subscription subscription = null;
            if (user == null || !_context.User.Contains(user))
                return NotFound();

            var contextUser = _context.User.Find(user.UserId);
            foreach (var sub in _context.Subscription.Include(s => s.Users))
            {
                if (sub.Users != null && sub.Users.Contains(contextUser))
                { 
                    subscription = sub;
                    break;
                }
            }

            if (subscription.Users == null)
                return NotFound();
            //Workaround for code underneath of this comment.

            //Subscription subscription = await _context.Subscription.Where(s => s.Users.Contains(contextUser)).FirstAsync();

            //Should work, but it doesn't work. It gives a strange error.

            return subscription.Users.ToList();
        }


        private bool UserExists(int id)
        {
            return _context.User.Any(e => e.UserId == id);
        }
    }
}
