using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SkyNet2.Models.Users;
using SkyNet2.ViewModels.Account;

namespace SkyNet2.Controllers.Account;

public class RegisterController : Controller
{
    private readonly IMapper _mapper;
    private readonly UserManager<User> _userManager;
    private readonly SignInManager<User> _signInManager;

    public RegisterController(IMapper mapper, UserManager<User> userManager, SignInManager<User> signInManager)
    {
        _mapper = mapper;
        _userManager = userManager;
        _signInManager = signInManager;
    }

    [Route("Register")]
    [HttpGet]
    public IActionResult Register()
    {
        return View("Register");
    }

    [Route("RegisterPart2")]
    [HttpGet]
    public IActionResult RegisterPart2(RegisterViewModel model)
    {
        return View("RegisterPart2", model);
    }

    [Route("Register")]
    [HttpPost]
    public async Task<IActionResult> Register(RegisterViewModel model)
    {
        if (ModelState.IsValid)
        {
            var user = _mapper.Map<User>(model);
            var result = await _userManager.CreateAsync(user, model.PasswordReg);

            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(user, false);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
        }

        return View("RegisterPart2", model);
    }
}