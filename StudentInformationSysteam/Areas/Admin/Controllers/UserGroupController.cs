﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentIformationSysteam.Core.Models;
using StudentInformationSysteam.Business.ViewModel.UserGroup;
using StudnetInformationSysteam.Data.DAL;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentInformationSysteam.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserGroupController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public UserGroupController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        // GET: UserGroupController
        public ActionResult Index()
        {
            return View();
        }

        // GET: UserGroupController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserGroupController/Create
        public ActionResult AddStudentToGroup(int id)

        {
           

          
        return View();
    }
        
            
    


        // POST: UserGroupController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddStudentToGroup(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserGroupController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserGroupController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserGroupController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserGroupController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
