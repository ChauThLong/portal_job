﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using portal_job_FN.Models;

namespace portal_job_FN.Repositories
{
    public class EFUserRepository : IUserRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;
        public EFUserRepository(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IEnumerable<ApplicationUser>> GetAllAsync()
        {
            var usersInRole = await _userManager.GetUsersInRoleAsync("User");
            return usersInRole.ToList();
        }

        public async Task DeleteAsync(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                await _userManager.DeleteAsync(user);
            }
        }

        public async Task<ApplicationUser> GetByIdAsync(string id)
        {
            return await _userManager.FindByIdAsync(id);
        }

        public async Task<IEnumerable<ApplicationUser>> GetAllCompanyAsync()
        {
            var usersInRole = await _userManager.GetUsersInRoleAsync("Company");
            return usersInRole.ToList();
        }
    }
}
