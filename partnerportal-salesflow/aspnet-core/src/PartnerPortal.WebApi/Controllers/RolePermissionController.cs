﻿using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PartnerPortal.Domain.Entities;
using PartnerPortal.Infrastructure.Identity;
using PartnerPortal.Infrastructure.Persistence;

namespace PartnerPortal.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolePermissionController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public RolePermissionController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RolesPermission>>> GetRolePermission()
        {
            if (_dbContext.RolePermission == null)
            {
                return NotFound();
            }
            return await _dbContext.RolePermission.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<RolesPermission>>> GetRolePermissionsByRoleID(Guid id)
        {
            if (_dbContext.RolePermission == null)
            {
                return NotFound();
            }
            var rp = await _dbContext.RolePermission.Where(x => x.Id == id.ToString()).ToListAsync();
            if (rp == null)
            {
                return NotFound();
            }
            return rp;
        }
        [HttpPost]
        public async Task<ActionResult<RolesPermission>> PostRoleP(RolesPermission rolep)
        {
            _dbContext.RolePermission.Add(rolep);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutRoleP(Guid id, RolesPermission rolep)
        {
            _dbContext.Entry(rolep).State = EntityState.Modified;

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RPExits(id))
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
        private bool RPExits(Guid id)
        {
            return (_dbContext.RolePermission.Any(e => e.Id == id.ToString()));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<RolesPermission>> DeleteRoleP(Guid id)
        {
            if (_dbContext.RolePermission == null)
            {
                return NotFound();
            }
            var rolep = await _dbContext.RolePermission.Where(r => r.Id == id.ToString()).ToListAsync();
            foreach (var role in rolep)
            {
                _dbContext.RolePermission.Remove(role);
            }
            await _dbContext.SaveChangesAsync();
            return NoContent();
        }
    }
}
