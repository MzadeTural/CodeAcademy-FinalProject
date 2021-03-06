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
           // IsAuthenticated();
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
           AppUser user=await _userManager.FindByNameAsync(userModel.UserName);
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

            if (await _userManager.IsInRoleAsync(user, "Admin"))
            {
                return RedirectToAction("Index", "Dashboard", new { area = "Admin" });
            }
            else if (await _userManager.IsInRoleAsync(user, "Teacher"))
            { 
                return RedirectToAction("Index", "TeacherHome", new { area = "Teacher" });
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction(nameof(AccountController.Login), "Account");
           

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
            await _userManager.AddToRoleAsync(newUser, UserRoles.Student.ToString());


            //   await _userManager.AddToRoleAsync(newUser, UserRoles.Member.ToString());

            return RedirectToAction();

        }
        public IActionResult ChangePassword()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePassword(ChangePasswordVM changePassword)
        {
            if (!ModelState.IsValid) return View(changePassword);
            AppUser user = await _userManager.GetUserAsync(User);
            if (user == null) return NotFound();

            var changetPassResult = await _userManager.ChangePasswordAsync(user, changePassword.CurrentPassword, changePassword.NewPassword);
            if (!changetPassResult.Succeeded)
            {

                foreach (var error in changetPassResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(changePassword);
            }

            return RedirectToAction(nameof(Login));
        }
        //private void IsAuthenticated()
        //{
        //    if (User.Identity.IsAuthenticated)
        //    {
        //        throw new Exception("You already authenticated!");


        //    }

        //}
        #region
        //public async Task CreateRolesandUsers()
        //{



        //    var user = new AppUser();
        //user.UserName = "201906119";
        //    user.Email = "default@defaultcode.com";
        //    user.Identifier = "AZE18062523";
        //    user.FatherName = "Xxxx";
        //    user.CourseId = 1;
        //    user.GenderId = 1;
        //    user.FullName = "Farid Mammedov";
        //    user.SpecialityId = 1;

        //    string userPWD = "Student123@";

        //IdentityResult chkUser = await _userManager.CreateAsync(user, userPWD);
        //await _userManager.AddToRoleAsync(user, UserRoles.Teacher.ToString());


        //}

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
