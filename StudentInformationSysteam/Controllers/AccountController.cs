using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudentIformationSysteam.Core.Models;
using StudentInformationSysteam.Business.ViewModel.Account;
using StudnetInformationSysteam.Data.DAL;
using System;
using System.Threading.Tasks;

namespace StudentInformationSysteam.Controllers
{

    public class AccountController : Controller
    {  // private readonly IMapper _mapper;
      
        public AppDbContext _context { get; }
        private UserManager<AppUser> _userManager;
        private SignInManager<AppUser> _signInManager;
        public RoleManager<IdentityRole> _roleManager;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager, AppDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
           
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginVM userModel, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(userModel);
            }
            AppUser user = await _userManager.FindByEmailAsync(userModel.Email);
            if (user == null)
            {
                ModelState.AddModelError(String.Empty, "Email or Pasword is wrong");
                return View(userModel);
            }
           

            var result = await _signInManager.PasswordSignInAsync(user, userModel.Password, userModel.RememberMe, true);

            if (result.IsLockedOut)
            {
                ModelState.AddModelError(String.Empty, "Please,Wait a few moment");
                return View(userModel);
            }

            if (!result.Succeeded)
            {
                ModelState.AddModelError(String.Empty, "Email or Pasword is wrong");
                return View(userModel);
            }
            if (returnUrl != null)
            {
                return Redirect(returnUrl);
            }
            //if (await _userManager.IsInRoleAsync(user,"SuperAdmin"))
            //{
            //    return RedirectToAction("Index", "Dashboard", new { area = "AdminFiorella" });
            //}

            return RedirectToAction("Index", "Home");

        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction(nameof(HomeController.Index), "Home");
        }
        public async Task<IActionResult> Register(RegisterVM register)
        {
            if (!ModelState.IsValid) return View(register);

            AppUser newUser = new AppUser
            {
                FullName = register.FullName
             
            };
            IdentityResult identityResult = await _userManager.CreateAsync(newUser, register.Password);
            if (!identityResult.Succeeded)
            {
                foreach (var error in identityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(register);
            }
           
 #region
            
            #endregion

         //   await _userManager.AddToRoleAsync(newUser, UserRoles.Member.ToString());

            return RedirectToAction();



        }

    }
}
