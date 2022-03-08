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
        [AllowAnonymous]
        public IActionResult Login(string returnUrl = null)
        {
            //IsAuthenticated();
            //ViewData["ReturnUrl"] = returnUrl;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginVM userModel, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(userModel);
            }
          var user=await _userManager.FindByEmailAsync(userModel.Email);
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



            //   await _userManager.AddToRoleAsync(newUser, UserRoles.Member.ToString());

            return RedirectToAction();



        }
        #region
        public async Task CreateRolesandUsers()
        {


            // first we create Admin rool    


            //Here we create a Admin super user who will maintain the website                   

            var user = new AppUser();
            user.UserName = "default";
            user.Email = "default@defaultcode.com";
            user.Identifier = 201906138;
            user.FatherName = "Ariz";
            user.CourseId = 1;
            user.Gender = true;
            user.FullName = "ILkin Memmedzade";

            string userPWD = "Tural123@";

            IdentityResult chkUser = await _userManager.CreateAsync(user, userPWD);
            await _userManager.AddToRoleAsync(user, UserRoles.Admin.ToString());

            //Add default User to Role Admin    

        }

        #endregion

        #region CreateRole
        //public async Task CreateRole()
        //{
        //    foreach (var role in Enum.GetValues(typeof(UserRoles)))
        //    {
        //        if (!await _roleManager.RoleExistsAsync(role.ToString()))
        //        {
        //            await _roleManager.CreateAsync(new IdentityRole { Name = role.ToString() });
        //        }
        //    }
        //}
        #endregion

    }
}
