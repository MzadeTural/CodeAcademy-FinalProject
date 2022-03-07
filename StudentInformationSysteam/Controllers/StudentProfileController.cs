﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentIformationSysteam.Core.Models;
using StudentInformationSysteam.Business.ViewModel.StudentProfile;
using StudnetInformationSysteam.Data.DAL;
using System.Linq;
using System.Threading.Tasks;

namespace StudentInformationSysteam.Controllers
{
    public class StudentProfileController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public StudentProfileController( AppDbContext context,UserManager<AppUser> userManager)

        {
            _context = context;
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            //ProfileVM profileVM = new ProfileVM
            //{
            //    // FateherName = _context.Users.FirstOrDefault().ToString(),
            //    // GroupName=_context.Users.Include(i=>i.UserGroups).ThenInclude().ToString(),
            //   // Course = _context.Users.Include(i => i.Course).FirstOrDefault()
              

            //};
            AppUser user = await  _userManager.GetUserAsync(User);
            if (user == null) return Content("NULL");
            var users = _userManager.Users.Select(c => new ProfileVM
            {
               
                FullName = c.FullName

                
            }).FirstOrDefault();

            return View(users);
        }
    }
}