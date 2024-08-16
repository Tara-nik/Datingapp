using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;

namespace API.Controllers
{
    public class UserController(DataContext context) : BaseApiController
    {
        //private readonly DataContext _context = context;

        [AllowAnonymous]
        [HttpGet]
        public async Task <ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            var users = await context.Users.ToListAsync();
            return users;
        
        }
        [Authorize]
        [HttpGet("{id}")] // /api/user/2
        

        public async Task <ActionResult<AppUser>> GetUser(int id)
        {
            return await context.Users.FindAsync(id);
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}